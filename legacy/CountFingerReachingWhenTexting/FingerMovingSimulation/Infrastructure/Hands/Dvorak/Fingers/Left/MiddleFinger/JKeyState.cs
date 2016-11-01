using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.MiddleFinger
{
    internal class JKeyState : ILeftMiddleFingerKeyState
    {
        private readonly LeftMiddleFinger leftMiddleFinger;

        public JKeyState(LeftMiddleFinger leftMiddleFinger)
        {
            this.leftMiddleFinger = leftMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "j"; }
        }

        public double PressD3()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.D3KeyState;
            return 3;
        }

        public double PressPeriod()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.PeriodKeyState;
            return 2;
        }

        public double PressE()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.EKeyState;
            return 1;
        }

        public double PressJ()
        {
            return 0;
        }
    }
}