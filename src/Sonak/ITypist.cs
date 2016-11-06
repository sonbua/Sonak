namespace Sonak
{
    /// <summary>
    /// Represents a typist.
    /// </summary>
    public interface ITypist
    {
        /// <summary>
        /// Types a sequence of Unicode characters.
        /// </summary>
        /// <param name="text">A sequence of Unicode characters.</param>
        void Type(string text);
    }
}