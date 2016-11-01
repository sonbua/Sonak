using System.Collections.Generic;
using FingerMovingSimulation.Core.Expanders;

namespace FingerMovingSimulation.Infrastructure.Expanders.ToneMappers
{
    public class DvorakDefaultMapper : IToneMapper
    {
        private readonly Dictionary<Tones, char> toneList = new Dictionary<Tones, char>
                                                            {
                                                                {Tones.Grave, 'b'},
                                                                {Tones.Hook, 'r'},
                                                                {Tones.Tilde, 'k'},
                                                                {Tones.Accute, 'd'},
                                                                {Tones.Dot, 's'},
                                                                {Tones.ACircumflex, 'a'},
                                                                {Tones.ECircumflex, 'e'},
                                                                {Tones.OCircumflex, 'o'},
                                                                {Tones.UOAHornBreve, 'h'},
                                                                {Tones.DStroke, 't'},
                                                            };

        public char MapToCharacter(Tones tone)
        {
            return toneList[tone];
        }
    }
}