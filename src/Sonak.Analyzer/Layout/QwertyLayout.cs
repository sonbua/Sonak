using System.Collections.Generic;
using System.Collections.ObjectModel;
using Sonak.Layout;

namespace Sonak.Analyzer.Layout
{
    /// <summary>
    /// Represents the QWERTY keyboard layout.
    /// </summary>
    internal class QwertyLayout : ILayout
    {
        public QwertyLayout()
        {
            Name = "QWERTY";
            Keys = new ReadOnlyCollection<Key>(new List<Key>());
        }

        public string Name { get; }

        public IReadOnlyCollection<Key> Keys { get; }
    }
}