class MLProductResponse
{
    public MLProductResponse()
    {
        this.body = new ModelProductBase();
    }
    public int code { get; set; }
    public ModelProductBase body { get; set; }
}