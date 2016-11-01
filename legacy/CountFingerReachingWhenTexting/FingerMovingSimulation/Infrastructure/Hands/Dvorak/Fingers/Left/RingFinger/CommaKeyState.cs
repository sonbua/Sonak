using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.RingFinger
{
    internal class CommaKeyState : ILeftRingFingerKeyState
    {
        private readonly LeftRingFinger leftRingFinger;

        public CommaKeyState(LeftRingFinger leftRingFinger)
        {
            this.leftRingFinger = leftRingFinger;
        }

        public string CurrentKey
        {
            get { return ","; }
        }

        public double PressD2()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.D2KeyState;
            return 1;
        }

        public double PressComma()
        {
            return 0;
        }

        public double PressO()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.OKeyState;
            return 1;
        }

        public double PressQ()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.QKeyState;
            return 2;
        }
    }
}