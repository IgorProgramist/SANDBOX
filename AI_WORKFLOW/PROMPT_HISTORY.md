# PROMPT_HISTORY.md — Saved Prompts That Worked

_Save prompts here when they produce a great result so they can be reused._

## Format
```
### PH-### | YYYY-MM-DD | <experiment ID> | <agent>
**Context:** ...
**Prompt:** (full text)
**Result quality:** ⭐⭐⭐⭐⭐
**Notes:** ...
```

---

### PH-002 | 2026-06-20 | S01_001 anti_gravity_zone_3d | Claude Code
**Context:** RUNTIME_IMPLEMENTATION_APPROVED. Gate APPROVE_SANDBOX_RUNTIME_S01_001 active. Planning doc already complete.  
**Prompt summary:** "Implement AntiGravityZone.cs per spec: HashSet tracking, OnTriggerEnter/Exit, FixedUpdate AddForce Acceleration, null cleanup, OnDrawGizmosSelected wire gizmo, RequireComponent(Collider), OnValidate warning."  
**Result quality:** ⭐⭐⭐⭐⭐  
**Notes:** Single file created. No scenes, prefabs, materials. HDRP rules satisfied. Use this gate pattern (APPROVE_SANDBOX_RUNTIME_*) for all future runtime implementation passes.

---

### PH-001 | 2026-06-18 | S01_001 anti_gravity_zone_3d | Claude Code
**Context:** CONVEYOR MODE planning pass. Sandbox skeleton committed. No runtime code yet.  
**Prompt summary:** "Create experiment plan for anti_gravity_zone_3d. Docs/plan/registry/AI workflow logging only. No runtime implementation."  
**Result quality:** ⭐⭐⭐⭐⭐  
**Notes:** Single-pass planning. All files written without runtime code. Full CONVEYOR output format returned. Use this prompt shape for all future S01-S05 planning passes.
