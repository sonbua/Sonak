using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.MiddleFinger
{
    internal class CKeyState : ILeftMiddleFingerKeyState
    {
        private readonly LeftMiddleFinger leftMiddleFinger;

        public CKeyState(LeftMiddleFinger leftMiddleFinger)
        {
            this.leftMiddleFinger = leftMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "c"; }
        }

        public double PressD3()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.D3KeyState;
            return 3;
        }

        public double PressE()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.EKeyState;
            return 2;
        }

        public double PressD()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.DKeyState;
            return 1;
        }

        public double PressC()
        {
            return 0;
        }
    }
}