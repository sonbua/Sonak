using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.LittleFinger
{
    internal class ZKeyState : ILeftLittleFingerKeyState
    {
        private readonly LeftLittleFinger leftLittleFinger;

        public ZKeyState(LeftLittleFinger leftLittleFinger)
        {
            this.leftLittleFinger = leftLittleFinger;
        }

        public string CurrentKey
        {
            get { return "z"; }
        }

        public double PressD1()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.D1KeyState;
            return 3;
        }

        public double PressQ()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.QKeyState;
            return 2;
        }

        public double PressA()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.AKeyState;
            return 1;
        }

        public double PressZ()
        {
            return 0;
        }

        public double PressLShift()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.LShiftKeyState;
            return 1;
        }
    }
}