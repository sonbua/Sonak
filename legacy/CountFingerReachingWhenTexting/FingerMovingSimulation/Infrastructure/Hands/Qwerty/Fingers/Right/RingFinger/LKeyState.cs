using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.RingFinger
{
    internal class LKeyState : IRightRingFingerKeyState
    {
        private readonly RightRingFinger rightRingFinger;

        public LKeyState(RightRingFinger rightRingFinger)
        {
            this.rightRingFinger = rightRingFinger;
        }

        public string CurrentKey
        {
            get { return "l"; }
        }

        public double PressD9()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.D9KeyState;
            return 2;
        }

        public double PressO()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.OKeyState;
            return 1;
        }

        public double PressL()
        {
            return 0;
        }

        public double PressPeriod()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.PeriodKeyState;
            return 1;
        }
    }
}