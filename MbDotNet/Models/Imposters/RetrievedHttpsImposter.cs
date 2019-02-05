using MbDotNet.Models.Requests;
using Newtonsoft.Json;

namespace MbDotNet.Models.Imposters
{
    public class RetrievedHttpsImposter : IRetrievedImposter<HttpRequest>
    {
        [JsonProperty("key")]
        public string Key { get; internal set; }

        [JsonProperty("cert")]
        public string Cert { get; internal set; }

        [JsonProperty("mutualAuth")]
        public bool MutualAuthRequired { get; internal set; }

        public int NumberOfRequests => throw new System.NotImplementedException();

        public HttpRequest[] Requests => throw new System.NotImplementedException();
    }
}
