using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.LittleFinger
{
    internal class SKeyState : IRightLittleFingerKeyState
    {
        private readonly RightLittleFinger rightLittleFinger;

        public SKeyState(RightLittleFinger rightLittleFinger)
        {
            this.rightLittleFinger = rightLittleFinger;
        }

        public string CurrentKey
        {
            get { return "s"; }
        }

        public double PressD0()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.D0KeyState;
            return 2;
        }

        public double PressL()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.LKeyState;
            return 1;
        }

        public double PressS()
        {
            return 0;
        }

        public double PressZ()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.ZKeyState;
            return 1;
        }

        public double PressOpenSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.OpenSquareBracketKeyState;
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
            return 1;
        }

        public double PressRShift()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.RShiftKeyState;
            return 3.Sqrt();
        }

        public double PressCloseSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.CloseSquareBracketKeyState;
            return 2;
        }

        public double PressPipe()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.PipeKeyState;
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
            return 2;
        }
    }
}