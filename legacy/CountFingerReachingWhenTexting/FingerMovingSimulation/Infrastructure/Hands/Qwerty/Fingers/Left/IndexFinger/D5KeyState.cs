using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.IndexFinger
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

        public double PressR()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.RKeyState;
            return 1;
        }

        public double PressF()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.FKeyState;
            return 3.Sqrt();
        }

        public double PressV()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.VKeyState;
            return 7.Sqrt();
        }

        public double PressD5()
        {
            return 0;
        }

        public double PressT()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.TKeyState;
            return 1;
        }

        public double PressG()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.GKeyState;
            return 2;
        }

        public double PressB()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.BKeyState;
            return 3;
        }
    }
}