using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.DvorakTypist
{
    [TestFixture]
    public class When_given_a_single_word
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.DvorakTypist();
        }

        [TestCase("turn", 6d)]
        [TestCase("computing", 17d)]
        [TestCase("internationalization", 26d)]
        [TestCase("abc123", 14d)]
        public void Then_returns_correct_move_length(string word, double expected)
        {
            var actual = typist.Type(word);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}