# CURRENT_STATE.md — Latest Sandbox Snapshot

_Last updated: 2026-06-21_

## Phase
**Planning S01_002** — TimeSlowBubble plan written. S01_001 awaiting OpenCode verify.

## What exists
- Baseline Unity 6 / HDRP project (HDRP 17.3.0).
- Git repo on `SANDBOX` branch.
- AI_WORKFLOW scaffold complete.
- Assets/Sandbox/ directory scaffold complete.
- `Assets/Sandbox/Docs/S01_001_anti_gravity_zone_3d_PLAN.md` — planning doc.
- `Assets/Sandbox/Scripts/AntiGravityZone.cs` — runtime MonoBehaviour (Sandbox.S01).
- `Assets/Sandbox/Docs/S01_002_time_slow_bubble_PLAN.md` — planning doc.

## What does NOT exist yet
- No prefabs.
- No test scenes.
- No custom shaders, no TMP UI, no ScriptableObjects.
- No packages beyond Unity defaults.
- TimeSlowBubble.cs (awaiting gate APPROVE_SANDBOX_RUNTIME_S01_002).

## Experiments

| ID | Name | Status | Script |
|---|---|---|---|
| S01_001 | anti_gravity_zone_3d | IN PROGRESS | AntiGravityZone.cs ✓ |
| S01_002 | TimeSlowBubble | PLANNED | Awaiting runtime gate |

## Known issues
None.

## Open questions
- Does HDRP project need `Assets/Sandbox/Scripts/` asmdef for isolation? (Low priority.)
- S01_001 OpenCode verify still pending.

---
_Update this file at the start and end of every session._
