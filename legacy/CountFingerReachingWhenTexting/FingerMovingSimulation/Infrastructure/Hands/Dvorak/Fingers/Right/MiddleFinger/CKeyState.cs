using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.MiddleFinger
{
    internal class CKeyState : IRightMiddleFingerKeyState
    {
        private readonly RightMiddleFinger rightMiddleFinger;

        public CKeyState(RightMiddleFinger rightMiddleFinger)
        {
            this.rightMiddleFinger = rightMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "c"; }
        }

        public double PressD8()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.D8KeyState;
            return 1;
        }

        public double PressC()
        {
            return 0;
        }

        public double PressT()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.TKeyState;
            return 1;
        }

        public double PressW()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.WKeyState;
            return 2;
        }
    }
}