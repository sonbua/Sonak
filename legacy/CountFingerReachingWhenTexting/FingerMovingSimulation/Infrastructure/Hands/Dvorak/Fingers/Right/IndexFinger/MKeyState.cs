using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.IndexFinger
{
    internal class MKeyState : IRightIndexFingerKeyState
    {
        private readonly RightIndexFinger rightIndexFinger;

        public MKeyState(RightIndexFinger rightIndexFinger)
        {
            this.rightIndexFinger = rightIndexFinger;
        }

        public string CurrentKey
        {
            get { return "m"; }
        }

        public double PressD7()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D7KeyState;
            return 3;
        }

        public double PressG()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.GKeyState;
            return 2;
        }

        public double PressH()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.HKeyState;
            return 1;
        }

        public double PressM()
        {
            return 0;
        }

        public double PressD6()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D6KeyState;
            return 13.Sqrt();
        }

        public double PressF()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.FKeyState;
            return 7.Sqrt();
        }

        public double PressD()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.DKeyState;
            return 3.Sqrt();
        }

        public double PressB()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.BKeyState;
            return 1;
        }
    }
}