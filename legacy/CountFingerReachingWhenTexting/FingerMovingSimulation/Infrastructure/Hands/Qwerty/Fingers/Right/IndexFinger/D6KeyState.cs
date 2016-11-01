using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.IndexFinger
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

        public double PressU()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.UKeyState;
            return 3.Sqrt();
        }

        public double PressJ()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.JKeyState;
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

        public double PressY()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.YKeyState;
            return 1;
        }

        public double PressH()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.HKeyState;
            return 2;
        }

        public double PressN()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.NKeyState;
            return 3;
        }
    }
}