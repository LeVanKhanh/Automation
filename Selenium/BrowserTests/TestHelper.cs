using System.Threading;

namespace BrowserTests
{
    public static class TestHelper
    {
        public static void Pause(int miliseconds = 1000)
        {
            Thread.Sleep(miliseconds);
        }
    }
}
