using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.RingFinger
{
    internal class VKeyState : IRightRingFingerKeyState
    {
        private readonly RightRingFinger rightRingFinger;

        public VKeyState(RightRingFinger rightRingFinger)
        {
            this.rightRingFinger = rightRingFinger;
        }

        public string CurrentKey
        {
            get { return "v"; }
        }

        public double PressD9()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.D9KeyState;
            return 3;
        }

        public double PressR()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.RKeyState;
            return 2;
        }

        public double PressN()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.NKeyState;
            return 1;
        }

        public double PressV()
        {
            return 0;
        }
    }
}