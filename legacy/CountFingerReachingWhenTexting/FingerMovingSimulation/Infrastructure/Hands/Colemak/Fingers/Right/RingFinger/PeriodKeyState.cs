using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.RingFinger
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

        public double PressY()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.YKeyState;
            return 2;
        }

        public double PressI()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.IButtonKeyState;
            return 1;
        }

        public double PressPeriod()
        {
            return 0;
        }
    }
}