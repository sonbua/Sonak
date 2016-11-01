using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.MiddleFinger
{
    internal class TKeyState : IRightMiddleFingerKeyState
    {
        private readonly RightMiddleFinger rightMiddleFinger;

        public TKeyState(RightMiddleFinger rightMiddleFinger)
        {
            this.rightMiddleFinger = rightMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "t"; }
        }

        public double PressD8()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.D8KeyState;
            return 2;
        }

        public double PressC()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.CKeyState;
            return 1;
        }

        public double PressT()
        {
            return 0;
        }

        public double PressW()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.WKeyState;
            return 1;
        }
    }
}