namespace Sonak
{
    /// <summary>
    /// Represent an abstraction for left and right hand.
    /// </summary>
    public abstract class Hand
    {
        /// <summary>
        /// The default constructor.
        /// </summary>
        /// <param name="description">The description to denote a left or right hand.</param>
        protected Hand(string description)
        {
            Description = description;
        }

        /// <summary>
        /// Denote a left or right hand.
        /// </summary>
        protected string Description { get; }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Hand) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode() => SonakConstants.DefaultHashCode;

        /// <summary>
        /// Tests the equality of this instance to other instance.
        /// </summary>
        /// <param name="other">The other hand.</param>
        /// <returns></returns>
        protected bool Equals(Hand other) => true;
    }
}