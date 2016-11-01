using System;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.LittleFinger
{
    internal class LeftLittleFinger : IFinger
    {
        public ILeftLittleFingerKeyState D1KeyState { get; private set; }
        public ILeftLittleFingerKeyState QKeyState { get; private set; }
        public ILeftLittleFingerKeyState AKeyState { get; private set; }
        public ILeftLittleFingerKeyState ZKeyState { get; private set; }
        public ILeftLittleFingerKeyState LShiftKeyState { get; private set; }

        public ILeftLittleFingerKeyState CurrentKeyState { private get; set; }

        public LeftLittleFinger()
        {
            D1KeyState = new D1KeyState(this);
            QKeyState = new QKeyState(this);
            AKeyState = new AKeyState(this);
            ZKeyState = new ZKeyState(this);
            LShiftKeyState = new LShiftKeyState(this);

            CurrentKeyState = AKeyState;
        }

        public void ReturnToHomeRow()
        {
            CurrentKeyState = AKeyState;
        }

        public double Press(Keys key)
        {
            switch (key)
            {
                case Keys.D1:
                    return CurrentKeyState.PressD1();
                case Keys.Q:
                    return CurrentKeyState.PressQ();
                case Keys.A:
                    return CurrentKeyState.PressA();
                case Keys.Z:
                    return CurrentKeyState.PressZ();
                case Keys.LShift:
                    return CurrentKeyState.PressLShift();
                default:
                    throw new NotSupportedException(string.Format("The left little finger can't reach this '{0}' key.", key));
            }
        }
    }
}