using System;

namespace Sonak.Analyzer.Signals
{
    internal abstract class CommandSignal : ISignal
    {
        private const string _NO_CODE_FOR_COMMAND_SIGNAL = "There is no code for command signal. This command signal is of type {0}.";

        public char Code
        {
            get { throw new NotSupportedException(string.Format(_NO_CODE_FOR_COMMAND_SIGNAL, GetType())); }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((CommandSignal) obj);
        }

        public override int GetHashCode()
        {
            return SonakConstants.DefaultHashCode;
        }

        protected bool Equals(CommandSignal other)
        {
            return true;
        }
    }
}