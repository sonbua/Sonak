using System.Collections.Generic;
using System.Linq;
using FingerMovingSimulation.Core;

namespace FingerMovingSimulation.Infrastructure.Layouts
{
    internal class ColemakLayout : ILayout
    {
        public IEnumerable<Keys> LeftHandKeys
        {
            get
            {
                return new[]
                       {
                           LeftThumbKeys,
                           LeftIndexKeys,
                           LeftMiddleKeys,
                           LeftRingKeys,
                           LeftLittleKeys
                       }.SelectMany(finger => finger.ToList());
            }
        }

        public IEnumerable<Keys> RightHandKeys
        {
            get
            {
                return new[]
                       {
                           RightThumbKeys,
                           RightIndexKeys,
                           RightMiddleKeys,
                           RightRingKeys,
                           RightLittleKeys
                       }.SelectMany(finger => finger.ToList());
            }
        }

        public IEnumerable<Keys> LeftThumbKeys
        {
            get { return new[] {Keys.Space}; }
        }

        public IEnumerable<Keys> LeftIndexKeys
        {
            get
            {
                return new[]
                       {
                           Keys.D,
                           Keys.G,
                           Keys.B,
                           Keys.T,
                           Keys.P,
                           Keys.V,
                           Keys.D4,
                           Keys.D5
                       };
            }
        }

        public IEnumerable<Keys> LeftMiddleKeys
        {
            get
            {
                return new[]
                       {
                           Keys.F,
                           Keys.S,
                           Keys.C,
                           Keys.D3
                       };
            }
        }

        public IEnumerable<Keys> LeftRingKeys
        {
            get
            {
                return new[]
                       {
                           Keys.R,
                           Keys.W,
                           Keys.X,
                           Keys.D2
                       };
            }
        }

        public IEnumerable<Keys> LeftLittleKeys
        {
            get
            {
                return new[]
                       {
                           Keys.A,
                           Keys.Q,
                           Keys.Z,
                           Keys.D1,
                           Keys.LShift
                       };
            }
        }

        public IEnumerable<Keys> RightThumbKeys
        {
            get { return new List<Keys>(); }
        }

        public IEnumerable<Keys> RightIndexKeys
        {
            get
            {
                return new[]
                       {
                           Keys.H,
                           Keys.J,
                           Keys.K,
                           Keys.N,
                           Keys.L,
                           Keys.M,
                           Keys.D6,
                           Keys.D7
                       };
            }
        }

        public IEnumerable<Keys> RightMiddleKeys
        {
            get
            {
                return new[]
                       {
                           Keys.OemComma,
                           Keys.E,
                           Keys.U,
                           Keys.D8
                       };
            }
        }

        public IEnumerable<Keys> RightRingKeys
        {
            get
            {
                return new[]
                       {
                           Keys.I,
                           Keys.Y,
                           Keys.OemPeriod,
                           Keys.D9
                       };
            }
        }

        public IEnumerable<Keys> RightLittleKeys
        {
            get
            {
                return new[]
                       {
                           Keys.O,
                           Keys.OemSemicolon,
                           Keys.OemSlash,
                           Keys.D0,
                           Keys.OemMinus,
                           Keys.OemPipe,
                           Keys.OemCloseSquareBracket,
                           Keys.OemOpenSquareBracket,
                           Keys.OemBackSlash,
                           Keys.OemSingleQuote,
                           Keys.RShift,
                           Keys.Enter
                       };
            }
        }
    }
}