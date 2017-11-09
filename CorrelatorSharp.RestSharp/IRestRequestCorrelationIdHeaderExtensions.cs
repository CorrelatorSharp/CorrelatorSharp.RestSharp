using System;
using RestSharp;

namespace CorrelatorSharp.RestSharp
{
    public static class IRestRequestCorrelationIdHeaderExtensions
    {
        /// <summary>
        /// Add the current CorrelatorSharp.ActivityScope identifier as a http header (X-Correlator-Id).
        /// </summary>
        /// <param name="request">The RestSharp.RestRequest</param>
        public static void AddCorrelationHeader(this IRestRequest request)
        {
            request.AddHeader(Headers.CorrelationId, ActivityScope.Current?.Id ?? Guid.NewGuid().ToString());
        }
    }
}
