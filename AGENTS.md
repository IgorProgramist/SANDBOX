# AGENTS.md — Agent Instructions for Sandbox

## Who reads this
Any AI agent (Claude Code, Cursor, OpenCode, Copilot, etc.) working in this repo.

## First action in every session
1. Read `AI_WORKFLOW/00_START_HERE.md`.
2. Read `AI_WORKFLOW/CURRENT_STATE.md`.
3. Read `AI_WORKFLOW/BLOCKERS.md`.
4. Read `AI_WORKFLOW/HANDOFF.md`.

## What you are allowed to do
- Create and edit files under `AI_WORKFLOW/` and `Assets/Sandbox/`.
- Create and edit `CLAUDE.md` and `AGENTS.md` if asked.
- Create files under `.cursor/rules/` if asked.

## What you are NOT allowed to do
- Edit `.gitignore`.
- Edit `ProjectSettings/`, `Packages/`, `UserSettings/`.
- Run `git add`, `git commit`, `git push`, or any staging operation.
- Install or modify packages in `Packages/manifest.json`.
- Call external APIs without `VALIDATE_FIRST` recorded in `AI_WORKFLOW/DECISIONS.md`.
- Touch any APP/ToolLab files.
- Claim "BUG_FIXED_ACTIVE" or "production-ready" status for any experiment.

## Agent roles in this workflow

| Agent | Primary role |
|-------|-------------|
| Cursor | Generate experiment code from batch spec |
| OpenCode | Verify Cursor-generated code, flag issues |
| Claude Code | Architecture review, AI_WORKFLOW management, VALIDATE_FIRST decisions |

## Logging your work
- Update `AI_WORKFLOW/WORK_LOG.md` at session end.
- Update `AI_WORKFLOW/CURRENT_STATE.md` if project state changed.
- Update `AI_WORKFLOW/REGISTRY_INDEX.md` if experiment status changed.
- Add row to `Assets/Sandbox/Registry/SANDBOX_CRAZY_LOG.csv` for new experiments.
- Update `AI_WORKFLOW/HANDOFF.md` before leaving.

## VALIDATE_FIRST procedure
If a task touches S04 or S05:
1. Stop.
2. Write a VALIDATE_FIRST entry in `AI_WORKFLOW/DECISIONS.md`.
3. Ask Igor for explicit approval before proceeding.
4. Do not generate any code until approval is recorded.
