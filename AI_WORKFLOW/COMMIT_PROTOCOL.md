# COMMIT_PROTOCOL.md — How to Commit in Sandbox

## What to stage (whitelist)

```
AI_WORKFLOW/**
Assets/Sandbox/**
CLAUDE.md          (only if modified)
AGENTS.md          (only if modified)
```

## What to NEVER stage

```
.gitignore              — do not edit, do not stage
ProjectSettings/**      — never
Packages/**             — never
UserSettings/**         — never
Library/**              — never (gitignored)
Temp/**                 — never (gitignored)
Logs/**                 — never (gitignored)
.mcp.json               — never
*.csproj                — check .gitignore; usually ignored
*.sln                   — check .gitignore; usually ignored
APP/ToolLab files       — never in this repo
```

## Commit message format

```
<type>(<scope>): <short description>

type:  feat | fix | docs | chore | experiment
scope: S01 | S02 | S03 | S04 | S05 | workflow | registry
```

Examples:
```
feat(S01): add anti_gravity_zone_3d experiment scaffold
docs(workflow): update CURRENT_STATE and WORK_LOG
chore(registry): add S01_001 to SANDBOX_CRAZY_LOG
```

## Pre-commit checklist

- [ ] Only whitelisted files are staged (`git status` check).
- [ ] .gitignore is NOT staged.
- [ ] ProjectSettings/ is NOT staged.
- [ ] Packages/ is NOT staged.
- [ ] Commit message follows format above.
- [ ] WORK_LOG.md updated for this session.
- [ ] CURRENT_STATE.md updated if project state changed.
- [ ] REGISTRY_INDEX.md updated if new experiments added.

## Who triggers commits

Igor triggers commits manually after reviewing `git status`.  
Agents do NOT run `git add`, `git commit`, or `git push` unless Igor explicitly asks.
