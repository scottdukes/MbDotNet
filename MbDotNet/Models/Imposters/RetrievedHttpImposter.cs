using MbDotNet.Models.Requests;
using Newtonsoft.Json;

namespace MbDotNet.Models.Imposters
{
    public class RetrievedHttpImposter : HttpImposter, IRetrievedImposter<HttpRequest>
    {
        public RetrievedHttpImposter(int? port, string name, bool recordRequests = false) : base(port, name, recordRequests)
        {
        }

        [JsonProperty("numberOfRequests")]
        public int NumberOfRequests { get; private set; }

        [JsonProperty("requests")]
        public HttpRequest[] Requests { get; private set; }
    }
}
