using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.LittleFinger
{
    internal class LShiftKeyState : ILeftLittleFingerKeyState
    {
        private readonly LeftLittleFinger leftLittleFinger;

        public LShiftKeyState(LeftLittleFinger leftLittleFinger)
        {
            this.leftLittleFinger = leftLittleFinger;
        }

        public string CurrentKey
        {
            get { return "[lshift]"; }
        }

        public double PressD1()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.D1KeyState;
            return 7.Sqrt();
        }

        public double PressQ()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.QKeyState;
            return 3.Sqrt();
        }

        public double PressA()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.AKeyState;
            return 1;
        }

        public double PressZ()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.ZKeyState;
            return 1;
        }

        public double PressLShift()
        {
            return 0;
        }
    }
}