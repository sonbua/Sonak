using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.ColemakTypist
{
    [TestFixture]
    public class When_given_a_character
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.ColemakTypist();
        }

        [TestCase("a", 1d)]
        [TestCase("b", 2.73d)]
        [TestCase("c", 2d)]
        [TestCase("d", 2d)]
        [TestCase("e", 1d)]
        [TestCase("f", 2d)]
        [TestCase("g", 2d)]
        [TestCase("h", 2d)]
        [TestCase("i", 1d)]
        [TestCase("j", 2.73d)]
        [TestCase("k", 2d)]
        [TestCase("l", 2d)]
        [TestCase("m", 2d)]
        [TestCase("n", 1d)]
        [TestCase("o", 1d)]
        [TestCase("p", 2d)]
        [TestCase("q", 2d)]
        [TestCase("r", 1d)]
        [TestCase("s", 1d)]
        [TestCase("t", 1d)]
        [TestCase("u", 2d)]
        [TestCase("v", 2d)]
        [TestCase("w", 2d)]
        [TestCase("x", 2d)]
        [TestCase("y", 2d)]
        [TestCase("z", 2d)]
        [TestCase("A", 3.73d)]
        [TestCase("B", 5.46d)]
        [TestCase("C", 4.73d)]
        [TestCase("D", 4.73d)]
        [TestCase("E", 3d)]
        [TestCase("F", 4.73d)]
        [TestCase("G", 4.73d)]
        [TestCase("H", 4d)]
        [TestCase("I", 3d)]
        [TestCase("J", 4.73d)]
        [TestCase("K", 4d)]
        [TestCase("L", 4d)]
        [TestCase("M", 4d)]
        [TestCase("N", 3d)]
        [TestCase("O", 3d)]
        [TestCase("P", 4.73d)]
        [TestCase("Q", 4.73d)]
        [TestCase("R", 3.73d)]
        [TestCase("S", 3.73d)]
        [TestCase("T", 3.73d)]
        [TestCase("U", 4d)]
        [TestCase("V", 4.73d)]
        [TestCase("W", 4.73d)]
        [TestCase("X", 4.73d)]
        [TestCase("Y", 4d)]
        [TestCase("Z", 4.73d)]
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
        public void Then_returns_correct_move_length(string text, double expected)
        {
            var actual = typist.Type(text);

            Assert.AreEqual(expected, actual, delta: 0.1);
        }
    }
}