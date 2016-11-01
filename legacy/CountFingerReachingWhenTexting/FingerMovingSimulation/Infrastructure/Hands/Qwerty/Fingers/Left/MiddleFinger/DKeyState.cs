using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.MiddleFinger
{
    internal class DKeyState : ILeftMiddleFingerKeyState
    {
        private readonly LeftMiddleFinger leftMiddleFinger;

        public DKeyState(LeftMiddleFinger leftMiddleFinger)
        {
            this.leftMiddleFinger = leftMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "d"; }
        }

        public double PressD3()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.D3KeyState;
            return 2;
        }

        public double PressE()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.EKeyState;
            return 1;
        }

        public double PressD()
        {
            return 0;
        }

        public double PressC()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.CKeyState;
            return 1;
        }
    }
}