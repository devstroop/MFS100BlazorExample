using Newtonsoft.Json;

namespace MFS100Example.Models.MFS100
{
    public class DeviceInfoResponseData
    {
        [JsonProperty("DeviceInfo")]
        public DeviceInfo DeviceInfo { get; set; }
        [JsonProperty("ErrorCode")]
        public string ErrorCode { get; set; }
        [JsonProperty("ErrorDescription")]
        public string ErrorDescription { get; set; }
        [JsonProperty("WSQInfo")]
        public string WSQInfo { get; set; }
    }
}
