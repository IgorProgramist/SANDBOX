# SANDBOX_ACTION_PLAN.md — High-Level Experiment Roadmap

_This file lives in Assets/Sandbox/Docs/ so it travels with the Unity project._  
_Detailed per-experiment specs live in AI_WORKFLOW/BATCHES/._

## Phase 1 — Foundation (current)
- [x] Baseline commit.
- [x] AI_WORKFLOW scaffold.
- [ ] First experiment: S01_001 anti_gravity_zone_3d.

## Phase 2 — S01 Safe Mechanics
Goal: 5 working mechanic demos, each as a standalone prefab + scene.  
No external dependencies. No packages beyond Unity defaults.

## Phase 3 — S02 Procedural Generation
Goal: 3–5 runtime mesh/layout/content generators.  
Milestone: At least one is interesting enough to consider for APP.

## Phase 4 — S03 Creative / Art Tools
Goal: 3–5 HDRP/Shader Graph/VFX experiments.  
Milestone: At least one shader effect Igor actually likes.

## Phase 5 — S04 AI / Blender (VALIDATE_FIRST)
Blocked until BLK-001 resolved. Do not plan details before that.

## Phase 6 — S05 Network / API (VALIDATE_FIRST)
Blocked until BLK-002 resolved. Do not plan details before that.

## Promotion gate (any experiment → APP)
1. Experiment is DONE status.
2. Prefab card written (name, purpose, dependencies, known issues).
3. Clear/Unity review pass completed (no broken API calls, no hardcoded paths).
4. Igor explicitly approves promotion.
5. Experiment copied to APP with its own commit, not just moved.
