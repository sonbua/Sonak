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

        /// <summary>Determines whether the specified object is equal to the current object.</summary>
        /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
        /// <param name="obj">The object to compare with the current object. </param>
        /// <filterpriority>2</filterpriority>
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

        /// <summary>Serves as the default hash function. </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return Id;
        }

        /// <summary>
        /// Test the equality of this instance to other instance.
        /// </summary>
        /// <param name="other">The other key.</param>
        /// <returns></returns>
        protected bool Equals(Key other)
        {
            return Id == other.Id;
        }
    }
}