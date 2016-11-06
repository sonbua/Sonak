using System.Collections.Generic;

namespace Sonak.Analyzer.Keyboard
{
    internal class UsInternational : IKeyboard
    {
        public ILayout Layout { get; }

        public IReadOnlyCollection<IKey> Keys { get; }
    }
}