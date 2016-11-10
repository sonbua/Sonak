namespace Sonak.Analyzer.KeyActions
{
    /// <summary>
    /// Mimic the action, in which typist holds the key while pressing/holding another key, i.e. combo action.
    /// </summary>
    internal class HoldKeyAction : KeyAction
    {
        public HoldKeyAction(Key key)
            : base(key)
        {
        }
    }
}