using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.IndexFinger
{
    internal class GKeyState : ILeftIndexFingerKeyState
    {
        private readonly LeftIndexFinger leftIndexFinger;

        public GKeyState(LeftIndexFinger leftIndexFinger)
        {
            this.leftIndexFinger = leftIndexFinger;
        }

        public string CurrentKey
        {
            get { return "g"; }
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

        public double PressT()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.TKeyState;
            return 1;
        }

        public double PressV()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.VKeyState;
            return 3.Sqrt();
        }

        public double PressD5()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D5KeyState;
            return 1;
        }

        public double PressG()
        {
            return 0;
        }

        public double PressD()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.DKeyState;
            return 1;
        }

        public double PressB()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.BKeyState;
            return 2;
        }
    }
}