using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.IndexFinger
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

        public double PressL()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.LKeyState;
            return 2;
        }

        public double PressN()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.NKeyState;
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

        public double PressJ()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.JKeyState;
            return 7.Sqrt();
        }

        public double PressH()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.HKeyState;
            return 3.Sqrt();
        }

        public double PressK()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.KKeyState;
            return 1;
        }
    }
}