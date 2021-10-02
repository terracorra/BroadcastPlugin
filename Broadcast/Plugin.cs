using events = Exiled.Events.Handlers;
using Exiled.API.Enums;
using Exiled.Events.EventArgs;
using Exiled.API.Features;
using System;
using System.Collections.Generic;


namespace BroadcastPlugin
{
	public class Plugin : Exiled.API.Features.Plugin<Config>
	{
		public override string Author { get; } = "Polaris";
		public override string Name { get; } = "BroadcastPlugin";
		public override string Prefix { get; } = "BC";
		public override Version Version { get; } = new Version(1, 2);
		public override Version RequiredExiledVersion { get; } = new Version(2, 14, 0);

		public override PluginPriority Priority { get; } = PluginPriority.Default;

		public override void OnEnabled()
		{
			try
            {
				base.OnEnabled();
				events.Server.RespawningTeam += OnRespawningTeam;
				events.Player.Died += OnDied;
				events.Scp079.Recontained += On079Recontained;
				events.Map.AnnouncingNtfEntrance += OnAnnouncingNtfEntrance;
				events.Map.AnnouncingDecontamination += OnAnnouncingDecontamination;
				events.Map.Decontaminating += OnDecontaminating;
				events.Map.GeneratorActivated += OnGeneratorActivated;
				events.Warhead.Starting += OnWarheadStarting;
				events.Warhead.Stopping += OnWarheadStopping;

				Log.Info($"Loaded Complete.");
			}
			catch (Exception er)
            {
				Log.Error($"Error occured : {er}");
            }
		}
		public override void OnDisabled()
		{
			base.OnDisabled();
			events.Server.RespawningTeam += OnRespawningTeam;
			events.Player.Died += OnDied;
			events.Scp079.Recontained += On079Recontained;
			events.Map.AnnouncingNtfEntrance += OnAnnouncingNtfEntrance;
			events.Map.AnnouncingDecontamination += OnAnnouncingDecontamination;
			events.Map.Decontaminating += OnDecontaminating;
			events.Map.GeneratorActivated += OnGeneratorActivated;
			events.Warhead.Starting += OnWarheadStarting;
			events.Warhead.Stopping += OnWarheadStopping;
		}

