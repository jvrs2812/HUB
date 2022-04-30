public class ModelProviderML : ModelProvider
{
    public override void ConfigureProvider()
    {
        this.nomeProvider = "Mercado Livre";
        this.providerEnum = ProvidersEnums.ML;
        this.URLbase = "https://api.mercadolibre.com/";
    }
}