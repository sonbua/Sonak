namespace Sonak
{
    /// <summary>
    /// Represents a key on the keyboard, e.g. A, S, D, F, etc.
    /// </summary>
    public class Key
    {
        /// <summary>
        /// The default constructor.
        /// </summary>
        /// <param name="id">The key's ID.</param>
        /// <param name="description">The key's description.</param>
        public Key(int id, string description)
        {
            Id = id;
            Description = description;
        }

        /// <summary>
        /// The key ID.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Describe the position of the key on the keyboard, e.g.: left ring finger upper row, left index finger bottom row, etc.
        /// </summary>
        public string Description { get; }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Key) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode() => Id;

        /// <summary>
        /// Tests the equality of this instance to other instance.
        /// </summary>
        /// <param name="other">The other key.</param>
        /// <returns></returns>
        protected bool Equals(Key other) => Id == other.Id;
    }
}