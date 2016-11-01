using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.RingFinger
{
    internal class OKeyState : IRightRingFingerKeyState
    {
        private readonly RightRingFinger rightRingFinger;

        public OKeyState(RightRingFinger rightRingFinger)
        {
            this.rightRingFinger = rightRingFinger;
        }

        public string CurrentKey
        {
            get { return "o"; }
        }

        public double PressD9()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.D9KeyState;
            return 1;
        }

        public double PressO()
        {
            return 0;
        }

        public double PressL()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.LKeyState;
            return 1;
        }

        public double PressPeriod()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.PeriodKeyState;
            return 2;
        }
    }
}