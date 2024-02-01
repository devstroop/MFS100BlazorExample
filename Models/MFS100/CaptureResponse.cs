using Newtonsoft.Json;

namespace MFS100Example.Models.MFS100
{
    public class CaptureResponse
    {
        [JsonProperty("httpStaus")]
        public bool HttpStaus { get; set; }
        [JsonProperty("data")]
        public CaptureResponseData Data { get; set; }
    }
}
