using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.MiddleFinger
{
    internal class EKeyState : ILeftMiddleFingerKeyState
    {
        private readonly LeftMiddleFinger leftMiddleFinger;

        public EKeyState(LeftMiddleFinger leftMiddleFinger)
        {
            this.leftMiddleFinger = leftMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "e"; }
        }

        public double PressD3()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.D3KeyState;
            return 1;
        }

        public double PressE()
        {
            return 0;
        }

        public double PressD()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.DKeyState;
            return 1;
        }

        public double PressC()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.CKeyState;
            return 2;
        }
    }
}