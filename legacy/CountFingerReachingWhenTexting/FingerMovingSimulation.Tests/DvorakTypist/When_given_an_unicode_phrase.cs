using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.DvorakTypist
{
    [TestFixture]
    public class When_given_an_unicode_phrase
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.DvorakTypist();
        }

        [TestCase("trăm năm trong cõi người ta", 46d)]
        [TestCase("chữ tài chữ mệnh khéo là ghét nhau", 59d)]
        [TestCase("những điều trông thấy mà đau đớn lòng", 71.73d)]
        public void Then_returns_correct_move_length(string text, double expected)
        {
            var actual = typist.Type(text);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}