using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.RingFinger
{
    internal class QKeyState : ILeftRingFingerKeyState
    {
        private readonly LeftRingFinger leftRingFinger;

        public QKeyState(LeftRingFinger leftRingFinger)
        {
            this.leftRingFinger = leftRingFinger;
        }

        public string CurrentKey
        {
            get { return "q"; }
        }

        public double PressD2()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.D2KeyState;
            return 3;
        }

        public double PressComma()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.CommaKeyState;
            return 2;
        }

        public double PressO()
        {
            leftRingFinger.CurrentKeyState = leftRingFinger.OKeyState;
            return 1;
        }

        public double PressQ()
        {
            return 0;
        }
    }
}