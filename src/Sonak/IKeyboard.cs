using System.Collections.Generic;

namespace Sonak
{
    /// <summary>
    /// Represents a keyboard type, e.g. US-International, European, ErgoDox, etc.
    /// </summary>
    public interface IKeyboard
    {
        /// <summary>
        /// Represents the layout of this keyboard.
        /// </summary>
        ILayout Layout { get; }

        /// <summary>
        /// Holds a set of keys of this keyboard.
        /// </summary>
        IReadOnlyCollection<IKey> Keys { get; }
    }
}