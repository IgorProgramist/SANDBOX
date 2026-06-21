# REPORT — S01_002 TimeSlowBubble — Planning Pass

**Date:** 2026-06-21  
**Agent:** Claude Code (DOCS_ONLY_PLANNING)  
**Gate:** OPEN_SANDBOX_S01_002

---

## Summary

Planning document written for S01_002 TimeSlowBubble.  
Core design decision confirmed: **no global `Time.timeScale`**.  
Local effect achieved via per-Rigidbody velocity scaling in `FixedUpdate`.

---

## Design options evaluated

| Option | Approach | Selected |
|---|---|---|
| A | Velocity scaling in FixedUpdate | YES — first implementation |
| B | Force suppression + manual gravity | Complement only |
| C | Animator.speed per instance | YES — secondary pass |
| D | ParticleSystem simulationSpeed | Future scope |

---

## Critical risk flagged

`Time.timeScale` modification is a **CRITICAL** risk for this experiment.  
It must be enforced at code-review level (static analysis / grep) before any implementation pass is approved.

**Gate requirement:** APPROVE_SANDBOX_RUNTIME_S01_002 must explicitly restate the `Time.timeScale` prohibition.

---

## Physics analysis

Velocity-scaling in `FixedUpdate` is not true time dilation — it is velocity damping.  
Objects inside the bubble will decelerate toward the slowed state rather than instantly matching it.  
This is acceptable for a visual Sandbox demo. A more accurate approach (sub-stepping, custom physics scene)
would require VALIDATE_FIRST and likely a package — out of scope for S01.

---

## Implementation readiness

Pre-conditions for runtime gate:
- [ ] Design option confirmed (Option A — done).
- [ ] `Time.timeScale` prohibition documented (done).
- [ ] Target folder path defined (done).
- [ ] Namespace defined: `Sandbox.S01`.
- [ ] No packages required confirmed.

**Status: READY TO REQUEST RUNTIME GATE.**

---

## Next steps

1. Igor approves gate `APPROVE_SANDBOX_RUNTIME_S01_002`.
2. Separate implementation pass creates `TimeSlowBubble.cs`.
3. Separate scene pass creates `S01_TimeSlowBubbleTest.unity`.
