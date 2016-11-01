using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.IndexFinger
{
    internal class NKeyState : IRightIndexFingerKeyState
    {
        private readonly RightIndexFinger rightIndexFinger;

        public NKeyState(RightIndexFinger rightIndexFinger)
        {
            this.rightIndexFinger = rightIndexFinger;
        }

        public string CurrentKey
        {
            get { return "n"; }
        }

        public double PressD7()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D7KeyState;
            return 7.Sqrt();
        }

        public double PressU()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.UKeyState;
            return 3.Sqrt();
        }

        public double PressJ()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.JKeyState;
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

        public double PressY()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.YKeyState;
            return 2;
        }

        public double PressH()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.HKeyState;
            return 1;
        }

        public double PressN()
        {
            return 0;
        }
    }
}