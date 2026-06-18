# BATCH_05.md — S05 Network / API Experiments

**Theme:** Multiplayer, REST API calls, WebSockets, cloud save, online leaderboards.  
**Risk level:** HIGH  
**VALIDATE_FIRST required:** YES — do not start any experiment in this batch until BLK-002 is resolved.

## VALIDATE_FIRST checklist (must complete before any S05 work)
- [ ] Igor identifies the specific network/API target.
- [ ] Required packages listed and approved in DECISIONS.md.
- [ ] API endpoints and authentication methods documented and approved.
- [ ] Network traffic scope assessed (no accidental telemetry or credential leaks).
- [ ] BLK-002 in BLOCKERS.md marked RESOLVED.

## Experiments in this batch

### S05_001 | (open slot) | Status: VALIDATE_FIRST
_(Do not define until VALIDATE_FIRST is complete.)_

### S05_002 | (open slot) | Status: VALIDATE_FIRST
### S05_003 | (open slot) | Status: VALIDATE_FIRST

## Notes
- Unity Gaming Services (Relay, Lobby) packages require Igor approval.
- No hardcoded API keys or tokens anywhere in Assets/.
- All network experiment scenes must have an offline fallback or graceful failure mode.
