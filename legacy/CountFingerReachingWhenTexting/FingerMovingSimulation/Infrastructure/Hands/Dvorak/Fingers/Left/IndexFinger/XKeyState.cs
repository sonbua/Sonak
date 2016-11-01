using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.IndexFinger
{
    internal class XKeyState : ILeftIndexFingerKeyState
    {
        private readonly LeftIndexFinger leftIndexFinger;

        public XKeyState(LeftIndexFinger leftIndexFinger)
        {
            this.leftIndexFinger = leftIndexFinger;
        }

        public string CurrentKey
        {
            get { return "x"; }
        }

        public double PressD4()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D4KeyState;
            return 13.Sqrt();
        }

        public double PressP()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.PKeyState;
            return 7.Sqrt();
        }

        public double PressU()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.UKeyState;
            return 3.Sqrt();
        }

        public double PressK()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.KKeyState;
            return 1;
        }

        public double PressD5()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D5KeyState;
            return 3;
        }

        public double PressY()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.YKeyState;
            return 2;
        }

        public double PressI()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.IKeyState;
            return 1;
        }

        public double PressX()
        {
            return 0;
        }
    }
}