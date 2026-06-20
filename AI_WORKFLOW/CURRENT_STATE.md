# CURRENT_STATE.md — Latest Sandbox Snapshot

_Last updated: 2026-06-20_

## Phase
**Implementation** — S01_001 runtime script created. Awaiting OpenCode verify + test scene.

## What exists
- Baseline Unity 6 / HDRP project (HDRP 17.3.0).
- Git repo on `SANDBOX` branch.
- AI_WORKFLOW scaffold complete.
- Assets/Sandbox/ directory scaffold complete.
- `Assets/Sandbox/Docs/S01_001_anti_gravity_zone_3d_PLAN.md` — planning doc.
- `Assets/Sandbox/Scripts/AntiGravityZone.cs` — runtime MonoBehaviour (Sandbox.S01).

## What does NOT exist yet
- No prefabs.
- No test scenes.
- No custom shaders, no TMP UI, no ScriptableObjects.
- No packages beyond Unity defaults.

## Active experiment
`S01_001 anti_gravity_zone_3d` — IN PROGRESS (script written, not verified in Play Mode).  
Script: `Assets/Sandbox/Scripts/AntiGravityZone.cs`  
Plan doc: `Assets/Sandbox/Docs/S01_001_anti_gravity_zone_3d_PLAN.md`

## Known issues
None.

## Open questions
- Does HDRP project need `Assets/Sandbox/Scripts/` asmdef for isolation? (Low priority — no cross-project risk in Sandbox.)

---
_Update this file at the start and end of every session._
