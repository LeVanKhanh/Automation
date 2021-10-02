namespace BrowserTests.Common.Pages
{
    public interface IPageObject
    {

    }

    public interface IPageObject<TPageObjectModel> : IPageObject
        where TPageObjectModel : new()
    {
        TPageObjectModel PageObjectModel { get; }
        void NaviageToPage();
    }
}
