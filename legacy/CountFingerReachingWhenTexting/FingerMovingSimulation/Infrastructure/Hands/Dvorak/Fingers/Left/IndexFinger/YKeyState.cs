using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.IndexFinger
{
    internal class YKeyState : ILeftIndexFingerKeyState
    {
        private readonly LeftIndexFinger leftIndexFinger;

        public YKeyState(LeftIndexFinger leftIndexFinger)
        {
            this.leftIndexFinger = leftIndexFinger;
        }

        public string CurrentKey
        {
            get { return "y"; }
        }

        public double PressD4()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D4KeyState;
            return 3.Sqrt();
        }

        public double PressP()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.PKeyState;
            return 1;
        }

        public double PressU()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.UKeyState;
            return 1;
        }

        public double PressK()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.KKeyState;
            return 3.Sqrt();
        }

        public double PressD5()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D5KeyState;
            return 1;
        }

        public double PressY()
        {
            return 0;
        }

        public double PressI()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.IKeyState;
            return 1;
        }

        public double PressX()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.XKeyState;
            return 2;
        }
    }
}