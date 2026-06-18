# BLOCKERS.md — Active Blockers

## Format
```
### BLK-### | YYYY-MM-DD | <title>
**Status:** ACTIVE / RESOLVED
**Blocks:** <experiment ID or area>
**Description:** ...
**Unblock condition:** ...
**Resolved:** YYYY-MM-DD (if resolved)
```

---

### BLK-001 | 2026-06-18 | S04 AI/Blender experiments — VALIDATE_FIRST pending
**Status:** ACTIVE  
**Blocks:** BATCH_04 (all S04 experiments)  
**Description:** S04 involves AI inference or Blender pipeline integration which may require external APIs or packages not yet approved.  
**Unblock condition:** Igor explicitly reviews the S04 experiment spec, approves packages, and records approval in DECISIONS.md.

### BLK-002 | 2026-06-18 | S05 Network/API experiments — VALIDATE_FIRST pending
**Status:** ACTIVE  
**Blocks:** BATCH_05 (all S05 experiments)  
**Description:** S05 involves network calls or external API integrations.  
**Unblock condition:** Igor explicitly reviews the S05 experiment spec, approves APIs, and records approval in DECISIONS.md.
