using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.LittleFinger
{
    internal class SlashKeyState : IRightLittleFingerKeyState
    {
        private readonly RightLittleFinger rightLittleFinger;

        public SlashKeyState(RightLittleFinger rightLittleFinger)
        {
            this.rightLittleFinger = rightLittleFinger;
        }

        public string CurrentKey
        {
            get { return "/"; }
        }

        public double PressD0()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.D0KeyState;
            return 3;
        }

        public double PressP()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.PKeyState;
            return 2;
        }

        public double PressSemicolon()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SemicolonKeyState;
            return 1;
        }

        public double PressSlash()
        {
            return 0;
        }

        public double PressMinus()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.MinusKeyState;
            return 7.Sqrt();
        }

        public double PressOpenSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.OpenSquareBracketKeyState;
            return 3.Sqrt();
        }

        public double PressSingleQuote()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SingleQuoteKeyState;
            return 1;
        }

        public double PressRShift()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.RShiftKeyState;
            return 1;
        }

        public double PressPipe()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.PipeKeyState;
            return 7.Sqrt();
        }

        public double PressCloseSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.CloseSquareBracketKeyState;
            return 2;
        }

        public double PressBackSlash()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.BackSlashKeyState;
            return 7.Sqrt();
        }

        public double PressEnter()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.EnterKeyState;
            return 3.Sqrt();
        }
    }
}