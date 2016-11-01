using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.LittleFinger
{
    internal class LShiftKeyState : ILeftLittleFingerKeyState
    {
        private readonly LeftLittleFinger leftLittleFinger;

        public LShiftKeyState(LeftLittleFinger leftLittleFinger)
        {
            this.leftLittleFinger = leftLittleFinger;
        }

        public string CurrentKey
        {
            get { return "[lshift]"; }
        }

        public double PressD1()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.D1KeyState;
            return 7.Sqrt();
        }

        public double PressSingleQuote()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.SingleQuoteKeyState;
            return 3.Sqrt();
        }

        public double PressA()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.AKeyState;
            return 1;
        }

        public double PressSemicolon()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.SemicolonKeyState;
            return 1;
        }

        public double PressLShift()
        {
            return 0;
        }
    }
}