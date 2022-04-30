using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class MLProviderRepository : ProviderBaseRepository
{
    public override async Task<HttpResponseMessage> GetProduct(string URL, string id)
    {
        HttpResponseMessage response = await api.GetAsync($"{URL + "//items?ids=" + id}");

        return response;

    }
}