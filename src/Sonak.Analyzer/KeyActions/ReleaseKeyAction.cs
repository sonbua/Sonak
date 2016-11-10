namespace Sonak.Analyzer.KeyActions
{
    /// <summary>
    /// Mimic the action, in which typist releases the key.
    /// </summary>
    internal class ReleaseKeyAction : KeyAction
    {
        public ReleaseKeyAction(Key key)
            : base(key)
        {
        }
    }
}