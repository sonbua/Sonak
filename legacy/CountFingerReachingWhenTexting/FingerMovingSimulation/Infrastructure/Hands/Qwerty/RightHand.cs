using System;
using System.Collections.Generic;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.IndexFinger;
using FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.LittleFinger;
using FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.MiddleFinger;
using FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.RingFinger;
using FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.Thumb;
using FingerMovingSimulation.Infrastructure.Layouts;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty
{
    internal class RightHand : IHand
    {
        private readonly IFinger rightIndexFinger;
        private readonly IFinger rightLittleFinger;
        private readonly IFinger rightMiddleFinger;
        private readonly IFinger rightRingFinger;
        private readonly IFinger rightThumb;
        private readonly List<IFinger> allFingers;

        private readonly ILayout layout;

        public RightHand()
        {
            rightIndexFinger = new RightIndexFinger();
            rightLittleFinger = new RightLittleFinger();
            rightMiddleFinger = new RightMiddleFinger();
            rightRingFinger = new RightRingFinger();
            rightThumb = new RightThumb();
            allFingers = new List<IFinger>
                         {
                             rightThumb,
                             rightIndexFinger,
                             rightMiddleFinger,
                             rightRingFinger,
                             rightLittleFinger
                         };

            layout = new QwertyLayout();
        }

        public void ReturnToHomeRow()
        {
            allFingers.ForEach(finger => finger.ReturnToHomeRow());
        }

        public double Press(Keys key)
        {
            if (key.IsIn(layout.RightThumbKeys))
            {
                return rightThumb.Press(key);
            }

            if (key.IsIn(layout.RightIndexKeys))
            {
                return rightIndexFinger.Press(key);
            }

            if (key.IsIn(layout.RightMiddleKeys))
            {
                return rightMiddleFinger.Press(key);
            }

            if (key.IsIn(layout.RightRingKeys))
            {
                return rightRingFinger.Press(key);
            }

            if (key.IsIn(layout.RightLittleKeys))
            {
                return rightLittleFinger.Press(key);
            }

            throw new NotSupportedException(string.Format("The right hand can't reach this '{0}' key.", key));
        }
    }
}