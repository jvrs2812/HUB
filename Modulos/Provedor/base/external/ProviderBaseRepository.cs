public class ProviderBaseRepository : IProviderBaseRepository
{
    public HttpClient api { get; set; }

    public ProviderBaseRepository()
    {
        this.api = new HttpClient();
    }
    public virtual Task<HttpResponseMessage> GetProduct(string URL, string id)
    {
        throw new NotImplementedException();
    }
}