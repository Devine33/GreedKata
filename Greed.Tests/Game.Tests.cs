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
        public void TripleScoreIsCalculatedCorrectly() // [1,1,1,4,6] = 1000
        {
            _rolls.AddRange(new List<int>() { 1, 1, 1, 2, 4 });
           var triple= _game.CalculateTriple(1);
            Assert.AreEqual(1000,triple);
        }

        [Test]
        public void CanDiscoverTriples()
        {
            _rolls.AddRange(new List<int>() { 1, 1, 1, 2, 4 });
            var triple = _game.HasMultipleOccurances(_rolls, 3);
            Assert.AreEqual(true, triple.Item2);
        }

        [Test]
        public void TripleCountIsZero()
        {
            _rolls.AddRange(new List<int>() { 1, 2, 1, 2, 4 });
            var triple = _game.HasMultipleOccurances(_rolls, 3);
            Assert.AreEqual(false, triple.Item2);
        }

        public void MaxScoreIsCalculatedCorrectly() // [1,1,1,1,1] = 1200
        {

        }

        public void WorstScoreIsCalculatedCorrectly() //[2,3,4,6,2] = 0
        {

        }
    }
}