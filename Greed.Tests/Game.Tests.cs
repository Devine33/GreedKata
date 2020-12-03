using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Game.Tests
{
    public class Tests
    {
        private readonly List<int> _rolls = new List<int>();
        private Game _game;

        [SetUp]
        public void Setup()
        {
            _game = new Game();
            _rolls.Clear();
        }

        [Test]
        public void TripleScoreIsCalculatedCorrectly()
        {
            _rolls.AddRange(new List<int>() {1, 1, 1, 2, 4});
            var triple = _game.CalculateTriple(1);
            Assert.AreEqual(1000, triple);
        }

        [Test]
        public void CanDiscoverTriples()
        {
            _rolls.AddRange(new List<int>() {1, 1, 1, 2, 4});
            var triple = _game.HasMultipleOccurances(_rolls, 3);
            Assert.AreEqual(true, triple.Item2);
        }

        [Test]
        public void TripleCountIsZero()
        {
            _rolls.AddRange(new List<int>() {1, 2, 1, 2, 4});
            var triple = _game.HasMultipleOccurances(_rolls, 3);
            Assert.AreEqual(false, triple.Item2);
        }

        [Test]
        public void FirstTestCase()
        {
            _rolls.AddRange(new List<int>() {1, 1, 1, 5, 1});
            var score = _game.CalculateScore(_rolls);
            Assert.AreEqual(1150, score);
        }

        [Test]
        public void SecondTestCase()
        {
            _rolls.AddRange(new List<int>() {2, 3, 4, 6, 2});
            var score = _game.CalculateScore(_rolls);
            Assert.AreEqual(0, score);
        }

        [Test]
        public void ThirdTestCase()
        {
            _rolls.AddRange(new List<int>() {3, 4, 5, 3, 3});
            var score = _game.CalculateScore(_rolls);
            Assert.AreEqual(350, score);
        }
    }
}