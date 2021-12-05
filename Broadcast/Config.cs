namespace BroadcastPlugin
{
	using Exiled.API.Enums;
	using Exiled.API.Interfaces;
	using System.Collections.Generic;
	using System.ComponentModel;
	using BroadcastPlugin.ConfigObjects;
	public class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;

		public List<ConfigChaos> ChaosEntrance { get; set; } = new List<ConfigChaos>()
		{
			new ConfigChaos
			{
				Duration = 10,
				Message = "Chaos Insurgency has entered the facility.",
				OnlyForCdpAndChi = true
			}
		};
		public List<ConfigNtf> NtfEntrance { get; set; } = new List<ConfigNtf>()
		{
			new ConfigNtf
			{
				Duration = 8,
				Message = "MTF {UnitName}-{UnitNumber} has entered the facility\nRemaining SCPs : {ScpCount}",
				MessageNoscp = "MTF {UnitName}-{UnitNumber} has entered the facility\nNo SCPs left."
			}
		};
		public List<ConfigScp> ScpContained { get; set; } = new List<ConfigScp>()
		{
			new ConfigScp
			{
				Duration = 10,
				Cdp = "{ScpName} contained successfully. Containment unit : Class-D Personnel",
				CdpMicrohid = "{ScpName} contained successfully. Containment unit : Micro H.I.D. ( Class-D Personnel )",
				Rsc = "{ScpName} contained successfully. Containment unit : Science Personnel",
				RscMicrohid = "{ScpName} contained successfully. Containment unit : Micro H.I.D. ( Science Personnel )",
				Mtf = "{ScpName} contained successfully. Containment unit : {UnitName}",
				MtfMicrohid = "{ScpName} contained successfully. Containment unit : Micro H.I.D. ( {UnitName} )",
				Chi = "{ScpName} contained successfully. Containment unit : Chaos Insurgency",
				ChiMicrohid = "{ScpName} contained successfully. Containment unit : Micro H.I.D. ( Chaos Insurgency )",
				Tesla = "{ScpName} terminated by Tesla Gate.",
				Nuke = "{ScpName} terminated by Alpha Warhead.",
				Decon = "{ScpName} lost in Decontamination Sequence.",
				Unknown = "{ScpName} contained successfully. Containment unit : Unknown",
				Scp079 = "{ScpName} contained successfully."
			}
		};
		public List<ConfigWarhead> Warhead { get; set; } = new List<ConfigWarhead>()
		{
			new ConfigWarhead
			{
				Duration = 10,
				Start = "Alpha Warhead Detonation engaged.\nThe underground section in the facility will be detonated in {WarheadTime} seconds",
				Stop = "Alpha Warhead Detonation canceled.\nRestarting systems.",
			}
		};
		public List<ConfigDecon> Decon { get; set; } = new List<ConfigDecon>()
		{
			new ConfigDecon
			{
				Duration = 10,
				Msg_15m = "Light Containment Zone overall decontamination in T-minus 15 minutes.",
				Msg_10m = "Light Containment Zone overall decontamination in T-minus 10 minutes.",
				Msg_5m = "Light Containment Zone overall decontamination in T-minus 5 minutes.",
				Msg_1m = "Light Containment Zone overall decontamination in T-minus 1 minutes.",
				Msg_30s = "Light Containment Zone overall decontamination in T-minus 30 seconds",
				Msg_LockedDown = "Light Containment Zone is locked down and ready for decontamination.\nThe removal of organic substances has now begun.",
				OnlyForLcz = false
			}
		};
		public List<ConfigGenerator> Gen { get; set; } = new List<ConfigGenerator>()
		{
			new ConfigGenerator
			{
				Duration = 10,
				Gen1 = "1 out of 3 generators activated.",
				Gen2 = "2 out of 3 generators activated.",
				Gen3 = "3 out of 3 generators activated.",
			}
		};
		public List<ConfigPlayer> PlayerJoin { get; set; } = new List<ConfigPlayer>()
		{
			new ConfigPlayer
			{
				Duration = 5,
				Message = "Welcome {Player}!\n{PlayersCount} are playing in this server\nRound Duration: {RoundDurationMinutes} m {RoundDurationSeconds} s",
			}
		};
		public List<ConfigTranslation> Translations { get; set; } = new List<ConfigTranslation>()
		{
			new ConfigTranslation
			{
				Scp049 = "SCP-049",
				Scp079 = "SCP-079",
				Scp096 = "SCP-096",
				Scp106 = "SCP-106",
				Scp173 = "SCP-173",
				Scp93953 = "SCP-939-53",
				Scp93989 = "SCP-939-89"
			}
		};
	}
}
