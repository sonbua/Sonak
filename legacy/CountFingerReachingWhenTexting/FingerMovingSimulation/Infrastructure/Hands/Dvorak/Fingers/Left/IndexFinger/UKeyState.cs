using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Left.IndexFinger
{
    internal class UKeyState : ILeftIndexFingerKeyState
    {
        private readonly LeftIndexFinger leftIndexFinger;

        public UKeyState(LeftIndexFinger leftIndexFinger)
        {
            this.leftIndexFinger = leftIndexFinger;
        }

        public string CurrentKey
        {
            get { return "u"; }
        }

        public double PressD4()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D4KeyState;
            return 2;
        }

        public double PressP()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.PKeyState;
            return 1;
        }

        public double PressU()
        {
            return 0;
        }

        public double PressK()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.KKeyState;
            return 1;
        }

        public double PressD5()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D5KeyState;
            return 3.Sqrt();
        }

        public double PressY()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.YKeyState;
            return 1;
        }

        public double PressI()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.IKeyState;
            return 1;
        }

        public double PressX()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.XKeyState;
            return 3.Sqrt();
        }
    }
}