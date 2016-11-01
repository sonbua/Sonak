using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.MiddleFinger
{
    internal class EKeyState : IRightMiddleFingerKeyState
    {
        private readonly RightMiddleFinger rightMiddleFinger;

        public EKeyState(RightMiddleFinger rightMiddleFinger)
        {
            this.rightMiddleFinger = rightMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "e"; }
        }

        public double PressD8()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.D8KeyState;
            return 2;
        }

        public double PressU()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.UKeyState;
            return 1;
        }

        public double PressE()
        {
            return 0;
        }

        public double PressComma()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.CommaKeyState;
            return 1;
        }
    }
}