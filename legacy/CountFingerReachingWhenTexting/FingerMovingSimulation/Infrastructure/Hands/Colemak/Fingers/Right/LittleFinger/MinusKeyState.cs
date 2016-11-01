using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.LittleFinger
{
    internal class MinusKeyState : IRightLittleFingerKeyState
    {
        private readonly RightLittleFinger rightLittleFinger;

        public MinusKeyState(RightLittleFinger rightLittleFinger)
        {
            this.rightLittleFinger = rightLittleFinger;
        }

        public string CurrentKey
        {
            get { return "-"; }
        }

        public double PressD0()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.D0KeyState;
            return 1;
        }

        public double PressSemicolon()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SemicolonKeyState;
            return 1;
        }

        public double PressO()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.OKeyState;
            return 3.Sqrt();
        }

        public double PressSlash()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SlashKeyState;
            return 7.Sqrt();
        }

        public double PressMinus()
        {
            return 0;
        }

        public double PressOpenSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.OpenSquareBracketKeyState;
            return 1;
        }

        public double PressSingleQuote()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SingleQuoteKeyState;
            return 2;
        }

        public double PressRShift()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.RShiftKeyState;
            return 3;
        }

        public double PressPipe()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.PipeKeyState;
            return 1;
        }

        public double PressCloseSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.CloseSquareBracketKeyState;
            return 3.Sqrt();
        }

        public double PressBackSlash()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.BackSlashKeyState;
            return 7.Sqrt();
        }

        public double PressEnter()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.EnterKeyState;
            return 7.Sqrt();
        }
    }
}