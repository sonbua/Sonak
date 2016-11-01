using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.RingFinger
{
    internal class RightRingFinger : IFinger
    {
        public IRightRingFingerKeyState D9KeyState { get; private set; }
        public IRightRingFingerKeyState OKeyState { get; private set; }
        public IRightRingFingerKeyState LKeyState { get; private set; }
        public IRightRingFingerKeyState PeriodKeyState { get; private set; }

        public IRightRingFingerKeyState CurrentKeyState { private get; set; }

        public RightRingFinger()
        {
            D9KeyState = new D9KeyState(this);
            OKeyState = new OKeyState(this);
            LKeyState = new LKeyState(this);
            PeriodKeyState = new PeriodKeyState(this);

            CurrentKeyState = LKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = LKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D9:
                    return CurrentKeyState.PressD9();
                case Keys.O:
                    return CurrentKeyState.PressO();
                case Keys.L:
                    return CurrentKeyState.PressL();
                case Keys.OemPeriod:
                    return CurrentKeyState.PressPeriod();
                default:
                    throw new NotSupportedException(string.Format("The right ring finger can't reach this '{0}' key.", key));
            }
        }
    }
}