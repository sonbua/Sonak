using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.IndexFinger
{
    internal class KKeyState : ILeftIndexFingerKeyState
    {
        private readonly LeftIndexFinger leftIndexFinger;

        public KKeyState(LeftIndexFinger leftIndexFinger)
        {
            this.leftIndexFinger = leftIndexFinger;
        }

        public string CurrentKey
        {
            get { return "k"; }
        }

        public double PressD4()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D4KeyState;
            return 3;
        }

        public double PressP()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.PKeyState;
            return 2;
        }

        public double PressU()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.UKeyState;
            return 1;
        }

        public double PressK()
        {
            return 0;
        }

        public double PressD5()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D5KeyState;
            return 7.Sqrt();
        }

        public double PressY()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.YKeyState;
            return 3.Sqrt();
        }

        public double PressI()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.IKeyState;
            return 1;
        }

        public double PressX()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.XKeyState;
            return 1;
        }
    }
}