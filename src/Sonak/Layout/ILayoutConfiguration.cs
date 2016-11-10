using System.Collections.Generic;

namespace Sonak.Layout
{
    /// <summary>
    /// Store the configuration of a specific layout.
    /// </summary>
    public interface ILayoutConfiguration
    {
        /// <summary>
        /// This is a dictionary that holds a map of key combo to keyboard signal.
        /// E.g.: on a US-International QWERTY layout, we will have
        /// KeyID_29 => 'a'-signal
        /// Shift + KeyID_29 => 'A'-signal
        /// Backspace => BackspaceCommandSignal, that holds no data
        /// </summary>
        IReadOnlyDictionary<KeyCombo, ISignal> KeyComboToSignalMap { get; }
    }
}