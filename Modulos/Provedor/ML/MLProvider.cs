using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


public class MLProvider : ProviderBaseService
{

    public MLProvider()
    {
        ConfigureProvider();
    }

    public override void ConfigureProvider()
    {
        this.repository = new MLProviderRepository();
        this.Provider = new ModelProviderML();
        this.Provider.ConfigureProvider();
    }

    public override async Task<ModelProductBase> Product(string id)
    {
        ModelProductBase modelo = new ModelProductBase();

        HttpResponseMessage response = await repository.GetProduct(Provider.URLbase, id);

        JArray array = JArray.Parse(await response.Content.ReadAsStringAsync());
        MLProductResponse? modeloBase = new MLProductResponse();
        modeloBase = JsonConvert.DeserializeObject<MLProductResponse>(array[0].ToString());

        if (modeloBase?.code == 200)
        {
            if (modeloBase.body is null)
            {
                modeloBase.body = new ModelProductBase();
            }
            return modeloBase.body;
        }
        else if (modeloBase?.code == 404)
        {
            throw new NotFoundException("Produto não encontrado");
        }
        else
        {
            throw new Exception("Algo não saiu como planejado. Chame o administrador. Erro codigo = 6X21312");
        }
    }
}