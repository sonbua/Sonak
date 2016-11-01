using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.RingFinger
{
    internal class OKeyState : ILeftRingFingerKeyState
    {
        private readonly LeftRingFinger leftRingFinger;

        public OKeyState(LeftRingFinger leftRingFinger)
        {
            this.leftRingFinger = leftRingFinger;
        }

        public string CurrentKey
        {
            get { return "o"; }
        }

        public double PressD2()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.D2KeyState;
            return 2;
        }

        public double PressComma()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.CommaKeyState;
            return 1;
        }

        public double PressO()
        {
            return 0;
        }

        public double PressQ()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.QKeyState;
            return 1;
        }
    }
}