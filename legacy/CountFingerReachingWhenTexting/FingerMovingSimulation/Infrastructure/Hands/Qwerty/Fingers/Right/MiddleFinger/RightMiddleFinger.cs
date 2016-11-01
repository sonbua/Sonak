using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.MiddleFinger
{
    internal class RightMiddleFinger : IFinger
    {
        public IRightMiddleFingerKeyState D8KeyState { get; private set; }
        public IRightMiddleFingerKeyState IKeyState { get; private set; }
        public IRightMiddleFingerKeyState KKeyState { get; private set; }
        public IRightMiddleFingerKeyState CommaKeyState { get; private set; }

        public IRightMiddleFingerKeyState CurrentKeyState { private get; set; }

        public RightMiddleFinger()
        {
            D8KeyState = new D8KeyState(this);
            IKeyState = new IButtonKeyState(this);
            KKeyState = new KKeyState(this);
            CommaKeyState = new CommaKeyState(this);

            CurrentKeyState = KKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = KKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D8:
                    return CurrentKeyState.PressD8();
                case Keys.I:
                    return CurrentKeyState.PressI();
                case Keys.K:
                    return CurrentKeyState.PressK();
                case Keys.OemComma:
                    return CurrentKeyState.PressComma();
                default:
                    throw new NotSupportedException(string.Format("The right middle finger can't reach this '{0}' key.", key));
            }
        }
    }
}