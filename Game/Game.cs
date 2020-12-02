using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Game
    {

        private List<int> _rolls = new List<int>();
        public bool Triple = false;
        public List<int> RollDice()
        {
            var dice = new Random();
            for (int i = 0; i < 5; i++)
            {
                _rolls.Add(dice.Next(1, 6));
            }

            return _rolls;
        }

        public void ResetRolls()
        {
            _rolls.Clear();
        }



        public int CalculateScore(List<int> scores)
        {
            var score = 0;

            var tripleScore = HasMultipleOccurances(scores,3);
            if (tripleScore.Item2)
            {
               score =  CalculateTriple(tripleScore.Item1);
            }

            return 0;
        }

        public int CalculateTriple(int number)
        {
            switch (number)
            {
                case 1:
                    return 1000;
                case 2:
                    return 200;
                case 3:
                    return 300;
                case 4:
                    return 400;
                case 5:
                    return 500;
                case 6:
                    return 600;
            }

            return 0;
        }

        public Tuple<int,bool> HasMultipleOccurances(List<int> scores,int totalOccurance)
        {
            var triple = scores.GroupBy(str => str)
                .OrderByDescending(g => g.Count())
                .Select(g => new { Number = g.Key, Count = g.Count() >= totalOccurance }) //make class
                .First();

            return new Tuple<int, bool>(triple.Number,triple.Count);
        }


    }
}
