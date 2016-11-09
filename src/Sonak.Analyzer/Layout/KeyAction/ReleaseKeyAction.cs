namespace Sonak.Analyzer.Layout.KeyAction
{
    /// <summary>
    /// Mimic the action, in which typist releases the key.
    /// </summary>
    internal class ReleaseKeyAction : Sonak.Layout.KeyAction
    {
        public ReleaseKeyAction(Key key)
            : base(key)
        {
        }
    }
}