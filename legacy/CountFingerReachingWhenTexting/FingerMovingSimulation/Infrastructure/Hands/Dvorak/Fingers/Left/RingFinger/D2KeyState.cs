using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.RingFinger
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

        public double PressComma()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.CommaKeyState;
            return 1;
        }

        public double PressO()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.OKeyState;
            return 2;
        }

        public double PressQ()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.QKeyState;
            return 3;
        }
    }
}