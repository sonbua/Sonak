namespace Sonak.Analyzer.Layout.KeyAction
{
    /// <summary>
    /// Mimic the action, in which typist holds the key while pressing/holding another key, i.e. combo action.
    /// </summary>
    internal class HoldKeyAction : Sonak.Layout.KeyAction
    {
        public HoldKeyAction(Key key)
            : base(key)
        {
        }
    }
}