using System;
using FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Dvorak.Fingers.Right.LittleFinger
{
    internal class EnterKeyState : IRightLittleFingerKeyState
    {
        public string CurrentKey
        {
            get { return "[enter]"; }
        }

        public double PressD0()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressL()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressS()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressZ()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressOpenSquareBracket()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressSlash()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressMinus()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressRShift()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressCloseSquareBracket()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressPipe()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressBackSlash()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressEnter()
        {
            throw new NotSupportedException("Return to home row first.");
        }
    }
}