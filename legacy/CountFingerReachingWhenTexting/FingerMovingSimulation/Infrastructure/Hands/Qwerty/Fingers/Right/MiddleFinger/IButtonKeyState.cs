using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.MiddleFinger
{
    internal class IButtonKeyState : IRightMiddleFingerKeyState
    {
        private readonly RightMiddleFinger rightMiddleFinger;

        public IButtonKeyState(RightMiddleFinger rightMiddleFinger)
        {
            this.rightMiddleFinger = rightMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "i"; }
        }

        public double PressD8()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.D8KeyState;
            return 1;
        }

        public double PressI()
        {
            return 0;
        }

        public double PressK()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.KKeyState;
            return 1;
        }

        public double PressComma()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.CommaKeyState;
            return 2;
        }
    }
}