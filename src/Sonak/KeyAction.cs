namespace Sonak
{
    /// <summary>
    /// Represent an action with the key, e.g. hold, press, release, etc.
    /// </summary>
    public abstract class KeyAction
    {
        /// <summary>
        /// The default constructor.
        /// </summary>
        /// <param name="key">The key to be interacted.</param>
        protected KeyAction(Key key)
        {
            Key = key;
        }

        /// <summary>
        /// The key, which is being in interaction.
        /// </summary>
        public Key Key { get; }
    }
}