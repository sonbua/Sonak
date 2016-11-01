namespace FingerMovingSimulation.Core.Expanders
{
    /// <summary>
    /// Map Vietnamese tone to a character on the keyboard.
    /// </summary>
    public interface IToneMapper
    {
        /// <summary>
        /// Map Vietnamese tone to a character on the keyboard.
        /// </summary>
        /// <param name="tone">Tone to map.</param>
        /// <returns>Returns a character for given tone.</returns>
        char MapToCharacter(Tones tone);
    }
}