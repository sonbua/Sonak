using System.Collections.Generic;
using FingerMovingSimulation.Core.Expanders;

namespace FingerMovingSimulation.Infrastructure.Expanders.ToneMappers
{
    public class CustomToneMapper : IToneMapper
    {
        private readonly Dictionary<Tones, char> toneList;

        public CustomToneMapper(char grave,
                                char hook,
                                char tilde,
                                char accute,
                                char dot,
                                char aCircumflex,
                                char eCircumflex,
                                char oCircumflex,
                                char uoaHornBreve,
                                char dStroke)
        {
            toneList = new Dictionary<Tones, char>
                       {
                           {Tones.Grave, grave},
                           {Tones.Hook, hook},
                           {Tones.Tilde, tilde},
                           {Tones.Accute, accute},
                           {Tones.Dot, dot},
                           {Tones.ACircumflex, aCircumflex},
                           {Tones.ECircumflex, eCircumflex},
                           {Tones.OCircumflex, oCircumflex},
                           {Tones.UOAHornBreve, uoaHornBreve},
                           {Tones.DStroke, dStroke},
                       };
        }

        public char MapToCharacter(Tones tone)
        {
            return toneList[tone];
        }
    }
}