using System.Collections.Generic;
using FingerMovingSimulation.Core.Expanders;

namespace FingerMovingSimulation.Infrastructure.Expanders.ToneMappers
{
    public class TelexMapper : IToneMapper
    {
        private readonly Dictionary<Tones, char> toneList = new Dictionary<Tones, char>
                                                            {
                                                                {Tones.Grave, 'f'},
                                                                {Tones.Hook, 'r'},
                                                                {Tones.Tilde, 'x'},
                                                                {Tones.Accute, 's'},
                                                                {Tones.Dot, 'j'},
                                                                {Tones.ACircumflex, 'a'},
                                                                {Tones.ECircumflex, 'e'},
                                                                {Tones.OCircumflex, 'o'},
                                                                {Tones.UOAHornBreve, 'w'},
                                                                {Tones.DStroke, 'd'},
                                                            };

        public char MapToCharacter(Tones tone)
        {
            return toneList[tone];
        }
    }
}