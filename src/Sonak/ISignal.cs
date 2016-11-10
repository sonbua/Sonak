namespace Sonak
{
    /// <summary>
    /// Represents a keyboard signal sent to operating system.
    /// </summary>
    public interface ISignal
    {
        /// <summary>
        /// The signal sent to the keyboard controller.
        /// For our particular simple problem, we limit the abstraction of the signal code to be the underlying character sent to the keyboard controller.
        /// If the signal is a special command, e.g. Ctrl+Alt+Del, then the value is set to the default value of type <see cref="char"/>.
        /// </summary>
        char Code { get; }
    }
}