using System.Collections.Generic;

namespace Sonak.Layout
{
    /// <summary>
    /// Represents a keyboard layout, e.g. QWERTY, Dvorak, Colemak, etc.
    /// </summary>
    public interface ILayout
    {
        /// <summary>
        /// The name of this keyboard layout.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Holds a set of keys of this keyboard layout.
        /// </summary>
        IReadOnlyCollection<Key> Keys { get; }
    }
}