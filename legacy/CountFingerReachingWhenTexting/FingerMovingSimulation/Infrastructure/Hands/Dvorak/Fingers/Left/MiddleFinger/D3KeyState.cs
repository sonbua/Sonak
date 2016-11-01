using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.MiddleFinger
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

        public double PressPeriod()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.PeriodKeyState;
            return 1;
        }

        public double PressE()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.EKeyState;
            return 2;
        }

        public double PressJ()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.JKeyState;
            return 3;
        }
    }
}