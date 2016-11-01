using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.MiddleFinger
{
    internal class SKeyState : ILeftMiddleFingerKeyState
    {
        private readonly LeftMiddleFinger leftMiddleFinger;

        public SKeyState(LeftMiddleFinger leftMiddleFinger)
        {
            this.leftMiddleFinger = leftMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "s"; }
        }

        public double PressD3()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.D3KeyState;
            return 2;
        }

        public double PressF()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.FKeyState;
            return 1;
        }

        public double PressS()
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