using System;
using System.Collections.Generic;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.IndexFinger;
using FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.LittleFinger;
using FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.MiddleFinger;
using FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.RingFinger;
using FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.Thumb;
using FingerMovingSimulation.Infrastructure.Layouts;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak
{
    internal class LeftHand : IHand
    {
        private readonly IFinger leftIndexFinger;
        private readonly IFinger leftLittleFinger;
        private readonly IFinger leftMiddleFinger;
        private readonly IFinger leftRingFinger;
        private readonly IFinger leftThumb;
        private readonly List<IFinger> allFingers;

        private readonly ILayout layout;

        public LeftHand()
        {
            leftIndexFinger = new LeftIndexFinger();
            leftLittleFinger = new LeftLittleFinger();
            leftMiddleFinger = new LeftMiddleFinger();
            leftRingFinger = new LeftRingFinger();
            leftThumb = new LeftThumb();
            allFingers = new List<IFinger>
                         {
                             leftThumb,
                             leftIndexFinger,
                             leftMiddleFinger,
                             leftRingFinger,
                             leftLittleFinger
                         };

            layout = new ColemakLayout();
        }

        public void ReturnToHomeRow()
        {
            allFingers.ForEach(finger => finger.ReturnToHomeRow());
        }

        public double Press(Keys key)
        {
            if (key.IsIn(layout.LeftThumbKeys))
            {
                return leftThumb.Press(key);
            }

            if (key.IsIn(layout.LeftIndexKeys))
            {
                return leftIndexFinger.Press(key);
            }

            if (key.IsIn(layout.LeftMiddleKeys))
            {
                return leftMiddleFinger.Press(key);
            }

            if (key.IsIn(layout.LeftRingKeys))
            {
                return leftRingFinger.Press(key);
            }

            if (key.IsIn(layout.LeftLittleKeys))
            {
                return leftLittleFinger.Press(key);
            }

            throw new NotSupportedException(string.Format("The left hand can't reach this '{0}' key.", key));
        }
    }
}