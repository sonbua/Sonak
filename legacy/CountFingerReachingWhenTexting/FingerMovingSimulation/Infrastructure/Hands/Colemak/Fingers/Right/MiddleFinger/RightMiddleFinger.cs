using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.MiddleFinger
{
    internal class RightMiddleFinger : IFinger
    {
        public IRightMiddleFingerKeyState D8KeyState { get; private set; }
        public IRightMiddleFingerKeyState UKeyState { get; private set; }
        public IRightMiddleFingerKeyState EKeyState { get; private set; }
        public IRightMiddleFingerKeyState CommaKeyState { get; private set; }

        public IRightMiddleFingerKeyState CurrentKeyState { private get; set; }

        public RightMiddleFinger()
        {
            D8KeyState = new D8KeyState(this);
            UKeyState = new UKeyState(this);
            EKeyState = new EKeyState(this);
            CommaKeyState = new CommaKeyState(this);

            CurrentKeyState = EKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = EKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D8:
                    return CurrentKeyState.PressD8();
                case Keys.U:
                    return CurrentKeyState.PressU();
                case Keys.E:
                    return CurrentKeyState.PressE();
                case Keys.OemComma:
                    return CurrentKeyState.PressComma();
                default:
                    throw new NotSupportedException(string.Format("The right middle finger can't reach this '{0}' key.", key));
            }
        }
    }
}