using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.LittleFinger
{
    internal class D0KeyState : IRightLittleFingerKeyState
    {
        private readonly RightLittleFinger rightLittleFinger;

        public D0KeyState(RightLittleFinger rightLittleFinger)
        {
            this.rightLittleFinger = rightLittleFinger;
        }

        public string CurrentKey
        {
            get { return "0"; }
        }

        public double PressD0()
        {
            return 0;
        }

        public double PressL()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.LKeyState;
            return 1;
        }

        public double PressS()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SKeyState;
            return 2;
        }

        public double PressZ()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.ZKeyState;
            return 3;
        }

        public double PressOpenSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.OpenSquareBracketKeyState;
            return 1;
        }

        public double PressSlash()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.SlashKeyState;
            return 3.Sqrt();
        }

        public double PressMinus()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.MinusKeyState;
            return 7.Sqrt();
        }

        public double PressRShift()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.RShiftKeyState;
            return 13.Sqrt();
        }

        public double PressCloseSquareBracket()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.CloseSquareBracketKeyState;
            return 2;
        }

        public double PressPipe()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.PipeKeyState;
            return 7.Sqrt();
        }

        public double PressBackSlash()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.BackSlashKeyState;
            return 13.Sqrt();
        }

        public double PressEnter()
        {
            rightLittleFinger.CurrentKeyState = rightLittleFinger.EnterKeyState;
            return 2*3.Sqrt();
        }
    }
}