using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.MiddleFinger
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

        public double PressI()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.IKeyState;
            return 2;
        }

        public double PressK()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.KKeyState;
            return 1;
        }

        public double PressComma()
        {
            return 0;
        }
    }
}