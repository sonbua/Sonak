using Sonak.Layout;

namespace Sonak.Analyzer.Layout
{
    /// <summary>
    /// Mimic the action, in which typist presses and then immediately releases the key.
    /// </summary>
    internal class PressKeyAction : KeyAction
    {
        public PressKeyAction(Key key)
            : base(key)
        {
        }
    }
}