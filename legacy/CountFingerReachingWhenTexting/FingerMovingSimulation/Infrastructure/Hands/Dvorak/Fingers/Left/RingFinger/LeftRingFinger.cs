using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.RingFinger
{
    internal class LeftRingFinger : IFinger
    {
        public ILeftRingFingerKeyState D2KeyState { get; private set; }
        public ILeftRingFingerKeyState CommaKeyState { get; private set; }
        public ILeftRingFingerKeyState OKeyState { get; private set; }
        public ILeftRingFingerKeyState QKeyState { get; private set; }

        public ILeftRingFingerKeyState CurrentKeyState { private get; set; }

        public LeftRingFinger()
        {

            D2KeyState = new D2KeyState(this);
            CommaKeyState = new CommaKeyState(this);
            OKeyState = new OKeyState(this);
            QKeyState = new QKeyState(this);

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
                case Keys.D2:
                    return CurrentKeyState.PressD2();
                case Keys.OemComma:
                    return CurrentKeyState.PressComma();
                case Keys.O:
                    return CurrentKeyState.PressO();
                case Keys.Q:
                    return CurrentKeyState.PressQ();
            }

            throw new NotSupportedException(string.Format("The left ring finger can't reach this '{0}' key.", key));
        }
    }
}