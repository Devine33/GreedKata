using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Greed.Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TripleScoreIsCalculatedCorrectly() // [1,1,1,4,6] = 1000
        {
            Assert.Pass();
        }

        public void TripleScoreAndSingleFiveIsCaclulatedCorrectly()
        {

        }

        public void MaxScoreIsCalculatedCorrectly() // [1,1,1,1,1] = 1200
        {

        }

        public void WorstScoreIsCalculatedCorrectly() //[2,3,4,6,2] = 0
        {

        }



        private List<int> Roll()
        {
            var rolls = new List<int>();

            var dice = new Random();
            for (int i = 0; i < 5; i++)
            {
               rolls.Add(dice.Next(1,6));
            }

            return rolls;
        }

        private int CalculateScore()
        {
            return 0;
        }
    }
}