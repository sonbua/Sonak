using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.IndexFinger
{
    internal class HKeyState : IRightIndexFingerKeyState
    {
        private readonly RightIndexFinger rightIndexFinger;

        public HKeyState(RightIndexFinger rightIndexFinger)
        {
            this.rightIndexFinger = rightIndexFinger;
        }

        public string CurrentKey
        {
            get { return "h"; }
        }

        public double PressD7()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D7KeyState;
            return 2;
        }

        public double PressG()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.GKeyState;
            return 1;
        }

        public double PressH()
        {
            return 0;
        }

        public double PressM()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.MKeyState;
            return 1;
        }

        public double PressD6()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D6KeyState;
            return 7.Sqrt();
        }

        public double PressF()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.FKeyState;
            return 3.Sqrt();
        }

        public double PressD()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.DKeyState;
            return 1;
        }

        public double PressB()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.BKeyState;
            return 1;
        }
    }
}