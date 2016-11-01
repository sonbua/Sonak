using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.IndexFinger
{
    internal class TKeyState : ILeftIndexFingerKeyState
    {
        private readonly LeftIndexFinger leftIndexFinger;

        public TKeyState(LeftIndexFinger leftIndexFinger)
        {
            this.leftIndexFinger = leftIndexFinger;
        }

        public string CurrentKey
        {
            get { return "t"; }
        }

        public double PressD4()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D4KeyState;
            return 3.Sqrt();
        }

        public double PressR()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.RKeyState;
            return 1;
        }

        public double PressF()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.FKeyState;
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

        public double PressT()
        {
            return 0;
        }

        public double PressG()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.GKeyState;
            return 1;
        }

        public double PressB()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.BKeyState;
            return 2;
        }
    }
}