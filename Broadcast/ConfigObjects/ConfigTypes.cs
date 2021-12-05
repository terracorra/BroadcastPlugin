namespace BroadcastPlugin.ConfigObjects
{
    public class ConfigChaos
    {
        public ushort Duration{ get; set; }
        public string Message { get; set; }
        public bool OnlyForCdpAndChi { get; set; }
    }
    public class ConfigNtf
    {
        public ushort Duration { get; set; }
        public string Message { get; set; }
        public string MessageNoscp { get; set; }
    }
    public class ConfigScp
    {
        public ushort Duration { get; set; }
        public string Cdp { get; set; }
        public string CdpMicrohid { get; set; }
        public string Rsc { get; set; }
        public string RscMicrohid { get; set; }
        public string Mtf { get; set; }
        public string MtfMicrohid { get; set; }
        public string Chi { get; set; }
        public string ChiMicrohid { get; set; }
        public string Tesla { get; set; }
        public string Nuke { get; set; }
        public string Decon { get; set; }
        public string Unknown { get; set; }
        public string Scp079 { get; set; }
    }
    public class ConfigWarhead
    {
        public ushort Duration { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }
    }
    public class ConfigDecon
    {
        public ushort Duration { get; set; }
        public string Msg_15m { get; set; }
        public string Msg_10m { get; set; }
        public string Msg_5m { get; set; }
        public string Msg_1m { get; set; }
        public string Msg_30s { get; set; }
        public string Msg_LockedDown { get; set; }
        public bool OnlyForLcz { get; set; }
    }
    public class ConfigGenerator
    {
        public ushort Duration { get; set; }
        public string Gen1 { get; set; }
        public string Gen2 { get; set; }
        public string Gen3 { get; set; }
    }
    public class ConfigPlayer
    {
        public ushort Duration { get; set; }
        public string Message { get; set; }
    }
    public class ConfigTranslation
    {
        public string Scp049 { get; set; }
        public string Scp079 { get; set; }
        public string Scp096 { get; set; }
        public string Scp106 { get; set; }
        public string Scp173 { get; set; }
        public string Scp93953 { get; set; }
        public string Scp93989 { get; set; }
    }
}