using FingerMovingSimulation.Core;
using NUnit.Framework;

namespace FingerMovingSimulation.Tests.QwertyTypist
{
    [TestFixture]
    public class When_given_a_character
    {
        private ITypist typist;

        [SetUp]
        public void Init()
        {
            typist = new Infrastructure.Typists.QwertyTypist();
        }

        [TestCase("a", 1d)]
        [TestCase("b", 2.73d)]
        [TestCase("c", 2d)]
        [TestCase("d", 1d)]
        [TestCase("e", 2d)]
        [TestCase("f", 1d)]
        [TestCase("g", 2d)]
        [TestCase("h", 2d)]
        [TestCase("i", 2d)]
        [TestCase("j", 1d)]
        [TestCase("k", 1d)]
        [TestCase("l", 1d)]
        [TestCase("m", 2d)]
        [TestCase("n", 2d)]
        [TestCase("o", 2d)]
        [TestCase("p", 2d)]
        [TestCase("q", 2d)]
        [TestCase("r", 2d)]
        [TestCase("s", 1d)]
        [TestCase("t", 2d)]
        [TestCase("u", 2d)]
        [TestCase("v", 2d)]
        [TestCase("w", 2d)]
        [TestCase("x", 2d)]
        [TestCase("y", 2.73d)]
        [TestCase("z", 2d)]
        [TestCase("A", 3.73d)]
        [TestCase("B", 5.46d)]
        [TestCase("C", 4.73d)]
        [TestCase("D", 3.73d)]
        [TestCase("E", 4.73d)]
        [TestCase("F", 3.73d)]
        [TestCase("G", 4.73d)]
        [TestCase("H", 4d)]
        [TestCase("I", 4d)]
        [TestCase("J", 3d)]
        [TestCase("K", 3d)]
        [TestCase("L", 3d)]
        [TestCase("M", 4d)]
        [TestCase("N", 4d)]
        [TestCase("O", 4d)]
        [TestCase("P", 4d)]
        [TestCase("Q", 4.73d)]
        [TestCase("R", 4.73d)]
        [TestCase("S", 3.73d)]
        [TestCase("T", 4.73d)]
        [TestCase("U", 4d)]
        [TestCase("V", 4.73d)]
        [TestCase("W", 4.73d)]
        [TestCase("X", 4.73d)]
        [TestCase("Y", 4.73d)]
        [TestCase("Z", 4.73d)]
        [TestCase(",", 2d)]
        [TestCase(".", 2d)]
        [TestCase(";", 1d)]
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