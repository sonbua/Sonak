using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.IndexFinger
{
    internal class D6KeyState : IRightIndexFingerKeyState
    {
        private readonly RightIndexFinger rightIndexFinger;

        public D6KeyState(RightIndexFinger rightIndexFinger)
        {
            this.rightIndexFinger = rightIndexFinger;
        }

        public string CurrentKey
        {
            get { return "6"; }
        }

        public double PressD7()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D7KeyState;
            return 1;
        }

        public double PressG()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.GKeyState;
            return 3.Sqrt();
        }

        public double PressH()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.HKeyState;
            return 7.Sqrt();
        }

        public double PressM()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.MKeyState;
            return 13.Sqrt();
        }

        public double PressD6()
        {
            return 0;
        }

        public double PressF()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.FKeyState;
            return 1;
        }

        public double PressD()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.DKeyState;
            return 2;
        }

        public double PressB()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.BKeyState;
            return 3;
        }
    }
}