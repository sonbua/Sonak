using System.Collections.Generic;
using System.Linq;
using FingerMovingSimulation.Core;

namespace FingerMovingSimulation.Infrastructure.Layouts
{
    internal class DvorakLayout : ILayout
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
                           Keys.I,
                           Keys.K,
                           Keys.P,
                           Keys.U,
                           Keys.X,
                           Keys.Y,
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
                           Keys.E,
                           Keys.J,
                           Keys.OemPeriod,
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
                           Keys.OemComma,
                           Keys.O,
                           Keys.Q,
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
                           Keys.OemSemicolon,
                           Keys.OemSingleQuote,
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
                           Keys.B,
                           Keys.D,
                           Keys.F,
                           Keys.G,
                           Keys.H,
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
                           Keys.C,
                           Keys.T,
                           Keys.W,
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
                           Keys.N,
                           Keys.R,
                           Keys.V,
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
                           Keys.L,
                           Keys.S,
                           Keys.Z,
                           Keys.D0,
                           Keys.OemOpenSquareBracket,
                           Keys.OemCloseSquareBracket,
                           Keys.OemSlash,
                           Keys.OemPipe,
                           Keys.OemBackSlash,
                           Keys.OemMinus,
                           Keys.RShift,
                           Keys.Enter
                       };
            }
        }
    }
}