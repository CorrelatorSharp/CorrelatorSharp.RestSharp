using RestSharp;

namespace CorrelatorSharp.RestSharp
{
    public static class IRestClientCorrelationIdHeaderExtensions
    {
        /// <summary>
        /// Add the current CorrelatorSharp.ActivityScope identifier as a default http header (X-Correlator-Id).
        /// 
        /// Be aware this will add a default header at the call time, and will not be refreshed at the point of execution of any requests.
        /// Please take note of the lifetime and scope of the IRestClient instance before using.
        /// </summary>
        /// <param name="client">The RestSharp.IRestClient</param>
        public static void AddCorrelationHeader(this IRestClient client)
        {
            var scope = ActivityScope.Current ?? ActivityScope.New(client.BaseUrl.ToString());
            client.AddDefaultHeader(Headers.CorrelationId, scope.Id);
        }
    }
}
