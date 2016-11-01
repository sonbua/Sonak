using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.ColemakTypist
{
    [TestFixture]
    public class When_given_a_phrase
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.ColemakTypist();
        }

        [TestCase("tram nam trong coi nguoi ta", 33d)]
        [TestCase("chu tai chu menh kheo la ghet nhau", 51d)]
        public void Then_returns_correct_move_length(string text, double expected)
        {
            var actual = typist.Type(text);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}