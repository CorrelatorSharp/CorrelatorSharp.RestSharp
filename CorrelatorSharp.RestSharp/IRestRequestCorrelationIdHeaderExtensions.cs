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
            var scope = ActivityScope.Current ?? ActivityScope.New(request.Resource);
            request.AddHeader(Headers.CorrelationId, scope.Id);
            
            if (string.IsNullOrWhiteSpace(scope.ParentId) == false)
            {
                request.AddHeader(Headers.CorrelationParentId, scope.ParentId);
            }

            if (string.IsNullOrWhiteSpace(scope.Name) == false)
            {
                request.AddHeader(Headers.CorrelationName, scope.Name);
            }
        }
    }
}
