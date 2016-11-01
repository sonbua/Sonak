using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.RingFinger
{
    internal class RightRingFinger : IFinger
    {
        public IRightRingFingerKeyState D9KeyState { get; private set; }
        public IRightRingFingerKeyState YKeyState { get; private set; }
        public IRightRingFingerKeyState IButtonKeyState { get; private set; }
        public IRightRingFingerKeyState PeriodKeyState { get; private set; }

        public IRightRingFingerKeyState CurrentKeyState { private get; set; }

        public RightRingFinger()
        {
            D9KeyState = new D9KeyState(this);
            YKeyState = new YKeyState(this);
            IButtonKeyState = new IButtonKeyState(this);
            PeriodKeyState = new PeriodKeyState(this);

            CurrentKeyState = IButtonKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = IButtonKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D9:
                    return CurrentKeyState.PressD9();
                case Keys.Y:
                    return CurrentKeyState.PressY();
                case Keys.I:
                    return CurrentKeyState.PressI();
                case Keys.OemPeriod:
                    return CurrentKeyState.PressPeriod();
                default:
                    throw new NotSupportedException(string.Format("The right ring finger can't reach this '{0}' key.", key));
            }
        }
    }
}