        public void OnDied(DiedEventArgs ev)
        {
            if (ev.Target.Role == RoleType.Scp049)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Config.Translation_Scp049).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByCdp.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByRsc.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMtf.Replace("{ScpName}", Config.Translation_Scp049).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByChi.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByNuke.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByDecon.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContaindedByTesla.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByUnknown.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                }
            }
            else if (ev.Target.Role == RoleType.Scp096)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Config.Translation_Scp049).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Config.Translation_Scp049), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByCdp.Replace("{ScpName}", Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByRsc.Replace("{ScpName}", Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMtf.Replace("{ScpName}", Config.Translation_Scp096).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByChi.Replace("{ScpName}", Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByNuke.Replace("{ScpName}", Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByDecon.Replace("{ScpName}", Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContaindedByTesla.Replace("{ScpName}", Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByUnknown.Replace("{ScpName}", Config.Translation_Scp096), Broadcast.BroadcastFlags.Normal, false);
                }
            }
            else if (ev.Target.Role == RoleType.Scp106)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Config.Translation_Scp106).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByCdp.Replace("{ScpName}", Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByRsc.Replace("{ScpName}", Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMtf.Replace("{ScpName}", Config.Translation_Scp106).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByChi.Replace("{ScpName}", Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByNuke.Replace("{ScpName}", Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByDecon.Replace("{ScpName}", Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContaindedByTesla.Replace("{ScpName}", Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByUnknown.Replace("{ScpName}", Config.Translation_Scp106), Broadcast.BroadcastFlags.Normal, false);
                }
            }
            else if (ev.Target.Role == RoleType.Scp173)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Config.Translation_Scp173).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByCdp.Replace("{ScpName}", Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByRsc.Replace("{ScpName}", Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMtf.Replace("{ScpName}", Config.Translation_Scp173).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByChi.Replace("{ScpName}", Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByNuke.Replace("{ScpName}", Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByDecon.Replace("{ScpName}", Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContaindedByTesla.Replace("{ScpName}", Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByUnknown.Replace("{ScpName}", Config.Translation_Scp173), Broadcast.BroadcastFlags.Normal, false);
                }
            }
            else if (ev.Target.Role == RoleType.Scp93953)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Config.Translation_Scp93953).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByCdp.Replace("{ScpName}", Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByRsc.Replace("{ScpName}", Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMtf.Replace("{ScpName}", Config.Translation_Scp93953).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByChi.Replace("{ScpName}", Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByNuke.Replace("{ScpName}", Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByDecon.Replace("{ScpName}", Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContaindedByTesla.Replace("{ScpName}", Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByUnknown.Replace("{ScpName}", Config.Translation_Scp93953), Broadcast.BroadcastFlags.Normal, false);
                }
            }
            else if (ev.Target.Role == RoleType.Scp93989)
            {
                if (ev.HitInformations.Tool == 18)
                {
                    if (ev.Killer.Role == RoleType.ClassD)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidCdp.Replace("{ScpName}", Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.Scientist)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidRsc.Replace("{ScpName}", Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Team == Team.MTF)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidMtf.Replace("{ScpName}", Config.Translation_Scp93989).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                    }
                    else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                    {
                        Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMicrohidChi.Replace("{ScpName}", Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                    }
                }
                if (ev.Killer.Role == RoleType.ClassD)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByCdp.Replace("{ScpName}", Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.Scientist)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByRsc.Replace("{ScpName}", Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Team == Team.MTF)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByMtf.Replace("{ScpName}", Config.Translation_Scp93989).Replace("{UnitName}", ev.Killer.UnitName), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.Killer.Role == RoleType.ChaosInsurgency)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByChi.Replace("{ScpName}", Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 2)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByNuke.Replace("{ScpName}", Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 4)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByDecon.Replace("{ScpName}", Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else if (ev.HitInformations.Tool == 5)
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContaindedByTesla.Replace("{ScpName}", Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
                else
                {
                    Map.Broadcast(Config.ScpContainedDuration, Config.ScpContainedByUnknown.Replace("{ScpName}", Config.Translation_Scp93989), Broadcast.BroadcastFlags.Normal, false);
                }
            }
        }
        public void On079Recontained(RecontainedEventArgs ev)
        {
            Map.Broadcast(Config.ScpContainedDuration, Config.Scp079Recontained, Broadcast.BroadcastFlags.Normal, false);
        }
        public void OnAnnouncingNtfEntrance(AnnouncingNtfEntranceEventArgs ev)
        {
            if (ev.ScpsLeft >= 0)
            {
                Map.Broadcast(Config.NtfEntranceDuration, Config.NtfEntrance.Replace("{UnitName}", ev.UnitName).Replace("{UnitNumber}", $"{ev.UnitNumber}").Replace("{ScpCount}", $"{ev.ScpsLeft}"), Broadcast.BroadcastFlags.Normal, false);
            }
            else
            {
                Map.Broadcast(Config.NtfEntranceDuration, Config.NtfEntranceNoScp.Replace("{UnitName}", ev.UnitName).Replace("{UnitNumber}", $"{ev.UnitNumber}"), Broadcast.BroadcastFlags.Normal, false);
            }
        }
        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            if (ev.NextKnownTeam == Respawning.SpawnableTeamType.ChaosInsurgency)
            {
                if (Config.ChaosEntranceOnlyCdpAndChi)
                {
                    foreach (var p in Player.List)
                    {
                        if (p.Team == Team.CDP || p.Team == Team.CHI)
                        {
                            p.Broadcast(Config.ChaosEntranceDuration, Config.ChaosEntrance, Broadcast.BroadcastFlags.Normal, false);
                        }
                    }
                }
                else
                {
                    Map.Broadcast(Config.ChaosEntranceDuration, Config.ChaosEntrance, Broadcast.BroadcastFlags.Normal, false);
                }
            }
        }
        public void OnAnnouncingDecontamination(AnnouncingDecontaminationEventArgs ev)
        {
            switch (ev.Id)
            {
                case 0:
                    {
                        Map.Broadcast(Config.DeconDuration, Config.Decon15m, Broadcast.BroadcastFlags.Normal, false);
                        break;
                    }
                case 1:
                    {
                        Map.Broadcast(Config.DeconDuration, Config.Decon10m, Broadcast.BroadcastFlags.Normal, false);
                        break;
                    }
                case 2:
                    {
                        Map.Broadcast(Config.DeconDuration, Config.Decon5m, Broadcast.BroadcastFlags.Normal, false);
                        break;
                    }
                case 3:
                    {
                        Map.Broadcast(Config.DeconDuration, Config.Decon1m, Broadcast.BroadcastFlags.Normal, false);
                        break;
                    }
                case 4:
                    {
                        Map.Broadcast(Config.DeconDuration, Config.Decon30s, Broadcast.BroadcastFlags.Normal, false);
                        break;
                    }
            }
        }
        public void OnDecontaminating(DecontaminatingEventArgs ev)
        {
            Map.Broadcast(Config.DeconDuration, Config.DeconLockedDown, Broadcast.BroadcastFlags.Normal, false);
        }
        public void OnGeneratorActivated(GeneratorActivatedEventArgs ev)
        {
            if (Generator079.mainGenerator.forcedOvercharge)
                return;

            int gencount = Generator079.mainGenerator.NetworktotalVoltage += 1;
            if (gencount == 1)
            {
                Map.Broadcast(Config.GeneratorDuration, Config.Generator1, Broadcast.BroadcastFlags.Normal, false);
            }
            else if (gencount == 2)
            {
                Map.Broadcast(Config.GeneratorDuration, Config.Generator2, Broadcast.BroadcastFlags.Normal, false);
            }
            else if (gencount == 3)
            {
                Map.Broadcast(Config.GeneratorDuration, Config.Generator3, Broadcast.BroadcastFlags.Normal, false);
            }
            else if (gencount == 4)
            {
                Map.Broadcast(Config.GeneratorDuration, Config.Generator4, Broadcast.BroadcastFlags.Normal, false);
            }
            else if (gencount == 5)
            {
                Map.Broadcast(Config.GeneratorDuration, Config.Generator5, Broadcast.BroadcastFlags.Normal, false);
            }
        }
        public void OnWarheadStarting(StartingEventArgs ev)
        {
            Map.Broadcast(Config.WarheadDuration, Config.WarheadStart.Replace("{WarheadTime}", $"{Warhead.DetonationTimer}"), Broadcast.BroadcastFlags.Normal, false);
        }
        public void OnWarheadStopping(StoppingEventArgs ev)
        {
            Map.Broadcast(Config.WarheadDuration, Config.WarheadStop, Broadcast.BroadcastFlags.Normal, false);
        }
    }
}
