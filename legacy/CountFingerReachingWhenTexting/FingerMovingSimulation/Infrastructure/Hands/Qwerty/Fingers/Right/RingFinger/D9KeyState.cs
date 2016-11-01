using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.RingFinger
{
    internal class D9KeyState : IRightRingFingerKeyState
    {
        private readonly RightRingFinger rightRingFinger;

        public D9KeyState(RightRingFinger rightRingFinger)
        {
            this.rightRingFinger = rightRingFinger;
        }

        public string CurrentKey
        {
            get { return "9"; }
        }

        public double PressD9()
        {
            return 0;
        }

        public double PressO()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.OKeyState;
            return 1;
        }

        public double PressL()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.LKeyState;
            return 2;
        }

        public double PressPeriod()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.PeriodKeyState;
            return 3;
        }
    }
}