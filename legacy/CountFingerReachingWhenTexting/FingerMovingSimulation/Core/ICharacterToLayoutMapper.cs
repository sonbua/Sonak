using System.Collections.Generic;

namespace FingerMovingSimulation.Core
{
    /// <summary>
    /// Maps a given character to a series of key presses.
    /// </summary>
    internal interface ICharacterToLayoutMapper
    {
        /// <summary>
        /// Maps a given character to a series of key presses.
        /// </summary>
        /// <param name="c">Character to be typed.</param>
        /// <returns>Returns a series of keys to be pressed.</returns>
        IEnumerable<Keys> Map(char c);
    }
}