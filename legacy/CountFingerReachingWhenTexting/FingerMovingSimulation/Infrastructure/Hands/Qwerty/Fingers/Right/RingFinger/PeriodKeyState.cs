using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.RingFinger
{
    internal class PeriodKeyState : IRightRingFingerKeyState
    {
        private readonly RightRingFinger rightRingFinger;

        public PeriodKeyState(RightRingFinger rightRingFinger)
        {
            this.rightRingFinger = rightRingFinger;
        }

        public string CurrentKey
        {
            get { return "."; }
        }

        public double PressD9()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.D9KeyState;
            return 3;
        }

        public double PressO()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.OKeyState;
            return 2;
        }

        public double PressL()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.LKeyState;
            return 1;
        }

        public double PressPeriod()
        {
            return 0;
        }
    }
}