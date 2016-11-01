using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.MiddleFinger
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

        public double PressF()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.FKeyState;
            return 2;
        }

        public double PressS()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.SKeyState;
            return 1;
        }

        public double PressC()
        {
            return 0;
        }
    }
}