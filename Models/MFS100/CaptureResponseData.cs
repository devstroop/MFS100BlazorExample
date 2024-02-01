using Newtonsoft.Json;

namespace MFS100Example.Models.MFS100
{
    public class CaptureResponseData
    {
        [JsonProperty("AnsiTemplate")]
        public string AnsiTemplate { get; set; }
        [JsonProperty("BitmapData")]
        public string BitmapData { get; set; }
        [JsonProperty("Bpp")]
        public int Bpp { get; set; }
        [JsonProperty("ErrorCode")]
        public string ErrorCode { get; set; }
        [JsonProperty("ErrorCode")]
        public string ErrorDescription { get; set; }
        [JsonProperty("GrayScale")]
        public int GrayScale { get; set; }
        [JsonProperty("InArea")]
        public double InArea { get; set; }
        [JsonProperty("InHeight")]
        public double InHeight { get; set; }
        [JsonProperty("InWidth")]
        public double InWidth { get; set; }
        [JsonProperty("IsoImage")]
        public string IsoImage { get; set; }
        [JsonProperty("IsoTemplate")]
        public string IsoTemplate { get; set; }
        [JsonProperty("MinutiaeData")]
        public int Nfiq { get; set; }
        [JsonProperty("Quality")]
        public int Quality { get; set; }
        [JsonProperty("RawData")]
        public string RawData { get; set; }
        [JsonProperty("Resolution")]
        public int Resolution { get; set; }
        [JsonProperty("WSQCompressRatio")]
        public int WSQCompressRatio { get; set; }
        [JsonProperty("WSQInfo")]
        public string WSQInfo { get; set; }
        [JsonProperty("WSQImage")]
        public string WsqImage { get; set; }
    }
}
