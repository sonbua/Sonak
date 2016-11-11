namespace Sonak
{
    /// <summary>
    /// Represents a keyboard type, e.g. US-International, European, ErgoDox, etc.
    /// </summary>
    public interface IKeyboard
    {
        /// <summary>
        /// The name of the keyboard.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Represents the layout of this keyboard.
        /// </summary>
        ILayout Layout { get; }
    }
}