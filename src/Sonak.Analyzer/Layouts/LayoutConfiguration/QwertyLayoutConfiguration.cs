using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Sonak.Analyzer.Keys.UsInternational;
using Sonak.Layout;

namespace Sonak.Analyzer.Layouts.LayoutConfiguration
{
    /// <summary>
    /// Store the configuration for QWERTY layout.
    /// </summary>
    internal class QwertyLayoutConfiguration : ILayoutConfiguration
    {
        public QwertyLayoutConfiguration()
        {
            KeyComboToCharMap = new ReadOnlyDictionary<KeyCombo, char>(new Dictionary<KeyCombo, char>
                                                                       {
                                                                           {new KeyCombo(new Key(0, "Grave"), Enumerable.Empty<Key>()), '`'},
                                                                           {new KeyCombo(new Key(0, "Grave"), new[] {new RShiftKey()}), '~'},
                                                                       });
        }

        public IReadOnlyDictionary<KeyCombo, char> KeyComboToCharMap { get; }
    }
}