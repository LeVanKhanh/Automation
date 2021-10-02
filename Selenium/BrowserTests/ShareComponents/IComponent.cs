namespace BrowserTests.ShareComponents
{
    public interface IComponent<TComponentObjectModel>
          where TComponentObjectModel : new()
    {
        TComponentObjectModel ComponentObjectModel { get; }
    }
}
