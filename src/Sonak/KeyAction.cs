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

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((KeyAction) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Key?.GetHashCode() ?? 0;
        }

        /// <summary>
        /// Tests the equality of this instance to other instance.
        /// </summary>
        /// <param name="other">The other object in equality test.</param>
        /// <returns></returns>
        protected bool Equals(KeyAction other)
        {
            return Equals(Key, other.Key);
        }
    }
}