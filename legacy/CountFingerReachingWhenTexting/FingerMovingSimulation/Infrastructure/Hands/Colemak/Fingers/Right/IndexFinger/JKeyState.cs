using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.IndexFinger
{
    internal class JKeyState : IRightIndexFingerKeyState
    {
        private readonly RightIndexFinger rightIndexFinger;

        public JKeyState(RightIndexFinger rightIndexFinger)
        {
            this.rightIndexFinger = rightIndexFinger;
        }

        public string CurrentKey
        {
            get { return "j"; }
        }

        public double PressD7()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.D7KeyState;
            return 1;
        }

        public double PressL()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.LKeyState;
            return 1;
        }

        public double PressN()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.NKeyState;
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

        public double PressJ()
        {
            return 0;
        }

        public double PressH()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.HKeyState;
            return 1;
        }

        public double PressK()
        {
            rightIndexFinger.CurrentKeyState = rightIndexFinger.KKeyState;
            return 2;
        }
    }
}