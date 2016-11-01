using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.RingFinger
{
    internal class RightRingFinger : IFinger
    {
        public IRightRingFingerKeyState D9KeyState { get; private set; }
        public IRightRingFingerKeyState RKeyState { get; private set; }
        public IRightRingFingerKeyState NKeyState { get; private set; }
        public IRightRingFingerKeyState VKeyState { get; private set; }

        public IRightRingFingerKeyState CurrentKeyState { private get; set; }

        public RightRingFinger()
        {

            D9KeyState = new D9KeyState(this);
            RKeyState = new RKeyState(this);
            NKeyState = new NKeyState(this);
            VKeyState = new VKeyState(this);

            CurrentKeyState = NKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = NKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D9:
                    return CurrentKeyState.PressD9();
                case Keys.R:
                    return CurrentKeyState.PressR();
                case Keys.N:
                    return CurrentKeyState.PressN();
                case Keys.V:
                    return CurrentKeyState.PressV();
                default:
                    throw new NotSupportedException(string.Format("The right ring finger can't reach this '{0}' key.", key));
            }
        }
    }
}