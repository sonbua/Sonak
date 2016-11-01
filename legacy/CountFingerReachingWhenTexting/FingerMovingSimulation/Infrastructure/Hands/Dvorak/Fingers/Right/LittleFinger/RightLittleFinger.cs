using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.LittleFinger
{
    internal class RightLittleFinger : IFinger
    {
        public IRightLittleFingerKeyState D0KeyState { get; private set; }
        public IRightLittleFingerKeyState LKeyState { get; private set; }
        public IRightLittleFingerKeyState SKeyState { get; private set; }
        public IRightLittleFingerKeyState ZKeyState { get; private set; }
        public IRightLittleFingerKeyState OpenSquareBracketKeyState { get; private set; }
        public IRightLittleFingerKeyState SlashKeyState { get; private set; }
        public IRightLittleFingerKeyState MinusKeyState { get; private set; }
        public IRightLittleFingerKeyState RShiftKeyState { get; private set; }
        public IRightLittleFingerKeyState CloseSquareBracketKeyState { get; private set; }
        public IRightLittleFingerKeyState PipeKeyState { get; private set; }
        public IRightLittleFingerKeyState BackSlashKeyState { get; private set; }
        public IRightLittleFingerKeyState EnterKeyState { get; private set; }

        public IRightLittleFingerKeyState CurrentKeyState { private get; set; }

        public RightLittleFinger()
        {

            D0KeyState = new D0KeyState(this);
            LKeyState = new LKeyState(this);
            SKeyState = new SKeyState(this);
            ZKeyState = new ZKeyState(this);
            OpenSquareBracketKeyState = new OpenSquareBracketKeyState(this);
            SlashKeyState = new SlashKeyState(this);
            MinusKeyState = new MinusKeyState(this);
            RShiftKeyState = new RShiftKeyState(this);
            CloseSquareBracketKeyState = new CloseSquareBracketKeyState(this);
            PipeKeyState = new PipeKeyState(this);
            BackSlashKeyState = new BackSlashKeyState(this);
            EnterKeyState = new EnterKeyState();

            CurrentKeyState = SKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = SKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D0:
                    return CurrentKeyState.PressD0();
                case Keys.L:
                    return CurrentKeyState.PressL();
                case Keys.S:
                    return CurrentKeyState.PressS();
                case Keys.Z:
                    return CurrentKeyState.PressZ();
                case Keys.OemOpenSquareBracket:
                    return CurrentKeyState.PressOpenSquareBracket();
                case Keys.OemSlash:
                    return CurrentKeyState.PressSlash();
                case Keys.OemMinus:
                    return CurrentKeyState.PressMinus();
                case Keys.RShift:
                    return CurrentKeyState.PressRShift();
                case Keys.OemCloseSquareBracket:
                    return CurrentKeyState.PressCloseSquareBracket();
                case Keys.OemPipe:
                    return CurrentKeyState.PressPipe();
                case Keys.OemBackSlash:
                    return CurrentKeyState.PressBackSlash();
                case Keys.Enter:
                    return CurrentKeyState.PressEnter();
                default:
                    throw new NotSupportedException(string.Format("The right little finger can't reach this '{0}' key.", key));
            }
        }
    }
}