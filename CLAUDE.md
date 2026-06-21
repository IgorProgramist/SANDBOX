# CLAUDE.md — Sandbox
# Location: project root (Sandbox/CLAUDE.md)

## THIS PROJECT
**Purpose:** HDRP R&D lab for runtime experiments (physics zones, effects, mechanics).
**Unity:** 6000.3.9f1 · HDRP 17.3.0 · disposable sandbox (not production)
**Phase:** Runtime experiments — runtime LOCKED until explicit gate (D5)

---

## THE 4 RULES (Karpathy — always active)

### 1. THINK BEFORE CODING
State assumptions before implementing. If unclear → ask, do not guess.
Multiple interpretations → present them, do not pick silently.

### 2. SIMPLICITY FIRST
Minimum code that solves the task. No speculative features.
No abstractions for single use.

### 3. SURGICAL CHANGES
Touch ONLY files in FILES_ALLOWED. No adjacent improvements.
No "while I'm here." Every changed line must trace to the request.

### 4. GOAL-DRIVEN EXECUTION
State a plan before coding. Loop until done or report why blocked.
Never claim "done" without verification.

---

## PROJECT STACK
- Unity 6000.3.9f1 · HDRP 17.3.0 · C#
- Runtime scripts: `Assets/Sandbox/Runtime/`
- Namespace: `Sandbox.Runtime`
- HDRP shader skill: unity-hdrp-shader-helper (this is an HDRP lane)

## HARD LOCKS (Sandbox-specific)
- **Runtime is LOCKED by default (D5)** — no runtime .cs writes until explicit APPROVE_SANDBOX_RUNTIME
- Docs/planning phase allowed; runtime implementation gated
- HDRP API: VALIDATE_FIRST vs Unity 6 HDRP package docs
- No git push, no package install, no ProjectSettings edits
- TryGetComponent (not GetComponent), Gizmos for debug
- ~400 mini-projects = CSV registry in SANDBOX, NOT 400 separate scenes/chats

## FILES_ALLOWED (default — docs only until runtime gate)
```
Assets/Sandbox/Docs/
Assets/Sandbox/Registry/   (CSV mini-project registry)
```
After APPROVE_SANDBOX_RUNTIME:
```
Assets/Sandbox/Runtime/
```

## PIPELINE NOTE
Sandbox = HDRP. Use unity-hdrp-shader-helper (not the URP twin).
URP lanes (APP/MCP) use unity-urp-shader-helper instead.
