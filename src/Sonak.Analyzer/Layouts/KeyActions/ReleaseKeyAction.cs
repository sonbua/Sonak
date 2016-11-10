using Sonak.Layout;

namespace Sonak.Analyzer.Layouts.KeyActions
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