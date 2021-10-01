using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BroadcastPlugin
{
	public class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;
		public string ChaosEntrance { get; set; } = "Chaos Insurgency has entered the facility.";
		public ushort ChaosEntranceDuration { get; set; } = 10;
		public bool ChaosEntranceOnlyCdpAndChi { get; set; } = true;
		public string NtfEntrance { get; set; } = "MTF {UnitName}-{UnitNumber} has entered the facility\nRemaining SCPs : {ScpCount}";
		public string NtfEntranceNoScp { get; set; } = "MTF {UnitName}-{UnitNumber} has entered the facility\nNo SCPs left.";
		public ushort NtfEntranceDuration { get; set; } = 10;
		public ushort ScpContainedDuration { get; set; } = 10;
		public string ScpContainedByCdp { get; set; } = "{ScpName} contained successfully. Containment unit : Class-D Personnel";
		public string ScpContainedByRsc { get; set; } = "{ScpName} contained successfully. Containment unit : Science Personnel";
		public string ScpContainedByMtf { get; set; } = "{ScpName} contained successfully. Containment unit : {UnitName}";
		public string ScpContainedByChi { get; set; } = "{ScpName} contained successfully. Containment unit : Chaos Insurgency";
		public string ScpContaindedByTesla { get; set; } = "{ScpName} terminated by Tesla gate";
		public string ScpContainedByNuke { get; set; } = "{ScpName} terminated by Alpha Warhead";
		public string ScpContainedByDecon { get; set; } = "{ScpName} lost in Decontamination Sequence.";
		public string ScpContainedByMicrohidCdp { get; set; } = "{ScpName} contained successfully. Containment unit : Micro H.I.D ( Class-D Personnel )";
		public string ScpContainedByMicrohidRsc { get; set; } = "{ScpName} contained successfully. Containment unit : Micro H.I.D ( Science Personnel )";
		public string ScpContainedByMicrohidMtf { get; set; } = "{ScpName} contained successfully. Containment unit : Micro H.I.D ( {UnitName} )";
		public string ScpContainedByMicrohidChi { get; set; } = "{ScpName} contained successfully. Containment unit : Micro H.I.D ( Chaos Insurgency )";
		public string ScpContainedByUnknown { get; set; } = "{ScpName} contained successfully. Containment unit : Unknown";
		public string Scp079Recontained { get; set; } = "{ScpName} contained successfully.";
		public ushort WarheadDuration { get; set; } = 10;
		public string WarheadStart { get; set; } = "Alpha Warhead Detonation engaged.\nThe underground section in the facility will be detonated in {WarheadTime} seconds";
		public string WarheadStop { get; set; } = "Alpha Warhead Detonation canceled.\nRestarting systems.";
		public ushort DeconDuration { get; set; } = 10;
		public string Decon15m { get; set; } = "Light Containment Zone overall decontamination in T-minus 15 minutes.";
		public string Decon10m { get; set; } = "Light Containment Zone overall decontamination in T-minus 10 minutes.";
		public string Decon5m { get; set; } = "Light Containment Zone overall decontamination in T-minus 5 minutes.";
		public string Decon1m { get; set; } = "Light Containment Zone overall decontamination in T-minus 1 minutes.";
		public string Decon30s { get; set; } = "Light Containment Zone overall decontamination in T-minus 30 seconds.";
		public string DeconLockedDown { get; set; } = "Light Containment Zone is locked down and ready for decontamination.\nThe removal of organic substances has now begun.";
		public ushort GeneratorDuration { get; set; } = 8;
		public string Generator1 { get; set; } = "1 out of 5 generators activated.";
		public string Generator2 { get; set; } = "2 out of 5 generators activated.";
		public string Generator3 { get; set; } = "3 out of 5 generators activated.";
		public string Generator4 { get; set; } = "4 out of 5 generators activated.";
		public string Generator5 { get; set; } = "5 out of 5 generators activated.";
		[Description("Translation for {ScpName}")]
		public string Translation_Scp049 { get; set; } = "SCP-049";
		public string Translation_Scp079 { get; set; } = "SCP-079";
		public string Translation_Scp096 { get; set; } = "SCP-096";
		public string Translation_Scp106 { get; set; } = "SCP-106";
		public string Translation_Scp173 { get; set; } = "SCP-173";
		public string Translation_Scp93953 { get; set; } = "SCP-939-53";
		public string Translation_Scp93989 { get; set; } = "SCP-939-89";
	}
}
