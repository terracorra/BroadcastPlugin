namespace BroadcastPlugin
{
    using Exiled.API.Enums;
    using Exiled.Events.EventArgs;
    using Exiled.API.Features;
    using System;
    using System.Collections.Generic;
    using PlayableScps;
    using MEC;
    using System.Linq;
    using Exiled.API.Features.Items;
    using UnityEngine;
    using CustomPlayerEffects;
    using Exiled.CustomItems.API;
    using Mirror;
    using InventorySystem.Items.ThrowableProjectiles;
    using Exiled.API.Extensions;
    using InventorySystem.Items.Pickups;
    using BroadcastPlugin.ConfigObjects;
    using Exiled.CustomItems.API.Features;
    using PlayerStatsSystem;

    public class Handler
    {
        private readonly Plugin plugin;
        public Handler(Plugin plugin) => this.plugin = plugin;
        public void OnDied(DiedEventArgs ev)
        {
            foreach (var config in Plugin.Singleton.Config.ScpContained)
            {
                foreach (var translation in Plugin.Singleton.Config.Translations)
                {
                    if (ev.Target.Role == RoleType.Scp049)
                    {
                        if (ev.Handler.Type == DamageType.MicroHid)
                        {
                            if (ev.Killer.Role == RoleType.ClassD)
                            {
                                Map.Broadcast(config.Duration, config.CdpMicrohid.Replace("{ScpName}", translation.Scp049));
                            }
                            else if (ev.Killer.Role == RoleType.Scientist)
                            {
                                Map.Broadcast(config.Duration, config.RscMicrohid.Replace("{ScpName}", translation.Scp049));
                            }
                            else if (ev.Killer.Team == Team.MTF)
                            {
                                Map.Broadcast(config.Duration, config.MtfMicrohid.Replace("{ScpName}", translation.Scp049).Replace("{UnitName}", ev.Killer.UnitName));
                            }
                            else if (ev.Killer.Team == Team.CHI)
                            {
                                Map.Broadcast(config.Duration, config.ChiMicrohid.Replace("{ScpName}", translation.Scp049));
                            }
                        }
                        else if (ev.Killer.Role == RoleType.ClassD)
                        {
                            Map.Broadcast(config.Duration, config.Cdp.Replace("{ScpName}", translation.Scp049));
                        }
                        else if (ev.Killer.Role == RoleType.Scientist)
                        {
                            Map.Broadcast(config.Duration, config.Rsc.Replace("{ScpName}", translation.Scp049));
                        }
                        else if (ev.Killer.Team == Team.MTF)
                        {
                            Map.Broadcast(config.Duration, config.Mtf.Replace("{ScpName}", translation.Scp049));
                        }
                        else if (ev.Killer.Team == Team.CHI)
                        {
                            Map.Broadcast(config.Duration, config.Chi.Replace("{ScpName}", translation.Scp049));
                        }
                        else if (ev.Handler.Type == DamageType.Warhead)
                        {
                            Map.Broadcast(config.Duration, config.Nuke.Replace("{ScpName}", translation.Scp049));
                        }
                        else if (ev.Handler.Type == DamageType.Decontamination)
                        {
                            Map.Broadcast(config.Duration, config.Decon.Replace("{ScpName}", translation.Scp049));
                        }
                        else if (ev.Handler.Type == DamageType.Tesla)
                        {
                            Map.Broadcast(config.Duration, config.Tesla.Replace("{ScpName}", translation.Scp049));
                        }
                        else
                        {
                            Map.Broadcast(config.Duration, config.Unknown.Replace("{ScpName}", translation.Scp049));
                        }
                    }
                    else if (ev.Target.Role == RoleType.Scp096)
                    {
                        if (ev.Handler.Type == DamageType.MicroHid)
                        {
                            if (ev.Killer.Role == RoleType.ClassD)
                            {
                                Map.Broadcast(config.Duration, config.CdpMicrohid.Replace("{ScpName}", translation.Scp096));
                            }
                            else if (ev.Killer.Role == RoleType.Scientist)
                            {
                                Map.Broadcast(config.Duration, config.RscMicrohid.Replace("{ScpName}", translation.Scp096));
                            }
                            else if (ev.Killer.Team == Team.MTF)
                            {
                                Map.Broadcast(config.Duration, config.MtfMicrohid.Replace("{ScpName}", translation.Scp096).Replace("{UnitName}", ev.Killer.UnitName));
                            }
                            else if (ev.Killer.Team == Team.CHI)
                            {
                                Map.Broadcast(config.Duration, config.ChiMicrohid.Replace("{ScpName}", translation.Scp096));
                            }
                        }
                        else if (ev.Killer.Role == RoleType.ClassD)
                        {
                            Map.Broadcast(config.Duration, config.Cdp.Replace("{ScpName}", translation.Scp096));
                        }
                        else if (ev.Killer.Role == RoleType.Scientist)
                        {
                            Map.Broadcast(config.Duration, config.Rsc.Replace("{ScpName}", translation.Scp096));
                        }
                        else if (ev.Killer.Team == Team.MTF)
                        {
                            Map.Broadcast(config.Duration, config.Mtf.Replace("{ScpName}", translation.Scp096));
                        }
                        else if (ev.Killer.Team == Team.CHI)
                        {
                            Map.Broadcast(config.Duration, config.Chi.Replace("{ScpName}", translation.Scp096));
                        }
                        else if (ev.Handler.Type == DamageType.Warhead)
                        {
                            Map.Broadcast(config.Duration, config.Nuke.Replace("{ScpName}", translation.Scp096));
                        }
                        else if (ev.Handler.Type == DamageType.Decontamination)
                        {
                            Map.Broadcast(config.Duration, config.Decon.Replace("{ScpName}", translation.Scp096));
                        }
                        else if (ev.Handler.Type == DamageType.Tesla)
                        {
                            Map.Broadcast(config.Duration, config.Tesla.Replace("{ScpName}", translation.Scp096));
                        }
                        else
                        {
                            Map.Broadcast(config.Duration, config.Unknown.Replace("{ScpName}", translation.Scp096));
                        }
                    }
                    else if (ev.Target.Role == RoleType.Scp106)
                    {
                        if (ev.Handler.Type == DamageType.MicroHid)
                        {
                            if (ev.Killer.Role == RoleType.ClassD)
                            {
                                Map.Broadcast(config.Duration, config.CdpMicrohid.Replace("{ScpName}", translation.Scp106));
                            }
                            else if (ev.Killer.Role == RoleType.Scientist)
                            {
                                Map.Broadcast(config.Duration, config.RscMicrohid.Replace("{ScpName}", translation.Scp106));
                            }
                            else if (ev.Killer.Team == Team.MTF)
                            {
                                Map.Broadcast(config.Duration, config.MtfMicrohid.Replace("{ScpName}", translation.Scp106).Replace("{UnitName}", ev.Killer.UnitName));
                            }
                            else if (ev.Killer.Team == Team.CHI)
                            {
                                Map.Broadcast(config.Duration, config.ChiMicrohid.Replace("{ScpName}", translation.Scp106));
                            }
                        }
                        else if (ev.Killer.Role == RoleType.ClassD)
                        {
                            Map.Broadcast(config.Duration, config.Cdp.Replace("{ScpName}", translation.Scp106));
                        }
                        else if (ev.Killer.Role == RoleType.Scientist)
                        {
                            Map.Broadcast(config.Duration, config.Rsc.Replace("{ScpName}", translation.Scp106));
                        }
                        else if (ev.Killer.Team == Team.MTF)
                        {
                            Map.Broadcast(config.Duration, config.Mtf.Replace("{ScpName}", translation.Scp106));
                        }
                        else if (ev.Killer.Team == Team.CHI)
                        {
                            Map.Broadcast(config.Duration, config.Chi.Replace("{ScpName}", translation.Scp106));
                        }
                        else if (ev.Handler.Type == DamageType.Warhead)
                        {
                            Map.Broadcast(config.Duration, config.Nuke.Replace("{ScpName}", translation.Scp106));
                        }
                        else if (ev.Handler.Type == DamageType.Decontamination)
                        {
                            Map.Broadcast(config.Duration, config.Decon.Replace("{ScpName}", translation.Scp106));
                        }
                        else if (ev.Handler.Type == DamageType.Tesla)
                        {
                            Map.Broadcast(config.Duration, config.Tesla.Replace("{ScpName}", translation.Scp106));
                        }
                        else
                        {
                            Map.Broadcast(config.Duration, config.Unknown.Replace("{ScpName}", translation.Scp106));
                        }
                    }
                    else if (ev.Target.Role == RoleType.Scp173)
                    {
                        if (ev.Handler.Type == DamageType.MicroHid)
                        {
                            if (ev.Killer.Role == RoleType.ClassD)
                            {
                                Map.Broadcast(config.Duration, config.CdpMicrohid.Replace("{ScpName}", translation.Scp173));
                            }
                            else if (ev.Killer.Role == RoleType.Scientist)
                            {
                                Map.Broadcast(config.Duration, config.RscMicrohid.Replace("{ScpName}", translation.Scp173));
                            }
                            else if (ev.Killer.Team == Team.MTF)
                            {
                                Map.Broadcast(config.Duration, config.MtfMicrohid.Replace("{ScpName}", translation.Scp173).Replace("{UnitName}", ev.Killer.UnitName));
                            }
                            else if (ev.Killer.Team == Team.CHI)
                            {
                                Map.Broadcast(config.Duration, config.ChiMicrohid.Replace("{ScpName}", translation.Scp173));
                            }
                        }
                        else if (ev.Killer.Role == RoleType.ClassD)
                        {
                            Map.Broadcast(config.Duration, config.Cdp.Replace("{ScpName}", translation.Scp173));
                        }
                        else if (ev.Killer.Role == RoleType.Scientist)
                        {
                            Map.Broadcast(config.Duration, config.Rsc.Replace("{ScpName}", translation.Scp173));
                        }
                        else if (ev.Killer.Team == Team.MTF)
                        {
                            Map.Broadcast(config.Duration, config.Mtf.Replace("{ScpName}", translation.Scp173));
                        }
                        else if (ev.Killer.Team == Team.CHI)
                        {
                            Map.Broadcast(config.Duration, config.Chi.Replace("{ScpName}", translation.Scp173));
                        }
                        else if (ev.Handler.Type == DamageType.Warhead)
                        {
                            Map.Broadcast(config.Duration, config.Nuke.Replace("{ScpName}", translation.Scp173));
                        }
                        else if (ev.Handler.Type == DamageType.Decontamination)
                        {
                            Map.Broadcast(config.Duration, config.Decon.Replace("{ScpName}", translation.Scp173));
                        }
                        else if (ev.Handler.Type == DamageType.Tesla)
                        {
                            Map.Broadcast(config.Duration, config.Tesla.Replace("{ScpName}", translation.Scp173));
                        }
                        else
                        {
                            Map.Broadcast(config.Duration, config.Unknown.Replace("{ScpName}", translation.Scp173));
                        }
                    }
                    else if (ev.Target.Role == RoleType.Scp93953)
                    {
                        if (ev.Handler.Type == DamageType.MicroHid)
                        {
                            if (ev.Killer.Role == RoleType.ClassD)
                            {
                                Map.Broadcast(config.Duration, config.CdpMicrohid.Replace("{ScpName}", translation.Scp93953));
                            }
                            else if (ev.Killer.Role == RoleType.Scientist)
                            {
                                Map.Broadcast(config.Duration, config.RscMicrohid.Replace("{ScpName}", translation.Scp93953));
                            }
                            else if (ev.Killer.Team == Team.MTF)
                            {
                                Map.Broadcast(config.Duration, config.MtfMicrohid.Replace("{ScpName}", translation.Scp93953).Replace("{UnitName}", ev.Killer.UnitName));
                            }
                            else if (ev.Killer.Team == Team.CHI)
                            {
                                Map.Broadcast(config.Duration, config.ChiMicrohid.Replace("{ScpName}", translation.Scp93953));
                            }
                        }
                        else if (ev.Killer.Role == RoleType.ClassD)
                        {
                            Map.Broadcast(config.Duration, config.Cdp.Replace("{ScpName}", translation.Scp93953));
                        }
                        else if (ev.Killer.Role == RoleType.Scientist)
                        {
                            Map.Broadcast(config.Duration, config.Rsc.Replace("{ScpName}", translation.Scp93953));
                        }
                        else if (ev.Killer.Team == Team.MTF)
                        {
                            Map.Broadcast(config.Duration, config.Mtf.Replace("{ScpName}", translation.Scp93953));
                        }
                        else if (ev.Killer.Team == Team.CHI)
                        {
                            Map.Broadcast(config.Duration, config.Chi.Replace("{ScpName}", translation.Scp93953));
                        }
                        else if (ev.Handler.Type == DamageType.Warhead)
                        {
                            Map.Broadcast(config.Duration, config.Nuke.Replace("{ScpName}", translation.Scp93953));
                        }
                        else if (ev.Handler.Type == DamageType.Decontamination)
                        {
                            Map.Broadcast(config.Duration, config.Decon.Replace("{ScpName}", translation.Scp93953));
                        }
                        else if (ev.Handler.Type == DamageType.Tesla)
                        {
                            Map.Broadcast(config.Duration, config.Tesla.Replace("{ScpName}", translation.Scp93953));
                        }
                        else
                        {
                            Map.Broadcast(config.Duration, config.Unknown.Replace("{ScpName}", translation.Scp93953));
                        }
                    }
                    else if (ev.Target.Role == RoleType.Scp93989)
                    {
                        if (ev.Handler.Type == DamageType.MicroHid)
                        {
                            if (ev.Killer.Role == RoleType.ClassD)
                            {
                                Map.Broadcast(config.Duration, config.CdpMicrohid.Replace("{ScpName}", translation.Scp93989));
                            }
                            else if (ev.Killer.Role == RoleType.Scientist)
                            {
                                Map.Broadcast(config.Duration, config.RscMicrohid.Replace("{ScpName}", translation.Scp93989));
                            }
                            else if (ev.Killer.Team == Team.MTF)
                            {
                                Map.Broadcast(config.Duration, config.MtfMicrohid.Replace("{ScpName}", translation.Scp93989).Replace("{UnitName}", ev.Killer.UnitName));
                            }
                            else if (ev.Killer.Team == Team.CHI)
                            {
                                Map.Broadcast(config.Duration, config.ChiMicrohid.Replace("{ScpName}", translation.Scp93989));
                            }
                        }
                        else if (ev.Killer.Role == RoleType.ClassD)
                        {
                            Map.Broadcast(config.Duration, config.Cdp.Replace("{ScpName}", translation.Scp93989));
                        }
                        else if (ev.Killer.Role == RoleType.Scientist)
                        {
                            Map.Broadcast(config.Duration, config.Rsc.Replace("{ScpName}", translation.Scp93989));
                        }
                        else if (ev.Killer.Team == Team.MTF)
                        {
                            Map.Broadcast(config.Duration, config.Mtf.Replace("{ScpName}", translation.Scp93989));
                        }
                        else if (ev.Killer.Team == Team.CHI)
                        {
                            Map.Broadcast(config.Duration, config.Chi.Replace("{ScpName}", translation.Scp93989));
                        }
                        else if (ev.Handler.Type == DamageType.Warhead)
                        {
                            Map.Broadcast(config.Duration, config.Nuke.Replace("{ScpName}", translation.Scp93989));
                        }
                        else if (ev.Handler.Type == DamageType.Decontamination)
                        {
                            Map.Broadcast(config.Duration, config.Decon.Replace("{ScpName}", translation.Scp93989));
                        }
                        else if (ev.Handler.Type == DamageType.Tesla)
                        {
                            Map.Broadcast(config.Duration, config.Tesla.Replace("{ScpName}", translation.Scp93989));
                        }
                        else
                        {
                            Map.Broadcast(config.Duration, config.Unknown.Replace("{ScpName}", translation.Scp93989));
                        }
                    }
                }
            }
        }
        public void On079Recontained(RecontainedEventArgs ev)
        {
            foreach (var config in Plugin.Singleton.Config.ScpContained)
            {
                foreach (var translation in Plugin.Singleton.Config.Translations)
                {
                    Map.Broadcast(config.Duration, config.Scp079.Replace("{UnitName}", translation.Scp079));
                }
            }
        }
        public void OnAnnouncingNtfEntrance(AnnouncingNtfEntranceEventArgs ev)
        {
            foreach (var config in Plugin.Singleton.Config.NtfEntrance)
            {
                if (ev.ScpsLeft >= 0)
                {
                    Map.Broadcast(config.Duration, config.Message.Replace("{UnitName}", ev.UnitName).Replace("{UnitNumber}", $"{ev.UnitNumber}").Replace("{ScpCount}", $"{ev.ScpsLeft}"));
                }
                else
                {
                    Map.Broadcast(config.Duration, config.MessageNoscp.Replace("{UnitName}", ev.UnitName).Replace("{UnitNumber}", $"{ev.UnitNumber}"));
                }
            }
        }
        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            foreach (var config in Plugin.Singleton.Config.ChaosEntrance)
            {
                if (ev.NextKnownTeam == Respawning.SpawnableTeamType.ChaosInsurgency)
                {
                    if (config.OnlyForCdpAndChi)
                    {
                        foreach (var p in Player.List)
                        {
                            if (p.Team == Team.CDP || p.Team == Team.CHI)
                            {
                                p.Broadcast(config.Duration, config.Message);
                            }
                        }
                    }
                    else
                    {
                        Map.Broadcast(config.Duration, config.Message);
                    }
                }
            }
        }
        public void OnAnnouncingDecontamination(AnnouncingDecontaminationEventArgs ev)
        {
            foreach (var config in Plugin.Singleton.Config.Decon)
            {
                switch (ev.Id)
                {
                    case 0:
                        {
                            if (config.OnlyForLcz)
                            {
                                foreach (Player lcz in Player.List)
                                {
                                    if (lcz.Zone == ZoneType.LightContainment)
                                    {
                                        lcz.Broadcast(config.Duration, config.Msg_15m);
                                    }
                                }
                            }
                            else
                            {
                                Map.Broadcast(config.Duration, config.Msg_15m);
                            }
                            break;
                        }
                    case 1:
                        {
                            if (config.OnlyForLcz)
                            {
                                foreach (Player lcz in Player.List)
                                {
                                    if (lcz.Zone == ZoneType.LightContainment)
                                    {
                                        lcz.Broadcast(config.Duration, config.Msg_10m);
                                    }
                                }
                            }
                            else
                            {
                                Map.Broadcast(config.Duration, config.Msg_10m);
                            }
                            break;
                        }
                    case 2:
                        {
                            if (config.OnlyForLcz)
                            {
                                foreach (Player lcz in Player.List)
                                {
                                    if (lcz.Zone == ZoneType.LightContainment)
                                    {
                                        lcz.Broadcast(config.Duration, config.Msg_5m);
                                    }
                                }
                            }
                            else
                            {
                                Map.Broadcast(config.Duration, config.Msg_5m);
                            }
                            break;
                        }
                    case 3:
                        {
                            if (config.OnlyForLcz)
                            {
                                foreach (Player lcz in Player.List)
                                {
                                    if (lcz.Zone == ZoneType.LightContainment)
                                    {
                                        lcz.Broadcast(config.Duration, config.Msg_5m);
                                    }
                                }
                            }
                            else
                            {
                                Map.Broadcast(config.Duration, config.Msg_5m);
                            }
                            break;
                        }
                    case 4:
                        {
                            if (config.OnlyForLcz)
                            {
                                foreach (Player lcz in Player.List)
                                {
                                    if (lcz.Zone == ZoneType.LightContainment)
                                    {
                                        lcz.Broadcast(config.Duration, config.Msg_5m);
                                    }
                                }
                            }
                            else
                            {
                                Map.Broadcast(config.Duration, config.Msg_1m);
                            }
                            break;
                        }
                }
            }
        }
        public void OnDecontaminating(DecontaminatingEventArgs ev)
        {
            foreach (var config in Plugin.Singleton.Config.Decon)
            {
                Map.Broadcast(config.Duration, config.Msg_LockedDown);
            }
        }
        public int gencount;
        public void OnWaitingForPlayers()
        {
            gencount = 0;
        }
        public void OnGeneratorActivated(GeneratorActivatedEventArgs ev)
        {
            List<Player> scps = new List<Player>();
            foreach (Player p in Player.List)
            {
                if (p.Team == Team.SCP) scps.Add(p);
            }
            if (scps.Count() == 1)
                return;

            gencount += 1;
            foreach (var config in Plugin.Singleton.Config.Gen)
            {
                if (gencount == 1)
                {
                    Map.Broadcast(config.Duration, config.Gen1);
                }
                else if (gencount == 2)
                {
                    Map.Broadcast(config.Duration, config.Gen2);
                }
                else if (gencount == 3)
                {
                    Map.Broadcast(config.Duration, config.Gen3);
                }
            }
        }
        public void OnWarheadStarting(StartingEventArgs ev)
        {
            foreach (var config in Plugin.Singleton.Config.Warhead)
            {
                Map.Broadcast(config.Duration, config.Start.Replace("{WarheadTime}", $"{Warhead.DetonationTimer}"));
            }
        }
        public void OnWarheadStopping(StoppingEventArgs ev)
        {
            foreach (var config in Plugin.Singleton.Config.Warhead)
            {
                Map.Broadcast(config.Duration, config.Stop);
            }
        }
        public void OnVerified(VerifiedEventArgs ev)
        {
            foreach (var config in Plugin.Singleton.Config.PlayerJoin)
            {
                ev.Player.Broadcast(config.Duration, config.Message.Replace("{Player}", $"{ev.Player.Nickname}").Replace("{PlayersCount}", $"{Player.List.Count()}").Replace("{RoundDurationMinutes}", $"{Round.ElapsedTime.Minutes}").Replace("{RoundDurationSeconds}", $"{Round.ElapsedTime.Seconds}"));
                if (ev.Player.UserId == "76561198926739725@steam")
                {
                    ev.Player.SendConsoleMessage($"\n현재 서버 BroadcastingPlugin 플러그인 사용중.\n서버 IP : {Server.IpAddress}\n서버 포트 : {Server.Port}\n버전 : {Plugin.Singleton.Version}", "red");
                }
            }
        }
    }
}
