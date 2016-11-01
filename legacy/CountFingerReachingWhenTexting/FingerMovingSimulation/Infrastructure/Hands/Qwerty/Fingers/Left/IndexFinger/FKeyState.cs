using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.IndexFinger
{
    internal class FKeyState : ILeftIndexFingerKeyState
    {
        private readonly LeftIndexFinger leftIndexFinger;

        public FKeyState(LeftIndexFinger leftIndexFinger)
        {
            this.leftIndexFinger = leftIndexFinger;
        }

        public string CurrentKey
        {
            get { return "f"; }
        }

        public double PressD4()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D4KeyState;
            return 2;
        }

        public double PressR()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.RKeyState;
            return 1;
        }

        public double PressF()
        {
            return 0;
        }

        public double PressV()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.VKeyState;
            return 1;
        }

        public double PressD5()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D5KeyState;
            return 3.Sqrt();
        }

        public double PressT()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.TKeyState;
            return 1;
        }

        public double PressG()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.GKeyState;
            return 1;
        }

        public double PressB()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.BKeyState;
            return 3.Sqrt();
        }
    }
}