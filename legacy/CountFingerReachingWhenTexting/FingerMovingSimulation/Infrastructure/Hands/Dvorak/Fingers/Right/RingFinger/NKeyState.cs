using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.RingFinger
{
    internal class NKeyState : IRightRingFingerKeyState
    {
        private readonly RightRingFinger rightRingFinger;

        public NKeyState(RightRingFinger rightRingFinger)
        {
            this.rightRingFinger = rightRingFinger;
        }

        public string CurrentKey
        {
            get { return "n"; }
        }

        public double PressD9()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.D9KeyState;
            return 2;
        }

        public double PressR()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.RKeyState;
            return 1;
        }

        public double PressN()
        {
            return 0;
        }

        public double PressV()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.VKeyState;
            return 1;
        }
    }
}