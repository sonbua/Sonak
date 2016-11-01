using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.MiddleFinger
{
    internal class WKeyState : IRightMiddleFingerKeyState
    {
        private readonly RightMiddleFinger rightMiddleFinger;

        public WKeyState(RightMiddleFinger rightMiddleFinger)
        {
            this.rightMiddleFinger = rightMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "w"; }
        }

        public double PressD8()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.D8KeyState;
            return 3;
        }

        public double PressC()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.CKeyState;
            return 2;
        }

        public double PressT()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.TKeyState;
            return 1;
        }

        public double PressW()
        {
            return 0;
        }
    }
}