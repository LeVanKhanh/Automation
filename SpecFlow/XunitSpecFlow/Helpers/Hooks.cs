using System.Diagnostics;
using TechTalk.SpecFlow;

namespace XunitSpecFlow.Helpers
{
    [Binding]
    public class Hooks : TechTalk.SpecFlow.Steps
    {
        [BeforeScenario(Order = 1)]
        public void BeforeScenario_First()
        {
            var title = ScenarioContext.ScenarioInfo.Title;
            Debug.WriteLine($"BeforeScenario: {title}", "TestLogs");
        }

        [BeforeScenario(Order = 2)]
        public void BeforeScenario_Second()
        {
            var title = ScenarioContext.ScenarioInfo.Title;
            Debug.WriteLine($"BeforeScenario: {title}", "TestLogs");
        }

        [AfterScenario(Order = 1)]
        public void AfterScenario_First()
        {
            var title = ScenarioContext.ScenarioInfo.Title;
            Debug.WriteLine($"AfterScenario: {title}", "TestLogs");
        }

        [AfterScenario(Order = 2)]
        public void AfterScenario_Second()
        {
            var title = ScenarioContext.ScenarioInfo.Title;
            Debug.WriteLine($"AfterScenario: {title}", "TestLogs");
        }
    }
}
