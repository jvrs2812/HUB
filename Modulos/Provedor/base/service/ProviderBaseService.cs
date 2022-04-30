public abstract class ProviderBaseService : IProviderBaseService
{
    protected ProviderBaseService()
    {
        this.Provider = new ModelProvider();
        this.repository = new ProviderBaseRepository();
    }

    public ModelProvider Provider { get; set; }
    public ProviderBaseRepository repository { get; set; }



    public virtual void ConfigureProvider()
    {
        Provider?.ConfigureProvider();
    }

    public virtual Task<ModelProductBase> Product(string id)
    {
        throw new NotImplementedException();
    }
}