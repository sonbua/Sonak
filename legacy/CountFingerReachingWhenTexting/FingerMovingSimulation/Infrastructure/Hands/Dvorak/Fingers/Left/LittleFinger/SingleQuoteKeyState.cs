using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.LittleFinger
{
    internal class SingleQuoteKeyState : ILeftLittleFingerKeyState
    {
        private readonly LeftLittleFinger leftLittleFinger;

        public SingleQuoteKeyState(LeftLittleFinger leftLittleFinger)
        {
            this.leftLittleFinger = leftLittleFinger;
        }

        public string CurrentKey
        {
            get { return "'"; }
        }

        public double PressD1()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.D1KeyState;
            return 1;
        }

        public double PressSingleQuote()
        {
            return 0;
        }

        public double PressA()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.AKeyState;
            return 1;
        }

        public double PressSemicolon()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.SemicolonKeyState;
            return 2;
        }

        public double PressLShift()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.LShiftKeyState;
            return 3.Sqrt();
        }
    }
}