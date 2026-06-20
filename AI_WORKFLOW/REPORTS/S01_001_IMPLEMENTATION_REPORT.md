# REPORT — S01_001 anti_gravity_zone_3d — Implementation Pass

**Date:** 2026-06-20  
**Agent:** Claude Code (RUNTIME_IMPLEMENTATION_APPROVED)  
**Gate:** APPROVE_SANDBOX_RUNTIME_S01_001  

---

## File created

`Assets/Sandbox/Scripts/AntiGravityZone.cs`

## Implementation decisions

| Decision | Choice | Reason |
|---|---|---|
| Force mode | `ForceMode.Acceleration` | Mass-independent — any Rigidbody floats equally regardless of mass |
| Tracking collection | `HashSet<Rigidbody>` | O(1) add/remove, no duplicate risk |
| Null cleanup | `RemoveWhere(rb => rb == null)` | Safe removal of destroyed objects without allocation outside FixedUpdate |
| Gizmo | `DrawWireCube` via `col.bounds` | Matches actual trigger volume shape; falls back to `DrawWireSphere(r=1)` |
| isTrigger enforcement | `Reset()` sets it; `OnValidate()` warns | Follows Unity convention — never force-save scenes |
| Component requirement | `[RequireComponent(typeof(Collider))]` | Prevents misconfiguration at GameObject level |

## HDRP compliance

- No Built-in / URP shader or material referenced.
- No package install.
- No ProjectSettings edit.
- No VFX or particle system.
- Gizmo only (editor-time, not runtime visual).

## Known limitations

- Does not disable `rb.useGravity` — uses Acceleration additive force instead.
  This means the net effect is zero gravity (cancels 9.81 down), not true reversal.
  To get reversal, `antigravityStrength` must be set to `> 9.81`. Documented — intentional per spec.
- `RemoveWhere` allocates a delegate each FixedUpdate call in older Mono runtimes.
  Acceptable for Sandbox; not suitable for high-frequency production code.

## Next steps

1. OpenCode verify (compile check).
2. Create test scene `Assets/Sandbox/Scenes/S01_AntiGravityTest.unity`.
3. Add Sphere + Rigidbody, place AntiGravityZone BoxCollider around it.
4. Play Mode: confirm sphere floats. Set `antigravityStrength = 19.62` for full reversal.
5. Update SANDBOX_CRAZY_LOG.md status → IN_PROGRESS or DONE.
