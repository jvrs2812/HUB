public interface IProviderBaseRepository
{
    public HttpClient api { get; set; }

    public Task<HttpResponseMessage> GetProduct(string URL, string id);
}