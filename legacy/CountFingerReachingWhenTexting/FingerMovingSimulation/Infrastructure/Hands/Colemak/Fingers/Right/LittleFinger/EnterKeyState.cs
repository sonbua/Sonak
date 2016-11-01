using System;
using FingerMovingSimulation.Core.Hands.Colemak.Fingers.Right;

namespace FingerMovingSimulation.Infrastructure.Hands.Colemak.Fingers.Right.LittleFinger
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

        public double PressSemicolon()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressO()
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

        public double PressOpenSquareBracket()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressSingleQuote()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressRShift()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressPipe()
        {
            throw new NotSupportedException("Return to home row first.");
        }

        public double PressCloseSquareBracket()
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