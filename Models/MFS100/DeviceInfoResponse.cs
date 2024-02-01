using Newtonsoft.Json;

namespace MFS100Example.Models.MFS100
{
    public class DeviceInfoResponse
    {
        [JsonProperty("httpStaus")]
        public bool HttpStaus { get; set; }
        [JsonProperty("data")]
        public DeviceInfoResponseData Data { get; set; }
    }
}
