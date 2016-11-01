using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.MiddleFinger
{
    internal class CommaKeyState : IRightMiddleFingerKeyState
    {
        private readonly RightMiddleFinger rightMiddleFinger;

        public CommaKeyState(RightMiddleFinger rightMiddleFinger)
        {
            this.rightMiddleFinger = rightMiddleFinger;
        }

        public string CurrentKey
        {
            get { return ","; }
        }

        public double PressD8()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.D8KeyState;
            return 3;
        }

        public double PressU()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.UKeyState;
            return 2;
        }

        public double PressE()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.EKeyState;
            return 1;
        }

        public double PressComma()
        {
            return 0;
        }
    }
}