using Sonak.Keyboard;

namespace Sonak.Analyzer
{
    /// <summary>
    /// Represents a default recorder, which records typist's movement on a specific keyboard.
    /// </summary>
    internal class DefaultRecorder : IRecorder
    {
        private readonly ITypist _typist;
        private readonly IKeyboard _keyboard;

        public DefaultRecorder(ITypist typist, IKeyboard keyboard)
        {
            _typist = typist;
            _keyboard = keyboard;
        }
    }
}