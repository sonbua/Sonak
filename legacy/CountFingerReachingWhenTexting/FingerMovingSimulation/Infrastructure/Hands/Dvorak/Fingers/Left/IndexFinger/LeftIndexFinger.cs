using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.IndexFinger
{
    internal class LeftIndexFinger : IFinger
    {
        public ILeftIndexFingerKeyState D4KeyState { get; private set; }
        public ILeftIndexFingerKeyState PKeyState { get; private set; }
        public ILeftIndexFingerKeyState UKeyState { get; private set; }
        public ILeftIndexFingerKeyState KKeyState { get; private set; }
        public ILeftIndexFingerKeyState D5KeyState { get; private set; }
        public ILeftIndexFingerKeyState YKeyState { get; private set; }
        public ILeftIndexFingerKeyState IKeyState { get; private set; }
        public ILeftIndexFingerKeyState XKeyState { get; private set; }

        public ILeftIndexFingerKeyState CurrentKeyState { private get; set; }

        public LeftIndexFinger()
        {
            D4KeyState = new D4KeyState(this);
            PKeyState = new PKeyState(this);
            UKeyState = new UKeyState(this);
            KKeyState = new KKeyState(this);
            D5KeyState = new D5KeyState(this);
            YKeyState = new YKeyState(this);
            IKeyState = new IButtonKeyState(this);
            XKeyState = new XKeyState(this);

            CurrentKeyState = UKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = UKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D4:
                    return CurrentKeyState.PressD4();
                case Keys.P:
                    return CurrentKeyState.PressP();
                case Keys.U:
                    return CurrentKeyState.PressU();
                case Keys.K:
                    return CurrentKeyState.PressK();
                case Keys.D5:
                    return CurrentKeyState.PressD5();
                case Keys.Y:
                    return CurrentKeyState.PressY();
                case Keys.I:
                    return CurrentKeyState.PressI();
                case Keys.X:
                    return CurrentKeyState.PressX();
                default:
                    throw new NotSupportedException(string.Format("The left index finger can't reach this '{0}' key.", key));
            }
        }
    }
}