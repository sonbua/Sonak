using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.ColemakTypist
{
    [TestFixture]
    public class When_given_an_unicode_character
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.ColemakTypist();
        }

        [TestCase("ú", 3d)]
        [TestCase("ớ", 4d)]
        [TestCase("đ", 3d)]
        public void Then_returns_correct_move_length(string text, double expected)
        {
            var actual = typist.Type(text);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}