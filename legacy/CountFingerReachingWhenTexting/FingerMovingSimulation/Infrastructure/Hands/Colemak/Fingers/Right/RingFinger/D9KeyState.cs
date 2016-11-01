using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.RingFinger
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

        public double PressY()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.YKeyState;
            return 1;
        }

        public double PressI()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.IButtonKeyState;
            return 2;
        }

        public double PressPeriod()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.PeriodKeyState;
            return 3;
        }
    }
}