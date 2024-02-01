using Newtonsoft.Json;

namespace MFS100Example.Models.MFS100
{
    public class DeviceInfo
    {
        [JsonProperty("Certificate")]
        public string Certificate { get; set; }
        [JsonProperty("Height")]
        public int Height { get; set; }
        [JsonProperty("LocalIP")]
        public string LocalIP { get; set; }
        [JsonProperty("LocalMac")]
        public string LocalMac { get; set; }
        [JsonProperty("Make")]
        public string Make { get; set; }
        [JsonProperty("Model")]
        public string Model { get; set; }
        [JsonProperty("PublicIP")]
        public string PublicIP { get; set; }
        [JsonProperty("SerialNo")]
        public string SerialNo { get; set; }
        [JsonProperty("SystemID")]
        public string SystemID { get; set; }
        [JsonProperty("Width")]
        public int Width { get; set; }
    }
}
