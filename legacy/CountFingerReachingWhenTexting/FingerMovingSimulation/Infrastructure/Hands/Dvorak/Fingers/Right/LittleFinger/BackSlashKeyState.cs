using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.LittleFinger
{
    internal class BackSlashKeyState : IRightLittleFingerKeyState
    {
        private readonly RightLittleFinger rightLittleFinger;

        public BackSlashKeyState(RightLittleFinger rightLittleFinger)
        {
            this.rightLittleFinger = rightLittleFinger;
        }

        public string CurrentKey
        {
            get { return "\\"; }
        }

        public double PressD0()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.D0KeyState;
            return 13.Sqrt();
        }

        public double PressL()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.LKeyState;
            return 3;
        }

        public double PressS()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SKeyState;
            return 7.Sqrt();
        }

        public double PressZ()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.ZKeyState;
            return 7.Sqrt();
        }

        public double PressOpenSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.OpenSquareBracketKeyState;
            return 7.Sqrt();
        }

        public double PressSlash()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SlashKeyState;
            return 2;
        }

        public double PressMinus()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.MinusKeyState;
            return 3.Sqrt();
        }

        public double PressRShift()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.RShiftKeyState;
            return 2;
        }

        public double PressCloseSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.CloseSquareBracketKeyState;
            return 3.Sqrt();
        }

        public double PressPipe()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.PipeKeyState;
            return 1;
        }

        public double PressBackSlash()
        {
            return 0;
        }

        public double PressEnter()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.EnterKeyState;
            return 1;
        }
    }
}