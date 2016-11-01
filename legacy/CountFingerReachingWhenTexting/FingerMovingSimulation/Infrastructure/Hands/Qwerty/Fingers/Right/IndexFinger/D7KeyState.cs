using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Right.IndexFinger
{
    internal class D7KeyState : IRightIndexFingerKeyState
    {
        private readonly RightIndexFinger rightIndexFinger;

        public D7KeyState(RightIndexFinger rightIndexFinger)
        {
            this.rightIndexFinger = rightIndexFinger;
        }

        public string CurrentKey
        {
            get { return "7"; }
        }

        public double PressD6()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D6KeyState;
            return 1;
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

        public double PressD7()
        {
            return 0;
        }

        public double PressU()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.UKeyState;
            return 1;
        }

        public double PressJ()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.JKeyState;
            return 2;
        }

        public double PressM()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.MKeyState;
            return 3;
        }
    }
}