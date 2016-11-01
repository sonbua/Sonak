using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.IndexFinger
{
    internal class D5KeyState : ILeftIndexFingerKeyState
    {
        private readonly LeftIndexFinger leftIndexFinger;

        public D5KeyState(LeftIndexFinger leftIndexFinger)
        {
            this.leftIndexFinger = leftIndexFinger;
        }

        public string CurrentKey
        {
            get { return "5"; }
        }

        public double PressD4()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D4KeyState;
            return 1;
        }

        public double PressP()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.PKeyState;
            return 1;
        }

        public double PressU()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.UKeyState;
            return 3.Sqrt();
        }

        public double PressK()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.KKeyState;
            return 7.Sqrt();
        }

        public double PressD5()
        {
            return 0;
        }

        public double PressY()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.YKeyState;
            return 1;
        }

        public double PressI()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.IKeyState;
            return 2;
        }

        public double PressX()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.XKeyState;
            return 3;
        }
    }
}