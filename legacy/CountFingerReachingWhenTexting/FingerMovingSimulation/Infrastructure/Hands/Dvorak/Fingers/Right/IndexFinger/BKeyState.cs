using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.IndexFinger
{
    internal class BKeyState : IRightIndexFingerKeyState
    {
        private readonly RightIndexFinger rightIndexFinger;

        public BKeyState(RightIndexFinger rightIndexFinger)
        {
            this.rightIndexFinger = rightIndexFinger;
        }

        public string CurrentKey
        {
            get { return "b"; }
        }

        public double PressD7()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D7KeyState;
            return 7.Sqrt();
        }

        public double PressG()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.GKeyState;
            return 3.Sqrt();
        }

        public double PressH()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.HKeyState;
            return 1;
        }

        public double PressM()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.MKeyState;
            return 1;
        }

        public double PressD6()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D6KeyState;
            return 3;
        }

        public double PressF()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.FKeyState;
            return 2;
        }

        public double PressD()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.DKeyState;
            return 1;
        }

        public double PressB()
        {
            return 0;
        }
    }
}