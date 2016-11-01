using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.QwertyTypist
{
    [TestFixture]
    public class When_given_an_unicode_character
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.QwertyTypist();
        }

        [TestCase("ú", 3d)]
        [TestCase("ớ", 6d)]
        [TestCase("đ", 2d)]
        public void Then_returns_correct_move_length(string text, double expected)
        {
            var actual = typist.Type(text);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}