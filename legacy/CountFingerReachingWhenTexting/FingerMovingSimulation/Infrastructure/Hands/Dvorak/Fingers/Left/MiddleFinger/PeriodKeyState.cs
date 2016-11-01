using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.MiddleFinger
{
    internal class PeriodKeyState : ILeftMiddleFingerKeyState
    {
        private readonly LeftMiddleFinger leftMiddleFinger;

        public PeriodKeyState(LeftMiddleFinger leftMiddleFinger)
        {
            this.leftMiddleFinger = leftMiddleFinger;
        }

        public string CurrentKey
        {
            get { return "."; }
        }

        public double PressD3()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.D3KeyState;
            return 1;
        }

        public double PressPeriod()
        {
            return 0;
        }

        public double PressE()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.EKeyState;
            return 1;
        }

        public double PressJ()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.JKeyState;
            return 2;
        }
    }
}