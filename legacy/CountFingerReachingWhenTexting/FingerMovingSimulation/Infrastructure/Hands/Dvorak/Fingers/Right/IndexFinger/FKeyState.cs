using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.IndexFinger
{
    internal class FKeyState : IRightIndexFingerKeyState
    {
        private readonly RightIndexFinger rightIndexFinger;

        public FKeyState(RightIndexFinger rightIndexFinger)
        {
            this.rightIndexFinger = rightIndexFinger;
        }

        public string CurrentKey
        {
            get { return "f"; }
        }

        public double PressD7()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D7KeyState;
            return 1;
        }

        public double PressG()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.GKeyState;
            return 1;
        }

        public double PressH()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.HKeyState;
            return 3.Sqrt();
        }

        public double PressM()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.MKeyState;
            return 7.Sqrt();
        }

        public double PressD6()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D6KeyState;
            return 1;
        }

        public double PressF()
        {
            return 0;
        }

        public double PressD()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.DKeyState;
            return 1;
        }

        public double PressB()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.BKeyState;
            return 2;
        }
    }
}