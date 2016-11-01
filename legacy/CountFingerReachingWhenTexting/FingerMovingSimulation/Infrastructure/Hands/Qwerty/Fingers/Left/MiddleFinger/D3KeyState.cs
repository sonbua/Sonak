using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.MiddleFinger
{
    internal class D3KeyState : ILeftMiddleFingerKeyState
    {
        private readonly LeftMiddleFinger leftMiddleFinger;

        public D3KeyState(LeftMiddleFinger leftMiddleFinger)
        {
            this.leftMiddleFinger = leftMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "3"; }
        }

        public double PressD3()
        {
            return 0;
        }

        public double PressE()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.EKeyState;
            return 1;
        }

        public double PressD()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.DKeyState;
            return 2;
        }

        public double PressC()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.CKeyState;
            return 3;
        }
    }
}