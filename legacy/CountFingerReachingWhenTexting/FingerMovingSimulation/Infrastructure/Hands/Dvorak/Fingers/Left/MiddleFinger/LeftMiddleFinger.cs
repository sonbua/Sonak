using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.MiddleFinger
{
    internal class LeftMiddleFinger : IFinger
    {
        public ILeftMiddleFingerKeyState D3KeyState { get; private set; }
        public ILeftMiddleFingerKeyState PeriodKeyState { get; private set; }
        public ILeftMiddleFingerKeyState EKeyState { get; private set; }
        public ILeftMiddleFingerKeyState JKeyState { get; private set; }

        public ILeftMiddleFingerKeyState CurrentKeyState { private get; set; }

        public LeftMiddleFinger()
        {

            D3KeyState = new D3KeyState(this);
            PeriodKeyState = new PeriodKeyState(this);
            EKeyState = new EKeyState(this);
            JKeyState = new JKeyState(this);

            CurrentKeyState = EKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = EKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D3:
                    return CurrentKeyState.PressD3();
                case Keys.OemPeriod:
                    return CurrentKeyState.PressPeriod();
                case Keys.E:
                    return CurrentKeyState.PressE();
                case Keys.J:
                    return CurrentKeyState.PressJ();
            }

            throw new NotSupportedException(string.Format("The left middle finger can't reach this '{0}' key.", key));
        }
    }
}