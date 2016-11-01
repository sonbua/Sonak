using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.MiddleFinger
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
            return 2;
        }

        public double PressPeriod()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.PeriodKeyState;
            return 1;
        }

        public double PressE()
        {
            return 0;
        }

        public double PressJ()
        {
            leftMiddleFinger.CurrentKeyState = leftMiddleFinger.JKeyState;
            return 1;
        }
    }
}