using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.MiddleFinger
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

        public double PressI()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.IKeyState;
            return 1;
        }

        public double PressK()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.KKeyState;
            return 2;
        }

        public double PressComma()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.CommaKeyState;
            return 3;
        }
    }
}