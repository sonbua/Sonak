using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sonak
{
    /// <summary>
    /// Represent a combination of key presses.
    /// Example: a key combo Ctrl+Shift+A
    /// Primary key = A
    /// Modifier keys = Ctrl, Shift
    /// </summary>
    public class KeyCombo
    {
        /// <summary>
        /// The default constructor.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <param name="modifierKeys">The modifier keys.</param>
        public KeyCombo(Key primaryKey, IEnumerable<Key> modifierKeys)
        {
            if (modifierKeys == null)
                throw new ArgumentNullException(nameof(modifierKeys));

            PrimaryKey = primaryKey;
            ModifierKeys = new ReadOnlyCollection<Key>(modifierKeys.ToArray());
        }

        /// <summary>
        /// The primary key in a combination.
        /// </summary>
        public Key PrimaryKey { get; }

        /// <summary>
        /// The modifier keys in a combination.
        /// </summary>
        public IReadOnlyCollection<Key> ModifierKeys { get; }

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
            unchecked
            {
                return ((PrimaryKey?.GetHashCode() ?? 0)*397) ^ (ModifierKeys?.GetHashCode() ?? 0);
            }
        }

        /// <summary>
        /// Tests the equality of this instance to other instance.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        protected bool Equals(KeyCombo other)
        {
            return Equals(PrimaryKey, other.PrimaryKey) && EqualsImpl(ModifierKeys, other.ModifierKeys);
        }

        private static bool EqualsImpl(IReadOnlyCollection<Key> keys, IReadOnlyCollection<Key> otherKeys)
        {
            return keys.Count == otherKeys.Count
                   && keys.OrderBy(x => x.Id).SequenceEqual(otherKeys.OrderBy(x => x.Id));
        }
    }
}