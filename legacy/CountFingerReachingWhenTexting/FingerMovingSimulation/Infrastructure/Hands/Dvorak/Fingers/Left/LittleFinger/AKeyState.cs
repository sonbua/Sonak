using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.LittleFinger
{
    internal class AKeyState : ILeftLittleFingerKeyState
    {
        private readonly LeftLittleFinger leftLittleFinger;

        public AKeyState(LeftLittleFinger leftLittleFinger)
        {
            this.leftLittleFinger = leftLittleFinger;
        }

        public string CurrentKey
        {
            get { return "a"; }
        }

        public double PressD1()
        {
            return 2;
        }

        public double PressSingleQuote()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.SingleQuoteKeyState;
            return 1;
        }

        public double PressA()
        {
            return 0;
        }

        public double PressSemicolon()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.SemicolonKeyState;
            return 1;
        }

        public double PressLShift()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.LShiftKeyState;
            return 1;
        }
    }
}