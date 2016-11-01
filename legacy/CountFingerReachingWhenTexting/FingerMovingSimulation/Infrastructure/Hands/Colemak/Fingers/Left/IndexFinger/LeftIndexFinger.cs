using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.IndexFinger
{
    internal class LeftIndexFinger : IFinger
    {
        public ILeftIndexFingerKeyState D4KeyState { get; private set; }
        public ILeftIndexFingerKeyState PKeyState { get; private set; }
        public ILeftIndexFingerKeyState TKeyState { get; private set; }
        public ILeftIndexFingerKeyState VKeyState { get; private set; }
        public ILeftIndexFingerKeyState D5KeyState { get; private set; }
        public ILeftIndexFingerKeyState GKeyState { get; private set; }
        public ILeftIndexFingerKeyState DKeyState { get; private set; }
        public ILeftIndexFingerKeyState BKeyState { get; private set; }

        public LeftIndexFinger()
        {
            D4KeyState = new D4KeyState(this);
            PKeyState = new PKeyState(this);
            TKeyState = new TKeyState(this);
            VKeyState = new VKeyState(this);
            D5KeyState = new D5KeyState(this);
            GKeyState = new GKeyState(this);
            DKeyState = new DKeyState(this);
            BKeyState = new BKeyState(this);

            CurrentKeyState = TKeyState;
        }

        public ILeftIndexFingerKeyState CurrentKeyState { private get; set; }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = TKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D4:
                    return CurrentKeyState.PressD4();
                case Keys.P:
                    return CurrentKeyState.PressP();
                case Keys.T:
                    return CurrentKeyState.PressT();
                case Keys.V:
                    return CurrentKeyState.PressV();
                case Keys.D5:
                    return CurrentKeyState.PressD5();
                case Keys.G:
                    return CurrentKeyState.PressG();
                case Keys.D:
                    return CurrentKeyState.PressD();
                case Keys.B:
                    return CurrentKeyState.PressB();
                default:
                    throw new NotSupportedException(string.Format("The left index finger can't reach this '{0}' key.", key));
            }
        }
    }
}