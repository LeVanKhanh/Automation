using TechTalk.SpecFlow;

namespace XunitSpecFlow.Helpers
{
    [Binding]
    public class CustomConversions
    {
        [StepArgumentTransformation(@"(^ToEmptyString$)")]
        public string ToEmptyString(dynamic para)
        {
            return string.Empty;
        }

        [StepArgumentTransformation(@"(^ToNullString$)")]
        public string ToNullString(dynamic para)
        {
            return null;
        }
    }
}
