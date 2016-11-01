using System.Collections.Generic;
using FingerMovingSimulation.Core.Expanders;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Expanders
{
    internal class VietnameseCharacterExpander : IVietnameseCharacterExpander
    {
        private readonly Dictionary<char, CharacterComponents> decomposedCharacterSet =
            new Dictionary<char, CharacterComponents>
            {
                {'À', new CharacterComponents {Base = 'A', Tones = new[] {Tones.Grave}}},
                {'Ả', new CharacterComponents {Base = 'A', Tones = new[] {Tones.Hook}}},
                {'Ã', new CharacterComponents {Base = 'A', Tones = new[] {Tones.Tilde}}},
                {'Á', new CharacterComponents {Base = 'A', Tones = new[] {Tones.Accute}}},
                {'Ạ', new CharacterComponents {Base = 'A', Tones = new[] {Tones.Dot}}},
                //
                {'à', new CharacterComponents {Base = 'a', Tones = new[] {Tones.Grave}}},
                {'ả', new CharacterComponents {Base = 'a', Tones = new[] {Tones.Hook}}},
                {'ã', new CharacterComponents {Base = 'a', Tones = new[] {Tones.Tilde}}},
                {'á', new CharacterComponents {Base = 'a', Tones = new[] {Tones.Accute}}},
                {'ạ', new CharacterComponents {Base = 'a', Tones = new[] {Tones.Dot}}},
                //
                {'Ă', new CharacterComponents {Base = 'A', Tones = new[] {Tones.UOAHornBreve}}},
                {'Ằ', new CharacterComponents {Base = 'A', Tones = new[] {Tones.UOAHornBreve, Tones.Grave}}},
                {'Ẳ', new CharacterComponents {Base = 'A', Tones = new[] {Tones.UOAHornBreve, Tones.Hook}}},
                {'Ẵ', new CharacterComponents {Base = 'A', Tones = new[] {Tones.UOAHornBreve, Tones.Tilde}}},
                {'Ắ', new CharacterComponents {Base = 'A', Tones = new[] {Tones.UOAHornBreve, Tones.Accute}}},
                {'Ặ', new CharacterComponents {Base = 'A', Tones = new[] {Tones.UOAHornBreve, Tones.Dot}}},
                //
                {'ă', new CharacterComponents {Base = 'a', Tones = new[] {Tones.UOAHornBreve}}},
                {'ằ', new CharacterComponents {Base = 'a', Tones = new[] {Tones.UOAHornBreve, Tones.Grave}}},
                {'ẳ', new CharacterComponents {Base = 'a', Tones = new[] {Tones.UOAHornBreve, Tones.Hook}}},
                {'ẵ', new CharacterComponents {Base = 'a', Tones = new[] {Tones.UOAHornBreve, Tones.Tilde}}},
                {'ắ', new CharacterComponents {Base = 'a', Tones = new[] {Tones.UOAHornBreve, Tones.Accute}}},
                {'ặ', new CharacterComponents {Base = 'a', Tones = new[] {Tones.UOAHornBreve, Tones.Dot}}},
                //
                {'Â', new CharacterComponents {Base = 'A', Tones = new[] {Tones.ACircumflex}}},
                {'Ầ', new CharacterComponents {Base = 'A', Tones = new[] {Tones.ACircumflex, Tones.Grave}}},
                {'Ẩ', new CharacterComponents {Base = 'A', Tones = new[] {Tones.ACircumflex, Tones.Hook}}},
                {'Ẫ', new CharacterComponents {Base = 'A', Tones = new[] {Tones.ACircumflex, Tones.Tilde}}},
                {'Ấ', new CharacterComponents {Base = 'A', Tones = new[] {Tones.ACircumflex, Tones.Accute}}},
                {'Ậ', new CharacterComponents {Base = 'A', Tones = new[] {Tones.ACircumflex, Tones.Dot}}},
                //
                {'â', new CharacterComponents {Base = 'a', Tones = new[] {Tones.ACircumflex}}},
                {'ầ', new CharacterComponents {Base = 'a', Tones = new[] {Tones.ACircumflex, Tones.Grave}}},
                {'ẩ', new CharacterComponents {Base = 'a', Tones = new[] {Tones.ACircumflex, Tones.Hook}}},
                {'ẫ', new CharacterComponents {Base = 'a', Tones = new[] {Tones.ACircumflex, Tones.Tilde}}},
                {'ấ', new CharacterComponents {Base = 'a', Tones = new[] {Tones.ACircumflex, Tones.Accute}}},
                {'ậ', new CharacterComponents {Base = 'a', Tones = new[] {Tones.ACircumflex, Tones.Dot}}},
                //
                {'È', new CharacterComponents {Base = 'E', Tones = new[] {Tones.Grave}}},
                {'Ẻ', new CharacterComponents {Base = 'E', Tones = new[] {Tones.Hook}}},
                {'Ẽ', new CharacterComponents {Base = 'E', Tones = new[] {Tones.Tilde}}},
                {'É', new CharacterComponents {Base = 'E', Tones = new[] {Tones.Accute}}},
                {'Ẹ', new CharacterComponents {Base = 'E', Tones = new[] {Tones.Dot}}},
                //
                {'è', new CharacterComponents {Base = 'e', Tones = new[] {Tones.Grave}}},
                {'ẻ', new CharacterComponents {Base = 'e', Tones = new[] {Tones.Hook}}},
                {'ẽ', new CharacterComponents {Base = 'e', Tones = new[] {Tones.Tilde}}},
                {'é', new CharacterComponents {Base = 'e', Tones = new[] {Tones.Accute}}},
                {'ẹ', new CharacterComponents {Base = 'e', Tones = new[] {Tones.Dot}}},
                //
                {'Ê', new CharacterComponents {Base = 'E', Tones = new[] {Tones.ECircumflex}}},
                {'Ề', new CharacterComponents {Base = 'E', Tones = new[] {Tones.ECircumflex, Tones.Grave}}},
                {'Ể', new CharacterComponents {Base = 'E', Tones = new[] {Tones.ECircumflex, Tones.Hook}}},
                {'Ễ', new CharacterComponents {Base = 'E', Tones = new[] {Tones.ECircumflex, Tones.Tilde}}},
                {'Ế', new CharacterComponents {Base = 'E', Tones = new[] {Tones.ECircumflex, Tones.Accute}}},
                {'Ệ', new CharacterComponents {Base = 'E', Tones = new[] {Tones.ECircumflex, Tones.Dot}}},
                //
                {'ê', new CharacterComponents {Base = 'e', Tones = new[] {Tones.ECircumflex}}},
                {'ề', new CharacterComponents {Base = 'e', Tones = new[] {Tones.ECircumflex, Tones.Grave}}},
                {'ể', new CharacterComponents {Base = 'e', Tones = new[] {Tones.ECircumflex, Tones.Hook}}},
                {'ễ', new CharacterComponents {Base = 'e', Tones = new[] {Tones.ECircumflex, Tones.Tilde}}},
                {'ế', new CharacterComponents {Base = 'e', Tones = new[] {Tones.ECircumflex, Tones.Accute}}},
                {'ệ', new CharacterComponents {Base = 'e', Tones = new[] {Tones.ECircumflex, Tones.Dot}}},
                //
                {'Ì', new CharacterComponents {Base = 'I', Tones = new[] {Tones.Grave}}},
                {'Ỉ', new CharacterComponents {Base = 'I', Tones = new[] {Tones.Hook}}},
                {'Ĩ', new CharacterComponents {Base = 'I', Tones = new[] {Tones.Tilde}}},
                {'Í', new CharacterComponents {Base = 'I', Tones = new[] {Tones.Accute}}},
                {'Ị', new CharacterComponents {Base = 'I', Tones = new[] {Tones.Dot}}},
                //
                {'ì', new CharacterComponents {Base = 'i', Tones = new[] {Tones.Grave}}},
                {'ỉ', new CharacterComponents {Base = 'i', Tones = new[] {Tones.Hook}}},
                {'ĩ', new CharacterComponents {Base = 'i', Tones = new[] {Tones.Tilde}}},
                {'í', new CharacterComponents {Base = 'i', Tones = new[] {Tones.Accute}}},
                {'ị', new CharacterComponents {Base = 'i', Tones = new[] {Tones.Dot}}},
                //
                {'Ò', new CharacterComponents {Base = 'O', Tones = new[] {Tones.Grave}}},
                {'Ỏ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.Hook}}},
                {'Õ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.Tilde}}},
                {'Ó', new CharacterComponents {Base = 'O', Tones = new[] {Tones.Accute}}},
                {'Ọ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.Dot}}},
                //
                {'ò', new CharacterComponents {Base = 'o', Tones = new[] {Tones.Grave}}},
                {'ỏ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.Hook}}},
                {'õ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.Tilde}}},
                {'ó', new CharacterComponents {Base = 'o', Tones = new[] {Tones.Accute}}},
                {'ọ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.Dot}}},
                //
                {'Ô', new CharacterComponents {Base = 'O', Tones = new[] {Tones.OCircumflex}}},
                {'Ồ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.OCircumflex, Tones.Grave}}},
                {'Ổ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.OCircumflex, Tones.Hook}}},
                {'Ỗ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.OCircumflex, Tones.Tilde}}},
                {'Ố', new CharacterComponents {Base = 'O', Tones = new[] {Tones.OCircumflex, Tones.Accute}}},
                {'Ộ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.OCircumflex, Tones.Dot}}},
                //
                {'ô', new CharacterComponents {Base = 'o', Tones = new[] {Tones.OCircumflex}}},
                {'ồ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.OCircumflex, Tones.Grave}}},
                {'ổ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.OCircumflex, Tones.Hook}}},
                {'ỗ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.OCircumflex, Tones.Tilde}}},
                {'ố', new CharacterComponents {Base = 'o', Tones = new[] {Tones.OCircumflex, Tones.Accute}}},
                {'ộ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.OCircumflex, Tones.Dot}}},
                //
                {'Ơ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.UOAHornBreve}}},
                {'Ờ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.UOAHornBreve, Tones.Grave}}},
                {'Ở', new CharacterComponents {Base = 'O', Tones = new[] {Tones.UOAHornBreve, Tones.Hook}}},
                {'Ỡ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.UOAHornBreve, Tones.Tilde}}},
                {'Ớ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.UOAHornBreve, Tones.Accute}}},
                {'Ợ', new CharacterComponents {Base = 'O', Tones = new[] {Tones.UOAHornBreve, Tones.Dot}}},
                //
                {'ơ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.UOAHornBreve}}},
                {'ờ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.UOAHornBreve, Tones.Grave}}},
                {'ở', new CharacterComponents {Base = 'o', Tones = new[] {Tones.UOAHornBreve, Tones.Hook}}},
                {'ỡ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.UOAHornBreve, Tones.Tilde}}},
                {'ớ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.UOAHornBreve, Tones.Accute}}},
                {'ợ', new CharacterComponents {Base = 'o', Tones = new[] {Tones.UOAHornBreve, Tones.Dot}}},
                //
                {'Ù', new CharacterComponents {Base = 'U', Tones = new[] {Tones.Grave}}},
                {'Ủ', new CharacterComponents {Base = 'U', Tones = new[] {Tones.Hook}}},
                {'Ũ', new CharacterComponents {Base = 'U', Tones = new[] {Tones.Tilde}}},
                {'Ú', new CharacterComponents {Base = 'U', Tones = new[] {Tones.Accute}}},
                {'Ụ', new CharacterComponents {Base = 'U', Tones = new[] {Tones.Dot}}},
                //
                {'ù', new CharacterComponents {Base = 'u', Tones = new[] {Tones.Grave}}},
                {'ủ', new CharacterComponents {Base = 'u', Tones = new[] {Tones.Hook}}},
                {'ũ', new CharacterComponents {Base = 'u', Tones = new[] {Tones.Tilde}}},
                {'ú', new CharacterComponents {Base = 'u', Tones = new[] {Tones.Accute}}},
                {'ụ', new CharacterComponents {Base = 'u', Tones = new[] {Tones.Dot}}},
                //
                {'Ư', new CharacterComponents {Base = 'U', Tones = new[] {Tones.UOAHornBreve}}},
                {'Ừ', new CharacterComponents {Base = 'U', Tones = new[] {Tones.UOAHornBreve, Tones.Grave}}},
                {'Ử', new CharacterComponents {Base = 'U', Tones = new[] {Tones.UOAHornBreve, Tones.Hook}}},
                {'Ữ', new CharacterComponents {Base = 'U', Tones = new[] {Tones.UOAHornBreve, Tones.Tilde}}},
                {'Ứ', new CharacterComponents {Base = 'U', Tones = new[] {Tones.UOAHornBreve, Tones.Accute}}},
                {'Ự', new CharacterComponents {Base = 'U', Tones = new[] {Tones.UOAHornBreve, Tones.Dot}}},
                //
                {'ư', new CharacterComponents {Base = 'u', Tones = new[] {Tones.UOAHornBreve}}},
                {'ừ', new CharacterComponents {Base = 'u', Tones = new[] {Tones.UOAHornBreve, Tones.Grave}}},
                {'ử', new CharacterComponents {Base = 'u', Tones = new[] {Tones.UOAHornBreve, Tones.Hook}}},
                {'ữ', new CharacterComponents {Base = 'u', Tones = new[] {Tones.UOAHornBreve, Tones.Tilde}}},
                {'ứ', new CharacterComponents {Base = 'u', Tones = new[] {Tones.UOAHornBreve, Tones.Accute}}},
                {'ự', new CharacterComponents {Base = 'u', Tones = new[] {Tones.UOAHornBreve, Tones.Dot}}},
                //
                {'Ỳ', new CharacterComponents {Base = 'Y', Tones = new[] {Tones.Grave}}},
                {'Ỷ', new CharacterComponents {Base = 'Y', Tones = new[] {Tones.Hook}}},
                {'Ỹ', new CharacterComponents {Base = 'Y', Tones = new[] {Tones.Tilde}}},
                {'Ý', new CharacterComponents {Base = 'Y', Tones = new[] {Tones.Accute}}},
                {'Ỵ', new CharacterComponents {Base = 'Y', Tones = new[] {Tones.Dot}}},
                //
                {'ỳ', new CharacterComponents {Base = 'y', Tones = new[] {Tones.Grave}}},
                {'ỷ', new CharacterComponents {Base = 'y', Tones = new[] {Tones.Hook}}},
                {'ỹ', new CharacterComponents {Base = 'y', Tones = new[] {Tones.Tilde}}},
                {'ý', new CharacterComponents {Base = 'y', Tones = new[] {Tones.Accute}}},
                {'ỵ', new CharacterComponents {Base = 'y', Tones = new[] {Tones.Dot}}},
                //
                {'Đ', new CharacterComponents {Base = 'D', Tones = new[] {Tones.DStroke}}},
                //
                {'đ', new CharacterComponents {Base = 'd', Tones = new[] {Tones.DStroke}}},
            };

        private IToneMapper ToneMapper { get; set; }

        public VietnameseCharacterExpander(IToneMapper toneMapper)
        {
            ToneMapper = toneMapper;
        }

        public IEnumerable<char> Expand(char c)
        {
            if (c.IsNotIn(decomposedCharacterSet.Keys))
            {
                yield return c;
                yield break;
            }

            var components = decomposedCharacterSet[c];

            yield return components.Base;

            foreach (var tone in components.Tones)
            {
                yield return ToneMapper.MapToCharacter(tone);
            }
        }

        public IEnumerable<char> SpecialCharacterSet
        {
            get { return decomposedCharacterSet.Keys; }
        }
    }
}