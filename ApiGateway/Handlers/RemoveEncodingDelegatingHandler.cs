namespace ApiGateway.Handlers
{
    public class RemoveEncodingDelegatingHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage recuest, CancellationToken cancellationToken)
        {
            recuest.Headers.AcceptEncoding.Clear();
            return await base.SendAsync(recuest, cancellationToken);
        }
    }
}
