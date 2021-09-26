using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using UnityEngine;

namespace BroadcastPlugin
{
    public class EventHandlers
    {
        public void OnDied(DiedEventArgs ev)
        {
            if (ev.Target.Role == RoleType.Scp049)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByNuke.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByDecon.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContaindeByTesla.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByUnknown.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
            }
            else if (ev.Target.Role == RoleType.Scp096)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByNuke.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByDecon.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContaindeByTesla.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByUnknown.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
            }
            else if (ev.Target.Role == RoleType.Scp106)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByNuke.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByDecon.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContaindeByTesla.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByUnknown.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
            }
            else if (ev.Target.Role == RoleType.Scp173)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByNuke.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByDecon.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContaindeByTesla.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByUnknown.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
            }
            else if (ev.Target.Role == RoleType.Scp93953)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByNuke.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByDecon.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContaindeByTesla.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByUnknown.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
            }
            else if (ev.Target.Role == RoleType.Scp93989)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByCdp.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByRsc.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByMtf.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByChi.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByNuke.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByDecon.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContaindeByTesla.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.ScpContainedByUnknown.Replace("{ScpName}", Plugin.Instance.Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
            }
        }
        public void On079Recontained(RecontainedEventArgs ev)
        {
            Map.Broadcast(Plugin.Instance.Config.ScpContainedDuration, Plugin.Instance.Config.Scp079Recontained, Broadcast.BroadcastFlags.Normal, false);
        }
        public void OnAnnouncingNtfEntrance(AnnouncingNtfEntranceEventArgs ev)
        {
            if (ev.ScpsLeft >= 0)
            {
                Map.Broadcast(Plugin.Instance.Config.NtfEntranceDuration, Plugin.Instance.Config.NtfEntrance.Replace("{UnitName}", ev.UnitName).Replace("{UnitNumber}", $"{ev.UnitNumber}").Replace("{ScpCount}", $"{ev.ScpsLeft}"), Broadcast.BroadcastFlags.Normal, false);
            }
            else
            {
                Map.Broadcast(Plugin.Instance.Config.NtfEntranceDuration, Plugin.Instance.Config.NtfEntranceNoScp.Replace("{UnitName}", ev.UnitName).Replace("{UnitNumber}", $"{ev.UnitNumber}"), Broadcast.BroadcastFlags.Normal, false);
            }
        }
        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            if (ev.NextKnownTeam == Respawning.SpawnableTeamType.ChaosInsurgency)
            {
                if (Plugin.Instance.Config.ChaosEntranceOnlyCdpAndChi)
                {
                    foreach (var p in Player.List)
                    {
                        if (p.Team == Team.CDP || p.Team == Team.CHI)
                        {
                            p.Broadcast(Plugin.Instance.Config.ChaosEntranceDuration, Plugin.Instance.Config.ChaosEntrance, Broadcast.BroadcastFlags.Normal, false);
                        }
                    }
                }
                else
                {
                    Map.Broadcast(Plugin.Instance.Config.ChaosEntranceDuration, Plugin.Instance.Config.ChaosEntrance, Broadcast.BroadcastFlags.Normal, false);
                }
            }
        }
        public void OnAnnouncingDecontamination(AnnouncingDecontaminationEventArgs ev)
        {
            switch (ev.Id)
            {
                case 0:
                    {
                        Map.Broadcast(Plugin.Instance.Config.DeconDuration, Plugin.Instance.Config.Decon15m, Broadcast.BroadcastFlags.Normal, false);
                        break;
                    }
                case 1:
                    {
                        Map.Broadcast(Plugin.Instance.Config.DeconDuration, Plugin.Instance.Config.Decon10m, Broadcast.BroadcastFlags.Normal, false);
                        break;
                    }
                case 2:
                    {
                        Map.Broadcast(Plugin.Instance.Config.DeconDuration, Plugin.Instance.Config.Decon5m, Broadcast.BroadcastFlags.Normal, false);
                        break;
                    }
                case 3:
                    {
                        Map.Broadcast(Plugin.Instance.Config.DeconDuration, Plugin.Instance.Config.Decon1m, Broadcast.BroadcastFlags.Normal, false);
                        break;
                    }
                case 4:
                    {
                        Map.Broadcast(Plugin.Instance.Config.DeconDuration, Plugin.Instance.Config.Decon30s, Broadcast.BroadcastFlags.Normal, false);
                        break;
                    }
            }
        }
        public void OnDecontaminating(DecontaminatingEventArgs ev)
        {
            Map.Broadcast(Plugin.Instance.Config.DeconDuration, Plugin.Instance.Config.DeconLockedDown, Broadcast.BroadcastFlags.Normal, false);
        }
        public void OnGeneratorActivated(GeneratorActivatedEventArgs ev)
        {
            if (Generator079.mainGenerator.forcedOvercharge) 
                return;

            int gencount = Generator079.mainGenerator.NetworktotalVoltage += 1;
            if (gencount == 1)
            {
                Map.Broadcast(Plugin.Instance.Config.GeneratorDuration, Plugin.Instance.Config.Generator1, Broadcast.BroadcastFlags.Normal, false);
            }
            else if (gencount == 2)
            {
                Map.Broadcast(Plugin.Instance.Config.GeneratorDuration, Plugin.Instance.Config.Generator2, Broadcast.BroadcastFlags.Normal, false);
            }
            else if (gencount == 3)
            {
                Map.Broadcast(Plugin.Instance.Config.GeneratorDuration, Plugin.Instance.Config.Generator3, Broadcast.BroadcastFlags.Normal, false);
            }
            else if (gencount == 4)
            {
                Map.Broadcast(Plugin.Instance.Config.GeneratorDuration, Plugin.Instance.Config.Generator4, Broadcast.BroadcastFlags.Normal, false);
            }
            else if (gencount == 5)
            {
                Map.Broadcast(Plugin.Instance.Config.GeneratorDuration, Plugin.Instance.Config.Generator5, Broadcast.BroadcastFlags.Normal, false);
            }
        }
        public void OnWarheadStarting(StartingEventArgs ev)
        {
            Map.Broadcast(Plugin.Instance.Config.WarheadDuration, Plugin.Instance.Config.WarheadStart.Replace("{WarheadTime}", $"Warhead.DetonationTimer"), Broadcast.BroadcastFlags.Normal, false);
        }
        public void OnWarheadStopping(StoppingEventArgs ev)
        {
            Map.Broadcast(Plugin.Instance.Config.WarheadDuration, Plugin.Instance.Config.WarheadStop, Broadcast.BroadcastFlags.Normal, false);
        }
    }
}
