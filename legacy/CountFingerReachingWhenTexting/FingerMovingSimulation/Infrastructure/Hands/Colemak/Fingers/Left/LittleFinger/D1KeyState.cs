using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.LittleFinger
{
    internal class D1KeyState : ILeftLittleFingerKeyState
    {
        private readonly LeftLittleFinger leftLittleFinger;

        public D1KeyState(LeftLittleFinger leftLittleFinger)
        {
            this.leftLittleFinger = leftLittleFinger;
        }

        public string CurrentKey
        {
            get { return "1"; }
        }

        public double PressD1()
        {
            return 0;
        }

        public double PressQ()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.QKeyState;
            return 1;
        }

        public double PressA()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.AKeyState;
            return 2;
        }

        public double PressZ()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.ZKeyState;
            return 3;
        }

        public double PressLShift()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.LShiftKeyState;
            return 7.Sqrt();
        }
    }
}