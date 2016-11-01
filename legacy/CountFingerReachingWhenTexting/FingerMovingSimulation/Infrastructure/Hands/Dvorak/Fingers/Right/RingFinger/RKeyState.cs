using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.RingFinger
{
    internal class RKeyState : IRightRingFingerKeyState
    {
        private readonly RightRingFinger rightRingFinger;

        public RKeyState(RightRingFinger rightRingFinger)
        {
            this.rightRingFinger = rightRingFinger;
        }

        public string CurrentKey
        {
            get { return "r"; }
        }

        public double PressD9()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.D9KeyState;
            return 1;
        }

        public double PressR()
        {
            return 0;
        }

        public double PressN()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.NKeyState;
            return 1;
        }

        public double PressV()
        {
            rightRingFinger.CurrentKeyState = rightRingFinger.VKeyState;
            return 2;
        }
    }
}