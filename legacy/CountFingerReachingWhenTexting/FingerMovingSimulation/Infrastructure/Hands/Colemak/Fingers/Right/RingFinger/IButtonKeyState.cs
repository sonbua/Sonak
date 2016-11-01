using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.RingFinger
{
    internal class IButtonKeyState : IRightRingFingerKeyState
    {
        private readonly RightRingFinger rightRingFinger;

        public IButtonKeyState(RightRingFinger rightRingFinger)
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
            return 2;
        }

        public double PressY()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.YKeyState;
            return 1;
        }

        public double PressI()
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