using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.ColemakTypist
{
    [TestFixture]
    public class When_given_a_single_word
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.ColemakTypist();
        }

        [TestCase("turn", 5)]
        [TestCase("computing", 16)]
        [TestCase("internationalization", 24d)]
        [TestCase("abc123", 15.73d)]
        public void Then_returns_correct_move_length(string word, double expected)
        {
            var actual = typist.Type(word);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}