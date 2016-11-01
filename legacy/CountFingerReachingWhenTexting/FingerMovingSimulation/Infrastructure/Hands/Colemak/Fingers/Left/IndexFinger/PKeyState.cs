using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.IndexFinger
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

        public double PressT()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.TKeyState;
            return 1;
        }

        public double PressV()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.VKeyState;
            return 2;
        }

        public double PressD5()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D5KeyState;
            return 1;
        }

        public double PressG()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.GKeyState;
            return 1;
        }

        public double PressD()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.DKeyState;
            return 3.Sqrt();
        }

        public double PressB()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.BKeyState;
            return 7.Sqrt();
        }
    }
}