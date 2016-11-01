using FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Left;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Hands.Qwerty.Fingers.Left.IndexFinger
{
    internal class RKeyState : ILeftIndexFingerKeyState
    {
        private readonly LeftIndexFinger leftIndexFinger;

        public RKeyState(LeftIndexFinger leftIndexFinger)
        {
            this.leftIndexFinger = leftIndexFinger;
        }

        public string CurrentKey
        {
            get { return "r"; }
        }

        public double PressD4()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.D4KeyState;
            return 1;
        }

        public double PressR()
        {
            return 0;
        }

        public double PressF()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.FKeyState;
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

        public double PressT()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.TKeyState;
            return 1;
        }

        public double PressG()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.GKeyState;
            return 3.Sqrt();
        }

        public double PressB()
        {
            leftIndexFinger.CurrentKeyState = leftIndexFinger.BKeyState;
            return 7.Sqrt();
        }
    }
}