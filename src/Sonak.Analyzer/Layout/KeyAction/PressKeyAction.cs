namespace Sonak.Analyzer.Layout.KeyAction
{
    /// <summary>
    /// Mimic the action, in which typist presses and then immediately releases the key.
    /// </summary>
    internal class PressKeyAction : Sonak.Layout.KeyAction
    {
        public PressKeyAction(Key key)
            : base(key)
        {
        }
    }
}