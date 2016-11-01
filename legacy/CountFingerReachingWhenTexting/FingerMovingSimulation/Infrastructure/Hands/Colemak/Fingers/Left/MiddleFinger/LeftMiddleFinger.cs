using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.MiddleFinger
{
    internal class LeftMiddleFinger : IFinger
    {
        public ILeftMiddleFingerKeyState D3KeyState { get; private set; }
        public ILeftMiddleFingerKeyState FKeyState { get; private set; }
        public ILeftMiddleFingerKeyState SKeyState { get; private set; }
        public ILeftMiddleFingerKeyState CKeyState { get; private set; }

        public ILeftMiddleFingerKeyState CurrentKeyState { private get; set; }

        public LeftMiddleFinger()
        {
            D3KeyState = new D3KeyState(this);
            FKeyState = new FKeyState(this);
            SKeyState = new SKeyState(this);
            CKeyState = new CKeyState(this);

            CurrentKeyState = SKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = SKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D3:
                    return CurrentKeyState.PressD3();
                case Keys.F:
                    return CurrentKeyState.PressF();
                case Keys.S:
                    return CurrentKeyState.PressS();
                case Keys.C:
                    return CurrentKeyState.PressC();
                default:
                    throw new NotSupportedException(string.Format("The left middle finger can't reach this '{0}' key.", key));
            }
        }
    }
}