using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.DvorakTypist
{
    [TestFixture]
    public class When_given_a_character
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.DvorakTypist();
        }

        [TestCase("a", 1d)]
        [TestCase("b", 2d)]
        [TestCase("c", 2d)]
        [TestCase("d", 2d)]
        [TestCase("e", 1d)]
        [TestCase("f", 2.73d)]
        [TestCase("g", 2d)]
        [TestCase("h", 1d)]
        [TestCase("i", 2d)]
        [TestCase("j", 2d)]
        [TestCase("k", 2d)]
        [TestCase("l", 2d)]
        [TestCase("m", 2d)]
        [TestCase("n", 1d)]
        [TestCase("o", 1d)]
        [TestCase("p", 2d)]
        [TestCase("q", 2d)]
        [TestCase("r", 2d)]
        [TestCase("s", 1d)]
        [TestCase("t", 1d)]
        [TestCase("u", 1d)]
        [TestCase("v", 2d)]
        [TestCase("w", 2d)]
        [TestCase("x", 2.73d)]
        [TestCase("y", 2d)]
        [TestCase("z", 2d)]
        [TestCase(",", 2d)]
        [TestCase(".", 2d)]
        [TestCase(";", 2d)]
        [TestCase("/", 2d)]
        [TestCase("0", 3d)]
        [TestCase("1", 3d)]
        [TestCase("2", 3d)]
        [TestCase("3", 3d)]
        [TestCase("4", 3d)]
        [TestCase("5", 2.73d)]
        [TestCase("6", 3.65d)]
        [TestCase("7", 3d)]
        [TestCase("8", 3d)]
        [TestCase("9", 3d)]
        public void Then_return_correct_move_length(string text, double expected)
        {
            var actual = typist.Type(text);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}