using System.Diagnostics;

namespace NotDisposingIssueNet7.Pages
{
    public partial class RegularComponent
    {
        public bool ShowComponent;

        public void ShowComponentButtonClicked()
        {
			Console.WriteLine("Button clicked!");
			ShowComponent = !ShowComponent;
        }

        public string GetShowComponentButtonText()
        {
            return ShowComponent ? "Hide Component" : "Show Component";
        }
    }
}
