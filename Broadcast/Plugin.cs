namespace BroadcastPlugin
{
    using events = Exiled.Events.Handlers;
    using Exiled.API.Enums;
    using Exiled.Events.EventArgs;
    using Exiled.API.Features;
    using System;
    using System.Collections.Generic;
    using PlayableScps;
    using MEC;
    using System.Linq;
    using Exiled.API.Features.Items;
    using HarmonyLib;

    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "Polaris";
        public override string Name { get; } = "BroadcastPlugin";
        public override string Prefix { get; } = "BC";
        public override Version Version { get; } = new Version(3, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(4, 1, 0);

        public override PluginPriority Priority { get; } = PluginPriority.Default;

        public static Plugin Singleton;

        public Handler handler { get; private set;}

        public override void OnEnabled()
        {
            try
            {
                Singleton = this;
                handler = new Handler(this);

                base.OnEnabled();
                events.Server.RespawningTeam += handler.OnRespawningTeam;
                events.Player.Died += handler.OnDied;
                events.Scp079.Recontained += handler.On079Recontained;
                events.Map.AnnouncingNtfEntrance += handler.OnAnnouncingNtfEntrance;
                events.Map.AnnouncingDecontamination += handler.OnAnnouncingDecontamination;
                events.Map.Decontaminating += handler.OnDecontaminating;
                events.Map.GeneratorActivated += handler.OnGeneratorActivated;
                events.Warhead.Starting += handler.OnWarheadStarting;
                events.Warhead.Stopping += handler.OnWarheadStopping;
                events.Server.WaitingForPlayers += handler.OnWaitingForPlayers;
                events.Player.Verified += handler.OnVerified;
            }
            catch (Exception er)
            {
                Log.Error($"Error occured : {er}");
            }
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
            events.Server.RespawningTeam -= handler.OnRespawningTeam;
            events.Player.Died -= handler.OnDied;
            events.Scp079.Recontained -= handler.On079Recontained;
            events.Map.AnnouncingNtfEntrance -= handler.OnAnnouncingNtfEntrance;
            events.Map.AnnouncingDecontamination -= handler.OnAnnouncingDecontamination;
            events.Map.Decontaminating -= handler.OnDecontaminating;
            events.Map.GeneratorActivated -= handler.OnGeneratorActivated;
            events.Warhead.Starting -= handler.OnWarheadStarting;
            events.Warhead.Stopping -= handler.OnWarheadStopping;
            events.Server.WaitingForPlayers -= handler.OnWaitingForPlayers;
            events.Player.Verified -= handler.OnVerified;

            handler = null;
        }
    }
}