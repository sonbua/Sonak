using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.IndexFinger
{
    internal class PKeyState : ILeftIndexFingerKeyState
    {
        private readonly LeftIndexFinger leftIndexFinger;

        public PKeyState(LeftIndexFinger leftIndexFinger)
        {
            this.leftIndexFinger = leftIndexFinger;
        }

        public string CurrentKey
        {
            get { return "p"; }
        }

        public double PressD4()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D4KeyState;
            return 1;
        }

        public double PressP()
        {
            return 0;
        }

        public double PressU()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.UKeyState;
            return 1;
        }

        public double PressK()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.KKeyState;
            return 2;
        }

        public double PressD5()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D5KeyState;
            return 1;
        }

        public double PressY()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.YKeyState;
            return 1;
        }

        public double PressI()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.IKeyState;
            return 3.Sqrt();
        }

        public double PressX()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.XKeyState;
            return 7.Sqrt();
        }
    }
}