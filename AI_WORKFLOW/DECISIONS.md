# DECISIONS.md — Architecture & Approach Decisions

## Format
```
### DEC-### | YYYY-MM-DD | <title>
**Context:** ...
**Decision:** ...
**Alternatives considered:** ...
**Rationale:** ...
**Consequences:** ...
```

---

### DEC-001 | 2026-06-18 | Sandbox is a fully separate repo from APP
**Context:** Igor maintains a production APP/ToolLab Unity project and wants a separate space for risky experiments.  
**Decision:** Sandbox lives in its own git repo on `master` with no cross-repo file sharing.  
**Alternatives considered:** Feature branch inside APP repo.  
**Rationale:** Experiment failures cannot corrupt the APP baseline. Packages, ProjectSettings, and .mcp.json are independent.  
**Consequences:** Promotions to APP require a manual prefab card + Clear/Unity review step.

### DEC-002 | 2026-06-18 | VALIDATE_FIRST gate for AI/Blender and Network batches
**Context:** S04 and S05 involve external APIs, AI inference, and network calls — high risk for unintended data egress or dependency bloat.  
**Decision:** No work on S04 or S05 until Igor explicitly runs VALIDATE_FIRST and records approval here.  
**Alternatives considered:** Proceed optimistically and fix issues later.  
**Rationale:** Karpathy discipline — state assumptions first, ask before guessing.  
**Consequences:** S04/S05 are blocked until unblocked by Igor.
