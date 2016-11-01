using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.QwertyTypist
{
    public class When_given_an_unicode_phrase
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.QwertyTypist();
        }

        [TestCase("trăm năm trong cõi người ta", 58.46d)]
        [TestCase("chữ tài chữ mệnh khéo là ghét nhau", 74d)]
        [TestCase("những điều trông thấy mà đau đớn lòng", 80.46)]
        public void Then_returns_correct_move_length(string text, double expected)
        {
            var actual = typist.Type(text);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}