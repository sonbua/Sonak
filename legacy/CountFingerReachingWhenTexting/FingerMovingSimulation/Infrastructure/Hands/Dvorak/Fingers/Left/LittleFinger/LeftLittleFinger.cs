using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.LittleFinger
{
    internal class LeftLittleFinger : IFinger
    {
        public ILeftLittleFingerKeyState D1KeyState { get; private set; }
        public ILeftLittleFingerKeyState SingleQuoteKeyState { get; private set; }
        public ILeftLittleFingerKeyState AKeyState { get; private set; }
        public ILeftLittleFingerKeyState SemicolonKeyState { get; private set; }
        public ILeftLittleFingerKeyState LShiftKeyState { get; private set; }

        public ILeftLittleFingerKeyState CurrentKeyState { private get; set; }

        public LeftLittleFinger()
        {

            D1KeyState = new D1KeyState(this);
            SingleQuoteKeyState = new SingleQuoteKeyState(this);
            AKeyState = new AKeyState(this);
            SemicolonKeyState = new SemicolonKeyState(this);
            LShiftKeyState = new LShiftKeyState(this);


            CurrentKeyState = AKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = AKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D1:
                    return CurrentKeyState.PressD1();
                case Keys.OemSingleQuote:
                    return CurrentKeyState.PressSingleQuote();
                case Keys.A:
                    return CurrentKeyState.PressA();
                case Keys.OemSemicolon:
                    return CurrentKeyState.PressSemicolon();
                case Keys.LShift:
                    return CurrentKeyState.PressLShift();
            }

            throw new NotSupportedException(string.Format("The left little finger can't reach this '{0}' key.", key));
        }
    }
}