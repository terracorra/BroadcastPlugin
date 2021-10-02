# BroadcastPlugin
SCP : Secret Laboratory Plugin the show messages when Something happens.

# How to use
**Step 1:** Download **BroadcastPlugin.dll** from [here](https://github.com/terracorra/BroadcastPlugin/releases/latest)

**Step 2:** Place into your plugins folder.

**Step 3:** Configure it.

**Step 4:** **Ta-da!**


# Default Config
```
broadcast_plugin:
  is_enabled: true
  chaos_entrance: Chaos Insurgency has entered the facility.
  chaos_entrance_duration: 10
  chaos_entrance_only_cdp_and_chi: true
  ntf_entrance: >-
    MTF {UnitName}-{UnitNumber} has entered the facility

    Remaining SCPs : {ScpCount}
  ntf_entrance_no_scp: >-
    MTF {UnitName}-{UnitNumber} has entered the facility

    No SCPs left.
  ntf_entrance_duration: 10
  scp_contained_duration: 10
  scp_contained_by_cdp: '{ScpName} contained successfully. Containment unit : Class-D Personnel'
  scp_contained_by_rsc: '{ScpName} contained successfully. Containment unit : Science Personnel'
  scp_contained_by_mtf: '{ScpName} contained successfully. Containment unit : {UnitName}'
  scp_contained_by_chi: '{ScpName} contained successfully. Containment unit : Chaos Insurgency'
  scp_containded_by_tesla: '{ScpName} terminated by Tesla gate'
  scp_contained_by_nuke: '{ScpName} terminated by Alpha Warhead'
  scp_contained_by_decon: '{ScpName} lost in Decontamination Sequence.'
  scp_contained_by_microhid_cdp: '{ScpName} contained successfully. Containment unit : Micro H.I.D ( Class-D Personnel )'
  scp_contained_by_microhid_rsc: '{ScpName} contained successfully. Containment unit : Micro H.I.D ( Science Personnel )'
  scp_contained_by_microhid_mtf: '{ScpName} contained successfully. Containment unit : Micro H.I.D ( {UnitName} )'
  scp_contained_by_microhid_chi: '{ScpName} contained successfully. Containment unit : Micro H.I.D ( Chaos Insurgency )'
  scp_contained_by_unknown: '{ScpName} 이(가) 격리되었습니다.'
  scp079_recontained: '{ScpName} contained successfully.'
  warhead_duration: 10
  warhead_start: >-
    Alpha Warhead Detonation engaged.

    The underground section in the facility will be detonated in {WarheadTime} seconds
  warhead_stop: >-
    Alpha Warhead Detonation canceled.

    Restarting systems.
  decon_duration: 10
  decon15m: Light Containment Zone overall decontamination in T-minus 15 minutes.
  decon10m: Light Containment Zone overall decontamination in T-minus 10 minutes.
  decon5m: Light Containment Zone overall decontamination in T-minus 5 minutes.
  decon1m: Light Containment Zone overall decontamination in T-minus 1 minutes.
  decon30s: Light Containment Zone overall decontamination in T-minus 30 seconds.
  decon_locked_down: >-
    Light Containment Zone is locked down and ready for decontamination.

    The removal of organic substances has now begun.
  generator_duration: 8
  generator1: 1 out of 5 generators activated.
  generator2: 2 out of 5 generators activated.
  generator3: 3 out of 5 generators activated.
  generator4: 4 out of 5 generators activated.
  generator5: 5 out of 5 generators activated.
  # Translation for {ScpName}
  translation_scp049: SCP-049
  translation_scp079: SCP-079
  translation_scp096: SCP-096
  translation_scp106: SCP-106
  translation_scp173: SCP-173
  translation_scp93953: SCP-939-53
  translation_scp93989: SCP-939-89
```
*You can use: **{ScpName}** (When SCP's death) , **{UnitName}**, **{UnitNumber}**, **{WarheadTime}** (Seconds to detonate)*

# Contact
Feel free to contant me.

**Discord**: **Polaris**#2314
