# S01_001 — anti_gravity_zone_3d — Experiment Plan

**Experiment ID:** S01_001  
**Batch:** S01 — Safe Mechanics  
**Status:** PLANNED  
**Date:** 2026-06-18  
**Author:** Claude Code (CONVEYOR MODE planning pass)

---

## Goal

Demonstrate that a trigger zone can reverse Unity's gravity for any `Rigidbody` that enters it,
and restore the original gravity vector when the body exits.  
No physics engine modifications — uses `Rigidbody.useGravity = false` + manual force injection.

---

## Player-facing idea

A glowing cube floats in the air. Walk into it → you (or any physics object) start floating upward.
Exit → normal gravity returns. Simple, satisfying, zero dependencies.

---

## Physics concept

Unity default gravity: `Physics.gravity = (0, -9.81, 0)`.

Inside the zone:
- Disable `rb.useGravity`.
- Apply `rb.AddForce(-Physics.gravity * rb.mass, ForceMode.Force)` each `FixedUpdate`
  to simulate full gravity reversal (net upward acceleration = +9.81 m/s²).

On zone exit:
- Re-enable `rb.useGravity`.
- Optionally zero out vertical velocity to avoid jarring snap.

No custom physics material, no joints, no constraints needed.

---

## Unity objects likely needed (planning only — not created yet)

| Object | Type | Purpose |
|---|---|---|
| AntiGravityZone | GameObject + BoxCollider (IsTrigger=true) | Trigger volume |
| AntiGravityZone.cs | MonoBehaviour | OnTriggerEnter/Exit + FixedUpdate force |
| Visual | MeshRenderer (semi-transparent HDRP material) | Zone boundary hint |
| TestRigidbody | Sphere + Rigidbody | Manual test object |
| TestScene | Unity Scene | Isolated test environment |

---

## Safety constraints

- **No scene edits in this planning pass.** All objects listed above are future scope.
- **No scripts created now.** Script logic is described only.
- **No package installs.** Uses only `UnityEngine.Physics` built-ins.
- **No external APIs.**
- **No cross-project edits** (no APP, no ToolLab, no ProjectSettings).
- Namespace for future script: `Sandbox.S01`.

---

## Validation checklist (for future implementation pass)

- [ ] AntiGravityZone.cs compiles with zero errors.
- [ ] A Rigidbody sphere floats upward on zone entry.
- [ ] Gravity restores on zone exit (sphere falls normally).
- [ ] Multiple Rigidbodies tracked simultaneously (Dictionary<int, bool>).
- [ ] No null-ref if Rigidbody exits before FixedUpdate fires.
- [ ] HDRP semi-transparent material assigned — no pink shader.
- [ ] Test scene runs without errors in Play mode.

---

## Later implementation steps (out of scope today)

1. Create `Assets/Sandbox/Experiments/S01_SafeMechanics/AntiGravityZone/` folder.
2. Write `AntiGravityZone.cs` (MonoBehaviour).
3. Create test scene at `Assets/Sandbox/Scenes/S01_AntiGravityTest.unity`.
4. Set up trigger volume GameObject.
5. Create HDRP transparent material for zone visualisation.
6. Manual Play Mode test: sphere, capsule, cube.
7. Write prefab card.
8. Update SANDBOX_CRAZY_LOG.md status → DONE.

---

## Out of scope now

- No VFX / particle systems.
- No player character controller.
- No UI labels.
- No audio.
- No promotion to APP.
- No shader authoring.
