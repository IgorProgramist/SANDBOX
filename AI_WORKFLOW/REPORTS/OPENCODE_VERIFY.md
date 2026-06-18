# OPENCODE_VERIFY.md — AI_WORKFLOW Scope Verification

**Date:** 2026-06-18  
**Agent:** OpenCode  
**Trigger:** PROMPT_STANDARD__OPENCODE__VERIFY_AI_WORKFLOW_AND_SCOPE_ALIGNMENT

---

## Verification Result

```
OPENCODE_AI_WORKFLOW_VERIFY_STATUS: PASS
PROJECT: I:\My\UnityProjects\Projects\UnityProjects\Sandbox
AI_WORKFLOW_PRESENT: YES
CURRENT_ROUTE_OVERRIDE_FOUND: YES (DEC-001, DEC-002 in DECISIONS.md)
```

## Changed Files (git status --short)

| File | Status | Allowed |
|------|--------|---------|
| AGENTS.md | ?? | YES |
| CLAUDE.md | ?? | YES |
| AI_WORKFLOW/00_START_HERE.md | ?? | YES |
| AI_WORKFLOW/ACTION_PLAN.md | ?? | YES |
| AI_WORKFLOW/BATCHES/BATCH_01.md | ?? | YES |
| AI_WORKFLOW/BATCHES/BATCH_02.md | ?? | YES |
| AI_WORKFLOW/BATCHES/BATCH_03.md | ?? | YES |
| AI_WORKFLOW/BATCHES/BATCH_04.md | ?? | YES |
| AI_WORKFLOW/BATCHES/BATCH_05.md | ?? | YES |
| AI_WORKFLOW/BLOCKERS.md | ?? | YES |
| AI_WORKFLOW/CHANGELOG.md | ?? | YES |
| AI_WORKFLOW/COMMIT_PROTOCOL.md | ?? | YES |
| AI_WORKFLOW/CURRENT_STATE.md | ?? | YES |
| AI_WORKFLOW/DECISIONS.md | ?? | YES |
| AI_WORKFLOW/HANDOFF.md | ?? | YES |
| AI_WORKFLOW/PROJECT_FILE_INDEX.md | ?? | YES |
| AI_WORKFLOW/PROJECT_PROFILE.md | ?? | YES |
| AI_WORKFLOW/PROMPT_HISTORY.md | ?? | YES |
| AI_WORKFLOW/REGISTRY_INDEX.md | ?? | YES |
| AI_WORKFLOW/REPORTS/CLAUDE_REVIEWS.md | ?? | YES |
| AI_WORKFLOW/REPORTS/CURSOR_RETURNS.md | ?? | YES |
| AI_WORKFLOW/REPORTS/OPENCODE_VERIFY.md | ?? | YES |
| AI_WORKFLOW/WORK_LOG.md | ?? | YES |
| Assets/Sandbox/Docs/SANDBOX_ACTION_PLAN.md | ?? | YES |
| Assets/Sandbox/Registry/SANDBOX_CRAZY_LOG.csv | ?? | YES |
| Assets/Sandbox/Registry/SANDBOX_CRAZY_LOG.md | ?? | YES |

**ALLOWED_SCOPE_MATCH:** YES  
**PROJECTSETTINGS_CHANGED:** NO  
**MCP_OR_TOKEN_FILES_CHANGED:** NO  
**GENERATED_CACHE_FILES_VISIBLE:** NO (Logs/ exists but .log files not tracked)

## .gitignore Audit

- `Library/` — present (only rule)
- `UserSettings/` — NOT in .gitignore but not in git status
- `.mcp.json` — NOT present in workspace
- `Logs/` — NOT in .gitignore (potential gap; .log files exist but not tracked)

## STAGE_ONLY_LIST

All 26 files above. No other files are staged or tracked.

## BLOCKERS

None.

## NON_BLOCKERS

- `.gitignore` contains only `Library/`. Consider adding `UserSettings/`, `Logs/`, `.mcp.json` for defense-in-depth. Not blocking.

## RECOMMENDED_COMMIT_SUBJECT

`feat: scaffold AI_WORKFLOW and sandbox registry`

## DO_NOT_DO_CONFIRMED

- no Stage All recommended: YES
- no git add . recommended: YES
- no push approval claimed: YES
