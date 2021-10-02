namespace BrowserTests.Common.Pages
{
    public interface IPageObject<TPageObjectModel>
        where TPageObjectModel : new()
    {
        TPageObjectModel PageObjectModel { get; }
        void NaviageToPage();
    }
}
