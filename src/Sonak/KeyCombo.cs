using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sonak
{
    /// <summary>
    /// Represent a combination of key presses.
    /// Example: a key combo Ctrl+Shift+A
    /// </summary>
    public class KeyCombo
    {
        private const string _EMPTY_ENUMERABLE = "{0} is empty.";

        /// <summary>
        /// The default constructor.
        /// </summary>
        /// <param name="keyActions">The sequence of key actions needed to produce a certain character.</param>
        public KeyCombo(params KeyAction[] keyActions)
        {
            if (keyActions == null)
                throw new ArgumentNullException(nameof(keyActions));
            if (keyActions.Length == 0)
                throw new ArgumentException(string.Format(_EMPTY_ENUMERABLE, nameof(keyActions)));

            KeyActions = new ReadOnlyCollection<KeyAction>(keyActions);
        }

        /// <summary>
        /// The sequence of key actions needed to produce a certain character.
        /// </summary>
        public IReadOnlyCollection<KeyAction> KeyActions { get; }

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
            return Equals((KeyCombo) obj);
        }

        /// <summary>Serves as the default hash function. </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return KeyActions?.GetHashCode() ?? 0;
        }

        /// <summary>
        /// Tests the equality of this instance to other instance.
        /// </summary>
        /// <param name="other">The other object in equality test.</param>
        /// <returns></returns>
        protected bool Equals(KeyCombo other)
        {
            return KeyActions.Count == other.KeyActions.Count
                   && KeyActions.SequenceEqual(other.KeyActions);
        }
    }
}