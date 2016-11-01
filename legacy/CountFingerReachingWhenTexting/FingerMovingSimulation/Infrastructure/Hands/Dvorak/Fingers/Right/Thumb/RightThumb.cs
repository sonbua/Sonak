using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.Thumb
{
    internal class RightThumb : IFinger
    {
        public void ReturnToHomeRow()
        {
        }

        public double Press(Keys key)
        {
            if (key == Keys.Space)
            {
                return 0;
            }

            throw new NotSupportedException(string.Format("The right thumb can't reach this '{0}' key.", key));
        }
    }
}