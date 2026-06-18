# PROJECT_FILE_INDEX.md — Key Files in Assets/Sandbox/

_Last updated: 2026-06-18_

## Directory structure (planned)

```
Assets/Sandbox/
├── Registry/
│   ├── SANDBOX_CRAZY_LOG.md      Human-readable experiment log
│   └── SANDBOX_CRAZY_LOG.csv     Machine-readable experiment table
├── Docs/
│   └── SANDBOX_ACTION_PLAN.md    High-level experiment roadmap
├── Experiments/
│   ├── S01_SafeMechanics/        One folder per experiment batch
│   ├── S02_ProceduralGen/
│   ├── S03_ArtTools/
│   ├── S04_AI_Blender/           VALIDATE_FIRST — do not create until approved
│   └── S05_Network/              VALIDATE_FIRST — do not create until approved
└── Shared/
    └── (shared utilities if needed across experiments)
```

## Files that exist now
| Path | Description |
|------|-------------|
| Assets/Sandbox/Registry/SANDBOX_CRAZY_LOG.md | Experiment log (created) |
| Assets/Sandbox/Registry/SANDBOX_CRAZY_LOG.csv | Experiment table (created) |
| Assets/Sandbox/Docs/SANDBOX_ACTION_PLAN.md | Action plan (created) |

## Rules
- Each experiment lives in its own folder under its batch directory.
- No cross-experiment script dependencies unless placed in Shared/.
- No .meta file edits directly — let Unity regenerate them.
