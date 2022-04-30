public class WebServiceProvider
{
    public ProviderBaseService setProvider(string provider)
    {
        switch (provider)
        {
            case "ML":
                return new MLProvider();
            default:
                throw new NotImplementedException();
        }
    }
}