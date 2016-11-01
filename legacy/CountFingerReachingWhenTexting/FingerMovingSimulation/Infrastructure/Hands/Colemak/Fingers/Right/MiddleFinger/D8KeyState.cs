using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.MiddleFinger
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

        public double PressU()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.UKeyState;
            return 1;
        }

        public double PressE()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.EKeyState;
            return 2;
        }

        public double PressComma()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.CommaKeyState;
            return 3;
        }
    }
}