using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace OneDrive
{
    public class ODViewDeltaResult : ODItemCollection
    {
        [JsonProperty("@changes.hasMoreChanges")]
        public bool HasMoreChanges { get; set; }

        [JsonProperty("@delta.token")]
        public string NextToken { get; set; }

        [JsonProperty("@odata.deltaLink")]
        public string DeltaLink { get; set; }
    }
}
