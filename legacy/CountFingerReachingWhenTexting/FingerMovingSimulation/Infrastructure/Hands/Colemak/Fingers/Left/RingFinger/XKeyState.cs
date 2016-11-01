using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.RingFinger
{
    internal class XKeyState : ILeftRingFingerKeyState
    {
        private readonly LeftRingFinger leftRingFinger;

        public XKeyState(LeftRingFinger leftRingFinger)
        {
            this.leftRingFinger = leftRingFinger;
        }

        public string CurrentKey
        {
            get { return "x"; }
        }

        public double PressD2()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.D2KeyState;
            return 3;
        }

        public double PressW()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.WKeyState;
            return 2;
        }

        public double PressR()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.RKeyState;
            return 1;
        }

        public double PressX()
        {
            return 0;
        }
    }
}