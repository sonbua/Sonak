using System.Collections.Generic;
using System.Collections.ObjectModel;
using Sonak.Analyzer.KeyActions;
using Sonak.Analyzer.Keys.UsInternational;
using Sonak.Analyzer.Signals;

namespace Sonak.Analyzer.Layouts
{
    /// <summary>
    /// Represents the US-International QWERTY keyboard layout.
    /// </summary>
    internal class UsInternationalQwertyLayout : IUsInternationalLayout
    {
        public UsInternationalQwertyLayout()
        {
            Name = "QWERTY";
            KeyComboToSignalMap = new ReadOnlyDictionary<KeyCombo, ISignal>(new Dictionary<KeyCombo, ISignal>
                                                                            {
                                                                                // Number row
                                                                                {new KeyCombo(new PressKeyAction(new Key(0, "Grave"))), new ContentSignal('`')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(1, "D1"))), new ContentSignal('1')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(2, "D2"))), new ContentSignal('2')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(3, "D3"))), new ContentSignal('3')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(4, "D4"))), new ContentSignal('4')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(5, "D5"))), new ContentSignal('5')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(6, "D6"))), new ContentSignal('6')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(7, "D7"))), new ContentSignal('7')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(8, "D8"))), new ContentSignal('8')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(9, "D9"))), new ContentSignal('9')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(10, "D0"))), new ContentSignal('0')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(11, "Minus"))), new ContentSignal('-')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(12, "Equal"))), new ContentSignal('=')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(0, "Grave")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('~')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(1, "D1")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('!')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(2, "D2")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('@')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(3, "D3")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('#')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(4, "D4")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('$')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(5, "D5")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('%')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(6, "D6")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('^')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(7, "D7")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('&')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(8, "D8")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('*')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(9, "D9")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('(')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(10, "D0")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal(')')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(11, "Minus")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('{')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(12, "Equal")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('}')},
                                                                                {new KeyCombo(new PressKeyAction(new BackspaceKey())), new BackspaceCommandSignal()},

                                                                                // Top row
                                                                                {new KeyCombo(new PressKeyAction(new TabKey())), new ContentSignal('\t')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(15, "Q"))), new ContentSignal('q')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(16, "W"))), new ContentSignal('w')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(17, "E"))), new ContentSignal('e')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(18, "R"))), new ContentSignal('r')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(19, "T"))), new ContentSignal('t')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(20, "Y"))), new ContentSignal('y')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(21, "U"))), new ContentSignal('u')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(22, "I"))), new ContentSignal('i')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(23, "O"))), new ContentSignal('o')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(24, "P"))), new ContentSignal('p')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(25, "Open Square Bracket"))), new ContentSignal('[')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(26, "Closed Square Bracket"))), new ContentSignal(']')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(27, "Back Slash"))), new ContentSignal('\\')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(15, "Q")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('Q')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(16, "W")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('W')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(17, "E")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('E')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(18, "R")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('R')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(19, "T")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('T')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(20, "Y")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('Y')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(21, "U")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('U')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(22, "I")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('I')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(23, "O")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('O')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(24, "P")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('P')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(25, "Open Square Bracket")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('{')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(26, "Closed Square Bracket")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('}')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(27, "Back Slash")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('|')},

                                                                                // Home row
                                                                                {new KeyCombo(new PressKeyAction(new CapsLockKey())), new CapsLockCommandSignal()},
                                                                                {new KeyCombo(new PressKeyAction(new Key(29, "A"))), new ContentSignal('a')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(30, "S"))), new ContentSignal('s')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(31, "D"))), new ContentSignal('d')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(32, "F"))), new ContentSignal('f')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(33, "G"))), new ContentSignal('g')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(34, "H"))), new ContentSignal('h')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(35, "J"))), new ContentSignal('j')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(36, "K"))), new ContentSignal('k')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(37, "L"))), new ContentSignal('l')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(38, "Semicolon"))), new ContentSignal(';')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(39, "Single Quote"))), new ContentSignal('\'')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(29, "A")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('A')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(30, "S")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('S')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(31, "D")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('D')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(32, "F")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('F')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(33, "G")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('G')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(34, "H")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('H')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(35, "J")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('J')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(36, "K")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('K')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(37, "L")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('L')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(38, "Semicolon")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal(':')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(39, "Single Quote")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('"')},
                                                                                {new KeyCombo(new PressKeyAction(new ReturnKey())), new ContentSignal('\n')},

                                                                                // Bottom row
                                                                                {new KeyCombo(new PressKeyAction(new LShiftKey())), new ControlKeyCommandSignal()},
                                                                                {new KeyCombo(new PressKeyAction(new Key(42, "Z"))), new ContentSignal('z')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(43, "X"))), new ContentSignal('x')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(44, "C"))), new ContentSignal('c')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(45, "V"))), new ContentSignal('v')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(46, "B"))), new ContentSignal('b')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(47, "N"))), new ContentSignal('n')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(48, "M"))), new ContentSignal('m')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(49, "Comma"))), new ContentSignal(',')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(50, "Period"))), new ContentSignal('.')},
                                                                                {new KeyCombo(new PressKeyAction(new Key(51, "Slash"))), new ContentSignal('/')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(42, "Z")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('Z')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(43, "X")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('X')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(44, "C")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('C')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(45, "V")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('V')},
                                                                                {new KeyCombo(new HoldKeyAction(new RShiftKey()), new PressKeyAction(new Key(46, "B")), new ReleaseKeyAction(new RShiftKey())), new ContentSignal('B')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(47, "N")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('N')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(48, "M")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('M')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(49, "Comma")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('<')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(50, "Period")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('>')},
                                                                                {new KeyCombo(new HoldKeyAction(new LShiftKey()), new PressKeyAction(new Key(51, "Slash")), new ReleaseKeyAction(new LShiftKey())), new ContentSignal('?')},
                                                                                {new KeyCombo(new PressKeyAction(new RShiftKey())), new ControlKeyCommandSignal()},

                                                                                // Spacebar row
                                                                                {new KeyCombo(new PressKeyAction(new LCtrlKey())), new ControlKeyCommandSignal()},
                                                                                {new KeyCombo(new PressKeyAction(new LWinKey())), new ControlKeyCommandSignal()},
                                                                                {new KeyCombo(new PressKeyAction(new LAltKey())), new ControlKeyCommandSignal()},
                                                                                {new KeyCombo(new PressKeyAction(new SpaceKey())), new ControlKeyCommandSignal()},
                                                                                {new KeyCombo(new PressKeyAction(new RAltKey())), new ControlKeyCommandSignal()},
                                                                                {new KeyCombo(new PressKeyAction(new RWinKey())), new ControlKeyCommandSignal()},
                                                                                {new KeyCombo(new PressKeyAction(new MenuKey())), new ControlKeyCommandSignal()},
                                                                                {new KeyCombo(new PressKeyAction(new RCtrlKey())), new ControlKeyCommandSignal()},
                                                                            });
        }

        public string Name { get; }

        public IReadOnlyDictionary<KeyCombo, ISignal> KeyComboToSignalMap { get; }
    }
}