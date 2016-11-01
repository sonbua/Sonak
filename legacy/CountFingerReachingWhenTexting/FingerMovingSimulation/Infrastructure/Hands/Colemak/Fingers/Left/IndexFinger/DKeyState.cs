using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Left.IndexFinger
{
    internal class DKeyState : ILeftIndexFingerKeyState
    {
        private readonly LeftIndexFinger leftIndexFinger;

        public DKeyState(LeftIndexFinger leftIndexFinger)
        {
            this.leftIndexFinger = leftIndexFinger;
        }

        public string CurrentKey
        {
            get { return "d"; }
        }

        public double PressD4()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D4KeyState;
            return 7.Sqrt();
        }

        public double PressP()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.PKeyState;
            return 3.Sqrt();
        }

        public double PressT()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.TKeyState;
            return 1;
        }

        public double PressV()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.VKeyState;
            return 1;
        }

        public double PressD5()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D5KeyState;
            return 2;
        }

        public double PressG()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.GKeyState;
            return 1;
        }

        public double PressD()
        {
            return 0;
        }

        public double PressB()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.BKeyState;
            return 1;
        }
    }
}