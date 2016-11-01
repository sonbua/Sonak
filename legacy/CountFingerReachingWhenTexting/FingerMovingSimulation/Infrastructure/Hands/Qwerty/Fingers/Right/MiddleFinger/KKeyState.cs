using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.MiddleFinger
{
    internal class KKeyState : IRightMiddleFingerKeyState
    {
        private readonly RightMiddleFinger rightMiddleFinger;

        public KKeyState(RightMiddleFinger rightMiddleFinger)
        {
            this.rightMiddleFinger = rightMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "k"; }
        }

        public double PressD8()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.D8KeyState;
            return 2;
        }

        public double PressI()
        {
            rightMiddleFinger.CurrentKeyState = rightMiddleFinger.IKeyState;
            return 1;
        }

        public double PressK()
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