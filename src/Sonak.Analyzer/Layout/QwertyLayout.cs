using System.Collections.Generic;
using System.Collections.ObjectModel;
using Sonak.Layout;

namespace Sonak.Analyzer.Layout
{
    /// <summary>
    /// Represents the US-International QWERTY keyboard layout.
    /// </summary>
    internal class QwertyLayout : IUsInternationalLayout
    {
        public QwertyLayout()
        {
            Name = "QWERTY";
            Keys = new ReadOnlyCollection<Key>(new List<Key>
                                               {
                                                   // Number row
                                                   new Key(0, "Grave"),
                                                   new Key(1, "D1"),
                                                   new Key(2, "D2"),
                                                   new Key(3, "D3"),
                                                   new Key(4, "D4"),
                                                   new Key(5, "D5"),
                                                   new Key(6, "D6"),
                                                   new Key(7, "D7"),
                                                   new Key(8, "D8"),
                                                   new Key(9, "D9"),
                                                   new Key(10, "D0"),
                                                   new Key(11, "Minus"),
                                                   new Key(12, "Equal"),
                                                   new Key(13, "Backspace"),
                                                   // Top row
                                                   new Key(14, "Tab"),
                                                   new Key(15, "Q"),
                                                   new Key(16, "W"),
                                                   new Key(17, "E"),
                                                   new Key(18, "R"),
                                                   new Key(19, "T"),
                                                   new Key(20, "Y"),
                                                   new Key(21, "U"),
                                                   new Key(22, "I"),
                                                   new Key(23, "O"),
                                                   new Key(24, "P"),
                                                   new Key(25, "Open Square Bracket"),
                                                   new Key(26, "Closed Square Bracket"),
                                                   new Key(27, "Pipe"),
                                                   // Home row
                                                   new Key(28, "CapsLock"),
                                                   new Key(29, "A"),
                                                   new Key(30, "S"),
                                                   new Key(31, "D"),
                                                   new Key(32, "F"),
                                                   new Key(33, "G"),
                                                   new Key(34, "H"),
                                                   new Key(35, "J"),
                                                   new Key(36, "K"),
                                                   new Key(37, "L"),
                                                   new Key(38, "Semicolon"),
                                                   new Key(39, "Single Quote"),
                                                   new Key(40, "Return"),
                                                   // Bottom row
                                                   new Key(41, "LShift"),
                                                   new Key(42, "Z"),
                                                   new Key(43, "X"),
                                                   new Key(44, "C"),
                                                   new Key(45, "V"),
                                                   new Key(46, "B"),
                                                   new Key(47, "N"),
                                                   new Key(48, "M"),
                                                   new Key(49, "Comma"),
                                                   new Key(50, "Period"),
                                                   new Key(51, "Slash"),
                                                   new Key(52, "RShift"),
                                               });
        }

        public string Name { get; }

        public IReadOnlyCollection<Key> Keys { get; }
    }
}