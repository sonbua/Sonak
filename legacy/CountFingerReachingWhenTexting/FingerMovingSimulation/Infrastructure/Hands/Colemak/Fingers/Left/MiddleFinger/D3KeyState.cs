using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.MiddleFinger
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

        public double PressF()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.FKeyState;
            return 1;
        }

        public double PressS()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.SKeyState;
            return 2;
        }

        public double PressC()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.CKeyState;
            return 3;
        }
    }
}