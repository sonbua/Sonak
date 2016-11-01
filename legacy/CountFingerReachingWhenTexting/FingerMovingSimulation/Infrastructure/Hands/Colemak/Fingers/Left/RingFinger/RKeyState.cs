using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.RingFinger
{
    internal class RKeyState : ILeftRingFingerKeyState
    {
        private readonly LeftRingFinger leftRingFinger;

        public RKeyState(LeftRingFinger leftRingFinger)
        {
            this.leftRingFinger = leftRingFinger;
        }

        public string CurrentKey
        {
            get { return "r"; }
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

        public double PressR()
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