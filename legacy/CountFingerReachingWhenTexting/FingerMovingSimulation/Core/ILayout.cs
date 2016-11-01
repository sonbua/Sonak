using System.Collections.Generic;

namespace FingerMovingSimulation.Core
{
    internal interface ILayout
    {
        IEnumerable<Keys> LeftHandKeys { get; }

        IEnumerable<Keys> RightHandKeys { get; }

        IEnumerable<Keys> LeftThumbKeys { get; }

        IEnumerable<Keys> LeftIndexKeys { get; }

        IEnumerable<Keys> LeftMiddleKeys { get; }

        IEnumerable<Keys> LeftRingKeys { get; }

        IEnumerable<Keys> LeftLittleKeys { get; }

        IEnumerable<Keys> RightThumbKeys { get; }

        IEnumerable<Keys> RightIndexKeys { get; }

        IEnumerable<Keys> RightMiddleKeys { get; }

        IEnumerable<Keys> RightRingKeys { get; }

        IEnumerable<Keys> RightLittleKeys { get; }
    }
}