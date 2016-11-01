using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.MiddleFinger
{
    internal class RightMiddleFinger : IFinger
    {
        public IRightMiddleFingerKeyState D8KeyState { get; private set; }
        public IRightMiddleFingerKeyState CKeyState { get; private set; }
        public IRightMiddleFingerKeyState TKeyState { get; private set; }
        public IRightMiddleFingerKeyState WKeyState { get; private set; }

        public IRightMiddleFingerKeyState CurrentKeyState { private get; set; }

        public RightMiddleFinger()
        {
            D8KeyState = new D8KeyState(this);
            CKeyState = new CKeyState(this);
            TKeyState = new TKeyState(this);
            WKeyState = new WKeyState(this);

            CurrentKeyState = TKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = TKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D8:
                    return CurrentKeyState.PressD8();
                case Keys.C:
                    return CurrentKeyState.PressC();
                case Keys.T:
                    return CurrentKeyState.PressT();
                case Keys.W:
                    return CurrentKeyState.PressW();
                default:
                    throw new NotSupportedException(string.Format("The right middle finger can't reach this '{0}' key.", key));
            }
        }
    }
}