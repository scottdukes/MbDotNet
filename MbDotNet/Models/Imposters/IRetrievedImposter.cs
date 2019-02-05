using MbDotNet.Models.Requests;
using Newtonsoft.Json;

namespace MbDotNet.Models.Imposters
{
    /// <summary>
    /// The base class for a retrieved imposter.
    /// </summary>
    /// <typeparam name="T">The request type this imposter contains</typeparam>
    public interface IRetrievedImposter<T> where T: Request
    {
        int NumberOfRequests { get; }
        T[] Requests { get; }
    }
}