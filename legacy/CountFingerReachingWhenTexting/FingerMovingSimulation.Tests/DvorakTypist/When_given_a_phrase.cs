using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.DvorakTypist
{
    [TestFixture]
    public class When_given_a_phrase
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.DvorakTypist();
        }

        [TestCase("tram nam trong coi nguoi ta", 37d)]
        [TestCase("chu tai chu menh kheo la ghet nhau", 43d)]
        public void Then_returns_correct_move_length(string text, double expected)
        {
            var actual = typist.Type(text);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}