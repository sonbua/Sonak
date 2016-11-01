using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.RingFinger
{
    internal class LeftRingFinger : IFinger
    {
        public ILeftRingFingerKeyState D2KeyState { get; private set; }
        public ILeftRingFingerKeyState WKeyState { get; private set; }
        public ILeftRingFingerKeyState SKeyState { get; private set; }
        public ILeftRingFingerKeyState XKeyState { get; private set; }

        public ILeftRingFingerKeyState CurrentKeyState { private get; set; }

        public LeftRingFinger()
        {
            D2KeyState = new D2KeyState(this);
            SKeyState = new SKeyState(this);
            WKeyState = new WKeyState(this);
            XKeyState = new XKeyState(this);

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
                    case Keys.D2:
                    return CurrentKeyState.PressD2();
                case Keys.W:
                    return CurrentKeyState.PressW();
                case Keys.S:
                    return CurrentKeyState.PressS();
                case Keys.X:
                    return CurrentKeyState.PressX();
                default:
                    throw new NotSupportedException(string.Format("The left ring finger can't reach this '{0}' key.", key));
            }
        }
    }
}