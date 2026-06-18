# 00_START_HERE.md — Sandbox AI Workflow Entry Point

## What is this project?

**Sandbox** is Igor's crazy-experiments Unity project.  
It is completely separate from the main APP/ToolLab project.  
Purpose: fast, fearless prototyping. Experiments can fail. That is the point.

## How to orient yourself fast

| File | Purpose |
|------|---------|
| PROJECT_PROFILE.md | Project identity, stack, rules |
| CURRENT_STATE.md | Latest snapshot — what exists, what is broken |
| ACTION_PLAN.md | Next planned experiments |
| WORK_LOG.md | Per-session log |
| DECISIONS.md | Architecture/approach decisions and their rationale |
| BLOCKERS.md | Active blockers |
| REGISTRY_INDEX.md | All experiments by ID and status |
| PROJECT_FILE_INDEX.md | Key files in Assets/Sandbox/ |
| COMMIT_PROTOCOL.md | What to stage and commit, what not to touch |
| PROMPT_HISTORY.md | Saved prompts that worked |
| HANDOFF.md | Context for next session or next agent |
| CHANGELOG.md | Human-readable release notes |
| REPORTS/ | Cursor, OpenCode, Claude review outputs |
| BATCHES/ | Experiment batch definitions |

## Starting a new session

1. Read CURRENT_STATE.md.
2. Read BLOCKERS.md.
3. Read ACTION_PLAN.md.
4. Pick the next experiment from REGISTRY_INDEX.md or BATCHES/.
5. Log your session start in WORK_LOG.md.

## Hard rules (never skip)

- No external APIs until `VALIDATE_FIRST` check is done.
- No package installs without explicit Igor approval.
- No experiment promotes to APP without a prefab card + Clear/Unity review.
- No git commit / push / stage without following COMMIT_PROTOCOL.md exactly.
- No edits to .gitignore, ProjectSettings/, Packages/, UserSettings/.
