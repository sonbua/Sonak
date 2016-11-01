using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.IndexFinger
{
    internal class RightIndexFinger : IFinger
    {
        public IRightIndexFingerKeyState D7KeyState { get; private set; }
        public IRightIndexFingerKeyState UKeyState { get; private set; }
        public IRightIndexFingerKeyState JKeyState { get; private set; }
        public IRightIndexFingerKeyState MKeyState { get; private set; }
        public IRightIndexFingerKeyState D6KeyState { get; private set; }
        public IRightIndexFingerKeyState YKeyState { get; private set; }
        public IRightIndexFingerKeyState HKeyState { get; private set; }
        public IRightIndexFingerKeyState NKeyState { get; private set; }

        public IRightIndexFingerKeyState CurrentKeyState { private get; set; }

        public RightIndexFinger()
        {
            D7KeyState = new D7KeyState(this);
            UKeyState = new UKeyState(this);
            JKeyState = new JKeyState(this);
            MKeyState = new MKeyState(this);
            D6KeyState = new D6KeyState(this);
            YKeyState = new YKeyState(this);
            HKeyState = new HKeyState(this);
            NKeyState = new NKeyState(this);

            CurrentKeyState = JKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = JKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D7:
                    return CurrentKeyState.PressD7();
                case Keys.U:
                    return CurrentKeyState.PressU();
                case Keys.J:
                    return CurrentKeyState.PressJ();
                case Keys.M:
                    return CurrentKeyState.PressM();
                case Keys.D6:
                    return CurrentKeyState.PressD6();
                case Keys.Y:
                    return CurrentKeyState.PressY();
                case Keys.H:
                    return CurrentKeyState.PressH();
                case Keys.N:
                    return CurrentKeyState.PressN();
                default:
                    throw new NotSupportedException(string.Format("The right index finger can't reach this '{0}' key.", key));
            }
        }
    }
}