using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.Thumb
{
    internal class LeftThumb : IFinger
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

            throw new NotSupportedException(string.Format("The left thumb can't reach this '{0}' key.", key));
        }
    }
}