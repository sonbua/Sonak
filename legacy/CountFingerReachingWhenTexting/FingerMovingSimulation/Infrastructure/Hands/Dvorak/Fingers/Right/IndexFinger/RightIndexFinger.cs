using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.IndexFinger
{
    internal class RightIndexFinger : IFinger
    {
        public IRightIndexFingerKeyState D7KeyState { get; private set; }
        public IRightIndexFingerKeyState GKeyState { get; private set; }
        public IRightIndexFingerKeyState HKeyState { get; private set; }
        public IRightIndexFingerKeyState MKeyState { get; private set; }
        public IRightIndexFingerKeyState D6KeyState { get; private set; }
        public IRightIndexFingerKeyState FKeyState { get; private set; }
        public IRightIndexFingerKeyState DKeyState { get; private set; }
        public IRightIndexFingerKeyState BKeyState { get; private set; }

        public IRightIndexFingerKeyState CurrentKeyState { private get; set; }

        public RightIndexFinger()
        {
            D7KeyState = new D7KeyState(this);
            GKeyState = new GKeyState(this);
            HKeyState = new HKeyState(this);
            MKeyState = new MKeyState(this);
            D6KeyState = new D6KeyState(this);
            FKeyState = new FKeyState(this);
            DKeyState = new DKeyState(this);
            BKeyState = new BKeyState(this);

            CurrentKeyState = HKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = HKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D7:
                    return CurrentKeyState.PressD7();
                case Keys.G:
                    return CurrentKeyState.PressG();
                case Keys.H:
                    return CurrentKeyState.PressH();
                case Keys.M:
                    return CurrentKeyState.PressM();
                case Keys.D6:
                    return CurrentKeyState.PressD6();
                case Keys.F:
                    return CurrentKeyState.PressF();
                case Keys.D:
                    return CurrentKeyState.PressD();
                case Keys.B:
                    return CurrentKeyState.PressB();
                default:
                    throw new NotSupportedException(string.Format("The right index finger can't reach this '{0}' key.", key));
            }
        }
    }
}