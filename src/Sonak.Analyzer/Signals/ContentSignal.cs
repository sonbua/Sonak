namespace Sonak.Analyzer.Signals
{
    /// <summary>
    /// Represents a signal that hold data, e.g. 'a', 'A', etc.
    /// </summary>
    internal class ContentSignal : ISignal
    {
        public ContentSignal(char code)
        {
            Code = code;
        }

        public char Code { get; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((ContentSignal) obj);
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        protected bool Equals(ContentSignal other)
        {
            return Code == other.Code;
        }
    }
}