using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.MiddleFinger
{
    internal class D8KeyState : IRightMiddleFingerKeyState
    {
        private readonly RightMiddleFinger rightMiddleFinger;

        public D8KeyState(RightMiddleFinger rightMiddleFinger)
        {
            this.rightMiddleFinger = rightMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "8"; }
        }

        public double PressD8()
        {
            return 0;
        }

        public double PressC()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.CKeyState;
            return 1;
        }

        public double PressT()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.TKeyState;
            return 2;
        }

        public double PressW()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.WKeyState;
            return 3;
        }
    }
}