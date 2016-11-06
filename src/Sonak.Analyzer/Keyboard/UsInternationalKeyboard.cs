using Sonak.Keyboard;
using Sonak.Layout;

namespace Sonak.Analyzer.Keyboard
{
    internal class UsInternationalKeyboard : IUsInternationalKeyboard
    {
        public UsInternationalKeyboard(IUsInternationalLayout layout)
        {
            Name = "US-International Keyboard";
            Layout = layout;
        }

        public string Name { get; }

        public ILayout Layout { get; protected set; }
    }
}