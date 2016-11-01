using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.RingFinger
{
    internal class D2KeyState : ILeftRingFingerKeyState
    {
        private readonly LeftRingFinger leftRingFinger;

        public D2KeyState(LeftRingFinger leftRingFinger)
        {
            this.leftRingFinger = leftRingFinger;
        }

        public string CurrentKey
        {
            get { return "2"; }
        }

        public double PressD2()
        {
            return 0;
        }

        public double PressW()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.WKeyState;
            return 1;
        }

        public double PressR()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.RKeyState;
            return 2;
        }

        public double PressX()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.XKeyState;
            return 3;
        }
    }
}