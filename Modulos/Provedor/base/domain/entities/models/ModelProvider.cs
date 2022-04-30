public class ModelProvider
{
    public ModelProvider()
    {
        this.nomeProvider = "";
        this.providerEnum = ProvidersEnums.NotImplements;
        this.URLbase = "";
    }
    public string nomeProvider { get; set; }

    public ProvidersEnums providerEnum { get; set; }

    public string URLbase { get; set; }

    public virtual void ConfigureProvider()
    {
        throw new NotImplementedException();
    }
}