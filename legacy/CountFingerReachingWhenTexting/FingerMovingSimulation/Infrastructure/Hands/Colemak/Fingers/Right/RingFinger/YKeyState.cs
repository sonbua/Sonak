using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.RingFinger
{
    internal class YKeyState : IRightRingFingerKeyState
    {
        private readonly RightRingFinger rightRingFinger;

        public YKeyState(RightRingFinger rightRingFinger)
        {
            this.rightRingFinger = rightRingFinger;
        }

        public string CurrentKey
        {
            get { return "y"; }
        }

        public double PressD9()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.D9KeyState;
            return 1;
        }

        public double PressY()
        {
            return 0;
        }

        public double PressI()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.IButtonKeyState;
            return 1;
        }

        public double PressPeriod()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.PeriodKeyState;
            return 2;
        }
    }
}