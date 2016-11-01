using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.RingFinger
{
    internal class WKeyState : ILeftRingFingerKeyState
    {
        private readonly LeftRingFinger leftRingFinger;

        public WKeyState(LeftRingFinger leftRingFinger)
        {
            this.leftRingFinger = leftRingFinger;
        }

        public string CurrentKey
        {
            get { return "w"; }
        }

        public double PressD2()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.D2KeyState;
            return 1;
        }

        public double PressW()
        {
            return 0;
        }

        public double PressS()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.SKeyState;
            return 1;
        }

        public double PressX()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.XKeyState;
            return 2;
        }
    }
}