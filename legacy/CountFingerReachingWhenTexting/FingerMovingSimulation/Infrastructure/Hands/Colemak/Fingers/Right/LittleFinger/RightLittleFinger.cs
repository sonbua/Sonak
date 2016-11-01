using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.LittleFinger
{
    internal class RightLittleFinger : IFinger
    {
        public IRightLittleFingerKeyState D0KeyState { get; private set; }
        public IRightLittleFingerKeyState SemicolonKeyState { get; private set; }
        public IRightLittleFingerKeyState OKeyState { get; private set; }
        public IRightLittleFingerKeyState SlashKeyState { get; private set; }
        public IRightLittleFingerKeyState MinusKeyState { get; private set; }
        public IRightLittleFingerKeyState OpenSquareBracketKeyState { get; private set; }
        public IRightLittleFingerKeyState SingleQuoteKeyState { get; private set; }
        public IRightLittleFingerKeyState RShiftKeyState { get; private set; }
        public IRightLittleFingerKeyState PipeKeyState { get; private set; }
        public IRightLittleFingerKeyState CloseSquareBracketKeyState { get; private set; }
        public IRightLittleFingerKeyState BackSlashKeyState { get; private set; }
        public IRightLittleFingerKeyState EnterKeyState { get; private set; }

        public IRightLittleFingerKeyState CurrentKeyState { private get; set; }

        public RightLittleFinger()
        {
            D0KeyState = new D0KeyState(this);
            SemicolonKeyState = new SemicolonKeyState(this);
            OKeyState = new OKeyState(this);
            SlashKeyState = new SlashKeyState(this);
            MinusKeyState = new MinusKeyState(this);
            OpenSquareBracketKeyState = new OpenSquareBracketKeyState(this);
            SingleQuoteKeyState = new SingleQuoteKeyState(this);
            RShiftKeyState = new RShiftKeyState(this);
            PipeKeyState = new PipeKeyState(this);
            CloseSquareBracketKeyState = new CloseSquareBracketKeyState(this);
            BackSlashKeyState = new BackSlashKeyState(this);
            EnterKeyState = new EnterKeyState();

            CurrentKeyState = OKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = OKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D0:
                    return CurrentKeyState.PressD0();
                case Keys.OemSemicolon:
                    return CurrentKeyState.PressSemicolon();
                case Keys.O:
                    return CurrentKeyState.PressO();
                case Keys.OemSlash:
                    return CurrentKeyState.PressSlash();
                case Keys.OemMinus:
                    return CurrentKeyState.PressMinus();
                case Keys.OemOpenSquareBracket:
                    return CurrentKeyState.PressOpenSquareBracket();
                case Keys.OemSingleQuote:
                    return CurrentKeyState.PressSingleQuote();
                case Keys.RShift:
                    return CurrentKeyState.PressRShift();
                case Keys.OemPipe:
                    return CurrentKeyState.PressPipe();
                case Keys.OemCloseSquareBracket:
                    return CurrentKeyState.PressCloseSquareBracket();
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