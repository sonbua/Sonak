using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.IndexFinger
{
    internal class LeftIndexFinger : IFinger
    {
        public ILeftIndexFingerKeyState D4KeyState { get; private set; }
        public ILeftIndexFingerKeyState BKeyState { get; private set; }
        public ILeftIndexFingerKeyState FKeyState { get; private set; }
        public ILeftIndexFingerKeyState GKeyState { get; private set; }
        public ILeftIndexFingerKeyState D5KeyState { get; private set; }
        public ILeftIndexFingerKeyState RKeyState { get; private set; }
        public ILeftIndexFingerKeyState TKeyState { get; private set; }
        public ILeftIndexFingerKeyState VKeyState { get; private set; }

        public LeftIndexFinger()
        {
            D4KeyState = new D4KeyState(this);
            BKeyState = new BKeyState(this);
            FKeyState = new FKeyState(this);
            GKeyState = new GKeyState(this);
            D5KeyState = new D5KeyState(this);
            RKeyState = new RKeyState(this);
            TKeyState = new TKeyState(this);
            VKeyState = new VKeyState(this);

            CurrentKeyState = FKeyState;
        }

        public ILeftIndexFingerKeyState CurrentKeyState { private get; set; }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = FKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D4:
                    return CurrentKeyState.PressD4();
                case Keys.R:
                    return CurrentKeyState.PressR();
                case Keys.F:
                    return CurrentKeyState.PressF();
                case Keys.V:
                    return CurrentKeyState.PressV();
                case Keys.D5:
                    return CurrentKeyState.PressD5();
                case Keys.T:
                    return CurrentKeyState.PressT();
                case Keys.G:
                    return CurrentKeyState.PressG();
                case Keys.B:
                    return CurrentKeyState.PressB();
                default:
                    throw new NotSupportedException(string.Format("The left index finger can't reach this '{0}' key.", key));
            }
        }
    }
}