﻿namespace Sonak.Layout
{
    /// <summary>
    /// This is just a marker interface for US-International keyboard layout. Instead of implement this interface, you can implement <see cref="ILayout"/> directly.
    /// Number row: ID = 0..13
    /// Top row: ID = 14..27
    /// Home row: 28..40
    /// Bottom row: 41..52
    /// </summary>
    public interface IUsInternationalLayout : ILayout
    {
    }
}