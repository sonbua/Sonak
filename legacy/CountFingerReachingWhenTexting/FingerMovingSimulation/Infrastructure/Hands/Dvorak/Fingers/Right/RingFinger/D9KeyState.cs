using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.RingFinger
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

        public double PressR()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.RKeyState;
            return 1;
        }

        public double PressN()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.NKeyState;
            return 2;
        }

        public double PressV()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.VKeyState;
            return 3;
        }
    }
}