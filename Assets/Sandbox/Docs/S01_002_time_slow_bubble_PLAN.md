# S01_002 — TimeSlowBubble — Experiment Plan

**Experiment ID:** S01_002  
**Batch:** S01 — Safe Mechanics  
**Status:** PLANNED  
**Date:** 2026-06-21  
**Author:** Claude Code (DOCS_ONLY_PLANNING — Gate OPEN_SANDBOX_S01_002)

---

## Goal

Demonstrate a local time-dilation zone: objects (Rigidbodies, Animators, ParticleSystems)
inside a spherical trigger zone appear to move in slow motion while the rest of the world
runs at normal speed.

**Hard constraint:** `Time.timeScale` is NEVER modified globally.  
Everything is achieved by scaling forces / velocities / animation speeds per-object,
or by switching affected objects to manual update with a local delta-time multiplier.

---

## Player-facing idea

A glowing sphere floats in the scene. Throw a physics object into it — it crawls.
Pull it out — it snaps back to normal speed instantly.  
Add a second sphere to show contrasting speeds side by side.

---

## Physics / time-scale risks

| Risk | Severity | Detail |
|---|---|---|
| Global `Time.timeScale` corruption | **CRITICAL** | Slows entire game including UI, audio, other scripts. NEVER allowed. |
| Rigidbody velocity persistence on exit | MEDIUM | Object exits bubble carrying slowed velocity — needs velocity rescale on exit. |
| Animator state machine desync | MEDIUM | `animator.speed` works per-instance but must be restored on exit. |
| FixedUpdate budget spike | LOW | FixedUpdate still runs at normal fixed timestep; force-scaling is the only local hook. |
| Nested bubbles | LOW | Two overlapping TimeSlowBubbles — reference-count the slowdown per Rigidbody. |
| ParticleSystem rate | LOW | `particleSystem.timeScale` (PS-level) not available before Unity 2023; use `simulationSpeed` on `MainModule`. |

---

## Local-only effect proposal (no global Time.timeScale)

### Option A — Velocity scaling in FixedUpdate (simplest, physics only)

```
OnTriggerEnter  → store rb.velocity, rb.angularVelocity; set rb.isKinematic = false
FixedUpdate     → rb.velocity       *= slowFactor each frame (damping towards slow)
                  rb.angularVelocity *= slowFactor
OnTriggerExit   → rescale velocity by (1 / slowFactor) to restore momentum
```

**Pro:** No dependency on Unity internals. Works with all Rigidbody types.  
**Con:** Feels "sticky" — not true time dilation. Objects decelerate rather than slow uniformly.  
**Verdict:** Simple to implement, good for first pass.

### Option B — Force suppression + manual gravity in FixedUpdate (more physical)

```
OnTriggerEnter  → disable rb.useGravity; store original drag values
FixedUpdate     → apply (Physics.gravity * rb.mass * slowFactor) manually
                  scale all AddForce calls is NOT possible without wrapping callers
OnTriggerExit   → restore rb.useGravity; restore drag
```

**Pro:** Gravity slow is smooth.  
**Con:** Cannot intercept external AddForce calls — only gravity is slowed.  
**Verdict:** Use as complement to Option A, not replacement.

### Option C — Animator.speed per instance (for animated objects)

```
OnTriggerEnter  → store animator.speed; animator.speed *= slowFactor
OnTriggerExit   → animator.speed = storedSpeed
```

**Pro:** Trivial, zero risk.  
**Con:** Only affects animations, not physics.  
**Verdict:** Required add-on for any animated object inside the bubble.

### Option D — ParticleSystem simulationSpeed

```
OnTriggerEnter  → ps.main.simulationSpeed = slowFactor  (read/write via struct copy)
OnTriggerExit   → restore
```

**Pro:** Works per PS instance.  
**Con:** Struct copy pattern is verbose. Unity version dependency.  
**Verdict:** Future scope — not in first implementation.

### Recommended first implementation: Option A + Option C

Start with velocity-damping (Option A) to prove the concept.  
Add Animator.speed (Option C) as a secondary pass if animated objects are needed.

---

## Unity objects likely needed (planning only — not created yet)

| Object | Type | Purpose |
|---|---|---|
| TimeSlowBubble.cs | MonoBehaviour | Core zone logic (Option A + C) |
| SphereCollider (isTrigger=true) | Component on zone GO | Trigger detection |
| SlowableRigidbody.cs (optional) | MonoBehaviour | Helper: stores per-object original values |
| Visual sphere | MeshRenderer (HDRP semi-transparent) | Zone boundary hint |
| Test scene | Unity Scene | Isolated test: throw cubes into bubble |

**Folder target:** `Assets/Sandbox/Experiments/S01_SafeMechanics/TimeSlowBubble/`

---

## Validation checklist (for future implementation pass)

- [ ] `Time.timeScale` is NEVER written anywhere in the script — static analysis check.
- [ ] A Rigidbody cube thrown into the bubble visibly slows down.
- [ ] Exiting the bubble restores velocity correctly (within ~10% of entry speed).
- [ ] Two bubbles active simultaneously — no cross-contamination.
- [ ] `animator.speed` restored on exit — animation resumes at normal speed.
- [ ] No null-ref if Rigidbody is destroyed while inside bubble.
- [ ] No pink shader — HDRP/Lit material used for visual sphere.
- [ ] Play Mode: no console errors.

---

## Future implementation steps (out of scope today)

1. Create `Assets/Sandbox/Scripts/TimeSlowBubble.cs`.
2. Implement `Dictionary<Rigidbody, Vector3>` to store entry velocities per tracked body.
3. `FixedUpdate`: apply velocity *= slowFactor each frame for all tracked Rigidbodies.
4. `OnTriggerExit`: rescale velocity by `1f / slowFactor`.
5. Optional: track Animators via `Dictionary<Animator, float>` for speed restore.
6. Create test scene `Assets/Sandbox/Scenes/S01_TimeSlowBubbleTest.unity`.
7. Manual test: throw multiple Rigidbodies, verify slowdown and restore.
8. Update SANDBOX_CRAZY_LOG.md status → DONE.

---

## Future approval gates required

| Gate ID | Description |
|---|---|
| APPROVE_SANDBOX_RUNTIME_S01_002 | Approve `.cs` script creation for TimeSlowBubble |
| APPROVE_SANDBOX_SCENE_S01_002 | Approve test scene creation |

---

## Out of scope now

- No `Time.timeScale` usage (ever, for this experiment).
- No runtime `.cs` script in this pass.
- No scene creation.
- No prefab creation.
- No custom HDRP material creation.
- No audio slow-down (pitch shift).
- No shader-based distortion effect.
- No player character controller.
- No UI elements.
- No promotion to APP.
- No package installs.
