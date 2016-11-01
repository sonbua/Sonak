using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.MiddleFinger
{
    internal class LeftMiddleFinger : IFinger
    {
        public ILeftMiddleFingerKeyState D3KeyState { get; private set; }
        public ILeftMiddleFingerKeyState EKeyState { get; private set; }
        public ILeftMiddleFingerKeyState DKeyState { get; private set; }
        public ILeftMiddleFingerKeyState CKeyState { get; private set; }

        public ILeftMiddleFingerKeyState CurrentKeyState { private get; set; }

        public LeftMiddleFinger()
        {
            D3KeyState = new D3KeyState(this);
            EKeyState = new EKeyState(this);
            DKeyState = new DKeyState(this);
            CKeyState = new CKeyState(this);

            CurrentKeyState = DKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = DKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D3:
                    return CurrentKeyState.PressD3();
                case Keys.E:
                    return CurrentKeyState.PressE();
                case Keys.D:
                    return CurrentKeyState.PressD();
                case Keys.C:
                    return CurrentKeyState.PressC();
                default:
                    throw new NotSupportedException(string.Format("The left middle finger can't reach this '{0}' key.", key));
            }
        }
    }
}