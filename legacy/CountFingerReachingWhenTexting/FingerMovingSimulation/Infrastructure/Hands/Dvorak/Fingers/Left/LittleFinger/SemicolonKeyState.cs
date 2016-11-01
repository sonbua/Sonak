using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.LittleFinger
{
    internal class SemicolonKeyState : ILeftLittleFingerKeyState
    {
        private readonly LeftLittleFinger leftLittleFinger;

        public SemicolonKeyState(LeftLittleFinger leftLittleFinger)
        {
            this.leftLittleFinger = leftLittleFinger;
        }

        public string CurrentKey
        {
            get { return ";"; }
        }

        public double PressD1()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.D1KeyState;
            return 3;
        }

        public double PressSingleQuote()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.SingleQuoteKeyState;
            return 2;
        }

        public double PressA()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.AKeyState;
            return 1;
        }

        public double PressSemicolon()
        {
            return 0;
        }

        public double PressLShift()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.LShiftKeyState;
            return 1;
        }
    }
}