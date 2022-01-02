I am very lazy.
I update it when I want to.

# BroadcastPlugin
SCP : Secret Laboratory Plugin that show messages when Something happens.

# How to use
**Step 1:** Download **BroadcastPlugin.dll** from [here](https://github.com/terracorra/BroadcastPlugin/releases/latest)

**Step 2:** Place into your plugins folder.

**Step 3:** Configure it.

**Step 4:** **Ta-da!**

# About
Requires **EXILED** 4.1.0+.

**3.1.0** is the latest release version.
# Default Config
```yaml
BC:
  is_enabled: true
  chaos_entrance:
  - duration: 10
    message: Chaos Insurgency has entered the facility.
    only_for_cdp_and_chi: true
  ntf_entrance:
  - duration: 8
    message: >-
      MTF {UnitName}-{UnitNumber} has entered the facility

      Remaining SCPs : {ScpCount}
    message_noscp: >-
      MTF {UnitName}-{UnitNumber} has entered the facility

      No SCPs left.
  scp_contained:
  - duration: 10
    cdp: '{ScpName} contained successfully. Containment unit : Class-D Personnel'
    cdp_microhid: '{ScpName} contained successfully. Containment unit : Micro H.I.D. ( Class-D Personnel )'
    rsc: '{ScpName} contained successfully. Containment unit : Science Personnel'
    rsc_microhid: '{ScpName} contained successfully. Containment unit : Micro H.I.D. ( Science Personnel )'
    mtf: '{ScpName} contained successfully. Containment unit : {UnitName}'
    mtf_microhid: '{ScpName} contained successfully. Containment unit : Micro H.I.D. ( {UnitName} )'
    chi: '{ScpName} contained successfully. Containment unit : Chaos Insurgency'
    chi_microhid: '{ScpName} contained successfully. Containment unit : Micro H.I.D. ( Chaos Insurgency )'
    tesla: '{ScpName} terminated by Tesla Gate.'
    nuke: '{ScpName} terminated by Alpha Warhead.'
    decon: '{ScpName} lost in Decontamination Sequence.'
    unknown: '{ScpName} contained successfully. Containment unit : Unknown'
    scp079: '{ScpName} contained successfully.'
  warhead:
  - duration: 10
    start: >-
      Alpha Warhead Detonation engaged.

      The underground section in the facility will be detonated in {WarheadTime} seconds
    stop: >-
      Alpha Warhead Detonation canceled.

      Restarting systems.
  decon:
  - duration: 10
    msg_15m: Light Containment Zone overall decontamination in T-minus 15 minutes.
    msg_10m: Light Containment Zone overall decontamination in T-minus 10 minutes.
    msg_5m: Light Containment Zone overall decontamination in T-minus 5 minutes.
    msg_1m: Light Containment Zone overall decontamination in T-minus 1 minutes.
    msg_30s: Light Containment Zone overall decontamination in T-minus 30 seconds
    msg_locked_down: >-
      Light Containment Zone is locked down and ready for decontamination.

      The removal of organic substances has now begun.
    only_for_lcz: false
  gen:
  - duration: 10
    gen1: 1 out of 3 generators activated.
    gen2: 2 out of 3 generators activated.
    gen3: 3 out of 3 generators activated.
  player_join:
  - duration: 5
    message: >-
      Welcome {Player}!

      {PlayersCount} are playing in this server

      Round Duration: {RoundDurationMinutes} m {RoundDurationSeconds} s
  escaped:
  - duration: 7
    cdp_as_chi: Class D personnel escaped as Chaos Insurgency.
    cdp_as_mtf: Class D personnel escaped as Mobile Task Force.
    rsc_as_chi: Science personnel escaped as Chaos Insurgency.
    rsc_as_mtf: Science personnel escaped as Mobile Task Force.
  scp079:
  - duration: 8
    gen: <i><size=22>Some Generator has been enabled...</size></i>
    tier2: SCP-079 reached Tier 2.
    tier3: SCP-079 reached Tier 3.
    tier4: SCP-079 reached Tier 4.
    tier5: SCP-079 reached Tier 5.
    only_for_scp: true
  translations:
  - scp049: SCP-049
    scp079: SCP-079
    scp096: SCP-096
    scp106: SCP-106
    scp173: SCP-173
    scp93953: SCP-939-53
    scp93989: SCP-939-89
```
*You can use: **{ScpName}** (When SCP's death) , **{UnitName}**, **{UnitNumber}**, **{WarheadTime}** **{Player}**, **{PlayersCount}**, **{RoundDurationMinutes}** and **{RoundDurationSeconds}***

# Contact
If you found a bug or need help,
Feel free to contact me.

Bug reoprts are very helpful to improve.


**Discord**: **Polaris**#2314
