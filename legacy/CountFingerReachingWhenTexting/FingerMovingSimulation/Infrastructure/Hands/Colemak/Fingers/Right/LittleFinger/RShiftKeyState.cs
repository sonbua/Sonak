using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.LittleFinger
{
    internal class RShiftKeyState : IRightLittleFingerKeyState
    {
        private readonly RightLittleFinger rightLittleFinger;

        public RShiftKeyState(RightLittleFinger rightLittleFinger)
        {
            this.rightLittleFinger = rightLittleFinger;
        }

        public string CurrentKey
        {
            get { return "[rshift]"; }
        }

        public double PressD0()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.RShiftKeyState;
            return 13.Sqrt();
        }

        public double PressSemicolon()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SemicolonKeyState;
            return 7.Sqrt();
        }

        public double PressO()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.OKeyState;
            return 3.Sqrt();
        }

        public double PressSlash()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SlashKeyState;
            return 1;
        }

        public double PressMinus()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.MinusKeyState;
            return 3;
        }

        public double PressOpenSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.OpenSquareBracketKeyState;
            return 2;
        }

        public double PressSingleQuote()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SingleQuoteKeyState;
            return 1;
        }

        public double PressRShift()
        {
            return 0;
        }

        public double PressPipe()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.PipeKeyState;
            return 7.Sqrt();
        }

        public double PressCloseSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.CloseSquareBracketKeyState;
            return 3.Sqrt();
        }

        public double PressBackSlash()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.BackSlashKeyState;
            return 2;
        }

        public double PressEnter()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.EnterKeyState;
            return 1;
        }
    }
}