using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.LittleFinger
{
    internal class D1KeyState : ILeftLittleFingerKeyState
    {
        private readonly LeftLittleFinger leftLittleFinger;

        public D1KeyState(LeftLittleFinger leftLittleFinger)
        {
            this.leftLittleFinger = leftLittleFinger;
        }

        public string CurrentKey
        {
            get { return "1"; }
        }

        public double PressD1()
        {
            return 0;
        }

        public double PressSingleQuote()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.SingleQuoteKeyState;
            return 1;
        }

        public double PressA()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.AKeyState;
            return 2;
        }

        public double PressSemicolon()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.SemicolonKeyState;
            return 3;
        }

        public double PressLShift()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.LShiftKeyState;
            return 7.Sqrt();
        }
    }
}