using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.QwertyTypist
{
    [TestFixture]
    public class When_given_a_single_word
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.QwertyTypist();
        }

        [TestCase("turn", 8.73)]
        [TestCase("computing", 19.73)]
        [TestCase("internationalization", 31d)]
        [TestCase("abc123", 15.73d)]
        public void Then_returns_correct_move_length(string word, double expected)
        {
            var actual = typist.Type(word);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}