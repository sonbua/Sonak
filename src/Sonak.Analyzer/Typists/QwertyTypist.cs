using System;
using Sonak.Keyboard;

namespace Sonak.Analyzer.Typists
{
    /// <summary>
    /// Represents a typist, who works with a QWERTY layout.
    /// </summary>
    internal class QwertyTypist : ITypist
    {
        private readonly IKeyboard _keyboard;

        /// <summary>
        /// The default constructor.
        /// </summary>
        /// <param name="keyboard">The keyboard, which this typist works with.</param>
        public QwertyTypist(IKeyboard keyboard)
        {
            _keyboard = keyboard;
        }

        /// <summary>
        /// Types a sequence of Unicode characters.
        /// </summary>
        /// <param name="text">A sequence of Unicode characters.</param>
        public void Type(string text)
        {
            throw new NotImplementedException();
        }
    }
}