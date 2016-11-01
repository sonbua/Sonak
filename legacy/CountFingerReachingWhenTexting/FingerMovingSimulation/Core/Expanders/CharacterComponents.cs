using System.Collections.Generic;

namespace FingerMovingSimulation.Core.Expanders
{
    internal class CharacterComponents
    {
        public char Base { get; set; }

        public IEnumerable<Tones> Tones { get; set; }
    }
}