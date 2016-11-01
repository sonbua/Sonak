using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.IndexFinger
{
    internal class RightIndexFinger : IFinger
    {
        public IRightIndexFingerKeyState D7KeyState { get; private set; }
        public IRightIndexFingerKeyState LKeyState { get; private set; }
        public IRightIndexFingerKeyState NKeyState { get; private set; }
        public IRightIndexFingerKeyState MKeyState { get; private set; }
        public IRightIndexFingerKeyState D6KeyState { get; private set; }
        public IRightIndexFingerKeyState JKeyState { get; private set; }
        public IRightIndexFingerKeyState HKeyState { get; private set; }
        public IRightIndexFingerKeyState KKeyState { get; private set; }

        public IRightIndexFingerKeyState CurrentKeyState { private get; set; }

        public RightIndexFinger()
        {
            D7KeyState = new D7KeyState(this);
            LKeyState = new LKeyState(this);
            NKeyState = new NKeyState(this);
            MKeyState = new MKeyState(this);
            D6KeyState = new D6KeyState(this);
            JKeyState = new JKeyState(this);
            HKeyState = new HKeyState(this);
            KKeyState = new KKeyState(this);

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
                case Keys.D7:
                    return CurrentKeyState.PressD7();
                case Keys.L:
                    return CurrentKeyState.PressL();
                case Keys.N:
                    return CurrentKeyState.PressN();
                case Keys.M:
                    return CurrentKeyState.PressM();
                case Keys.D6:
                    return CurrentKeyState.PressD6();
                case Keys.J:
                    return CurrentKeyState.PressJ();
                case Keys.H:
                    return CurrentKeyState.PressH();
                case Keys.K:
                    return CurrentKeyState.PressK();
                default:
                    throw new NotSupportedException(string.Format("The right index finger can't reach this '{0}' key.", key));
            }
        }
    }
}