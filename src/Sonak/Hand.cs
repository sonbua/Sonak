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
            return Equals((Hand) obj);
        }

        /// <summary>Serves as the default hash function. </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return SonakConstants.DefaultHashCode;
        }

        /// <summary>
        /// Tests the equality of this instance to other instance.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        protected bool Equals(Hand other)
        {
            return true;
        }
    }
}