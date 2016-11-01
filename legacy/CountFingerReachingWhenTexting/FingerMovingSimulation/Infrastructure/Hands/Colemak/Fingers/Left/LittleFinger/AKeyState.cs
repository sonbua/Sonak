using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.LittleFinger
{
    internal class AKeyState : ILeftLittleFingerKeyState
    {
        private readonly LeftLittleFinger leftLittleFinger;

        public AKeyState(LeftLittleFinger leftLittleFinger)
        {
            this.leftLittleFinger = leftLittleFinger;
        }

        public string CurrentKey
        {
            get { return "a"; }
        }

        public double PressD1()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.D1KeyState;
            return 2;
        }

        public double PressQ()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.QKeyState;
            return 1;
        }

        public double PressA()
        {
            return 0;
        }

        public double PressZ()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.ZKeyState;
            return 1;
        }

        public double PressLShift()
        {
            leftLittleFinger.CurrentKeyState = leftLittleFinger.LShiftKeyState;
            return 1;
        }
    }
}