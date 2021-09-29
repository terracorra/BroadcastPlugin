using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Extensions;
using System.Collections.Generic;
using events = Exiled.Events.Handlers;
using System;

namespace BroadcastPlugin
{
	public class Plugin : Plugin<Config>
	{
		private EventHandlers EventHandlers;
		public static Plugin Instance { get; } = new Plugin();
		public override void OnEnabled()
		{
			base.OnEnabled();
			EventHandlers = new EventHandlers();
			events.Server.RespawningTeam += EventHandlers.OnRespawningTeam;
			events.Player.Died += EventHandlers.OnDied;
			events.Scp079.Recontained += EventHandlers.On079Recontained;
			events.Map.AnnouncingNtfEntrance += EventHandlers.OnAnnouncingNtfEntrance;
			events.Map.AnnouncingDecontamination += EventHandlers.OnAnnouncingDecontamination;
			events.Map.Decontaminating += EventHandlers.OnDecontaminating;
			events.Map.GeneratorActivated += EventHandlers.OnGeneratorActivated;
			events.Warhead.Starting += EventHandlers.OnWarheadStarting;
			events.Warhead.Stopping += EventHandlers.OnWarheadStopping;

			Log.Info($"Loaded Complete.");



		}

		public override void OnDisabled()
		{
			base.OnDisabled();
			events.Server.RespawningTeam += EventHandlers.OnRespawningTeam;
			events.Player.Died += EventHandlers.OnDied;
			events.Scp079.Recontained += EventHandlers.On079Recontained;
			events.Map.AnnouncingNtfEntrance += EventHandlers.OnAnnouncingNtfEntrance;
			events.Map.AnnouncingDecontamination += EventHandlers.OnAnnouncingDecontamination;
			events.Map.Decontaminating += EventHandlers.OnDecontaminating;
			events.Map.GeneratorActivated += EventHandlers.OnGeneratorActivated;
			events.Warhead.Starting += EventHandlers.OnWarheadStarting;
			events.Warhead.Stopping += EventHandlers.OnWarheadStopping;
			EventHandlers = null;
		}
	}
}
