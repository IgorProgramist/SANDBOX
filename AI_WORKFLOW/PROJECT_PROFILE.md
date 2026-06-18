# PROJECT_PROFILE.md — Sandbox Identity

## Project Name
**Sandbox** (Unity crazy-experiments lab)

## Owner
Igor (Technical Artist / Unity developer)

## Engine & Render Pipeline
- Unity 6
- HDRP
- uGUI / Canvas / RectTransform
- TextMeshProUGUI for all UI text
- C# (.NET)

## Relationship to APP/ToolLab
| Sandbox | APP/ToolLab |
|---------|-------------|
| Experiments, prototypes, crazy ideas | Production tools |
| Failure is expected and fine | Must be stable |
| No promotion without review | Receives promoted experiments |
| No external APIs without VALIDATE_FIRST | External APIs after approval |

## Project Location
`I:\My\UnityProjects\Projects\UnityProjects\Sandbox\`

## Git Branch
`master` (independent repo, not a branch of APP)

## Baseline Commit
Baseline commit completed before AI_WORKFLOW was created.  
See `git log` for exact SHA.

## Naming Conventions
- Experiment IDs: `S##_experiment_name` (e.g. `S01_anti_gravity_zone_3d`)
- Scripts: `PascalCase`
- Files: English only
- Namespaces: `Sandbox.*` (isolated from APP namespaces)

## Batch Categories
| Batch | Theme | Risk |
|-------|-------|------|
| S01 | Safe mechanics | Low |
| S02 | Procedural generation | Low |
| S03 | Creative / art tools | Low |
| S04 | AI / Blender experiments | VALIDATE_FIRST |
| S05 | Network / API experiments | VALIDATE_FIRST |

## What NEVER goes in Sandbox repo
- APP/ToolLab production scripts
- .mcp.json
- ProjectSettings/ edits
- Packages/ edits
- UserSettings/ edits
