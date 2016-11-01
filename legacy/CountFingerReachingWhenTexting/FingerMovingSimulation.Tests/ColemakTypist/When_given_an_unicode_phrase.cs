using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.ColemakTypist
{
    public class When_given_an_unicode_phrase
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.ColemakTypist();
        }

        [TestCase("trăm năm trong cõi người ta", 44d)]
        [TestCase("chữ tài chữ mệnh khéo là ghét nhau", 72.37d)]
        [TestCase("những điều trông thấy mà đau đớn lòng", 74)]
        public void Then_returns_correct_move_length(string text, double expected)
        {
            var actual = typist.Type(text);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}