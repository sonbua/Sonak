using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.RingFinger
{
    internal class SKeyState : ILeftRingFingerKeyState
    {
        private readonly LeftRingFinger leftRingFinger;

        public SKeyState(LeftRingFinger leftRingFinger)
        {
            this.leftRingFinger = leftRingFinger;
        }

        public string CurrentKey
        {
            get { return "s"; }
        }

        public double PressD2()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.D2KeyState;
            return 2;
        }

        public double PressW()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.WKeyState;
            return 1;
        }

        public double PressS()
        {
            return 0;
        }

        public double PressX()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.XKeyState;
            return 1;
        }
    }
}