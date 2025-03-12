using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TwentyDaysofPractice
{
    class WinningTeams
    {

        // Identify first and second place teams by index
        // A win == 3 points
        // A draw == 1 point
        // If a tie, it is brokwn by the greatest difference of scored - conceded.
        int[] SubmittedSolution(int[] wins, int[] draws, int[] scored, int[] conceded)
        {
            // I would have used a maxheap priorityQueue but could not rememebr the syntax for the comparer.
            var winCount = new int[wins.Count()];
            var diffCount = new int[wins.Count()];
            for (var i = 0; i < wins.Count(); i++)
            {
                Console.WriteLine($"winCount[i] {winCount[i]}, wins[i]: {wins[i]}, draws[i]: {draws[i]}");
                winCount[i] += wins[i] * 3;
                winCount[i] += draws[i];
                diffCount[i] += scored[i] - conceded[i];
                Console.WriteLine($"winCount[i] {winCount[i]}, wins[i]: {wins[i]}, draws[i]: {draws[i]}");
            }
            var firstIdx = 0;
            var secondIdx = 0;
            var firstVal = 0;
            var secondVal = 0;

            for (var i = 0; i < winCount.Count(); i++)
            {
                if (winCount[i] > firstVal)
                {
                    secondVal = firstVal;
                    secondIdx = firstIdx;
                    firstIdx = i;
                    firstVal = winCount[i];
                }
                else if (winCount[i] == firstVal)
                {
                    secondVal = firstVal;
                    secondIdx = i;
                }
            }
            Console.WriteLine($"first: {winCount[firstIdx]}, second: {winCount[secondIdx]}");
            if (firstVal > secondVal)
                return new int[] { firstIdx, secondIdx };

            if (diffCount[firstVal] > diffCount[secondVal])
                return new int[] { firstIdx, secondIdx };
            return new int[] { secondIdx, firstIdx };
        }

        // Identify first and second place teams by index
        // A win == 3 points
        // A draw == 1 point
        // If a tie, it is brokwn by the greatest difference of scored - conceded.
        // Time: O(n Log n)
        // Space: O(n)
        public int[] NewSolution(int[] wins, int[] draws, int[] scored, int[] conceded)
        {
            var comparer = Comparer<int>.Create((a, b) => b.CompareTo(a));
            var winCount = new PriorityQueue<int, int>(comparer);
            var diffCount = new PriorityQueue<int, int>(comparer);
            var result = new int[2];

            for (var i = 0; i < wins.Count(); i++)
            {
                Console.WriteLine($"wins[i]: {wins[i]}, draws[i]: {draws[i]}");
                var sumEye = (wins[i] * 3) + draws[i];
                winCount.Enqueue(i,sumEye);
                var diff = scored[i] - conceded[i];
                diffCount.Enqueue(i, diff);
            }
            int element;
            int priority;
            winCount.TryDequeue(out element, out priority);
            var first = new { element, priority };
            winCount.TryDequeue(out element, out priority);
            var second = new { element, priority };
            if (first.priority == second.priority)
            {
                diffCount.TryDequeue(out element, out priority);
                var firstDiff = new { element, priority };
                diffCount.TryDequeue(out element, out priority);
                var secondDiff = new { element, priority };
                if (firstDiff.priority >= secondDiff.priority)
                {
                    result[0] = first.element;
                    result[1] = second.element;
                }
                else
                {
                    result[0] = second.element;
                    result[1] = first.element;
                }
            }
            else
            {
                result[0] = first.element;
                result[1] = second.element;
            }

                return result;
        }

        // Identify first and second place teams by index
        // A win == 3 points
        // A draw == 1 point
        // If a tie, it is brokwn by the greatest difference of scored - conceded.
        // Time: O(n)
        // Space: O(1)
        public int[] OptimizedSolution(int[] wins, int[] draws, int[] scored, int[] conceded)
        {
            int n = wins.Length;
            if (n < 2) throw new ArgumentException("At least two teams are required.");

            int[] result = new int[2]; // Stores indices of top two teams
            int firstIdx = 0, secondIdx = 1; // Initial assumption: team 0 and team 1
            int firstPoints = 3 * wins[0] + draws[0];
            int firstDiff = scored[0] - conceded[0];
            int secondPoints = 3 * wins[1] + draws[1];
            int secondDiff = scored[1] - conceded[1];

            // Ensure first is the higher of the initial two
            if (secondPoints > firstPoints || (secondPoints == firstPoints && secondDiff > firstDiff))
            {
                Swap(ref firstIdx, ref secondIdx);
                Swap(ref firstPoints, ref secondPoints);
                Swap(ref firstDiff, ref secondDiff);
            }

            // Single pass through remaining teams
            for (int i = 2; i < n; i++)
            {
                int points = 3 * wins[i] + draws[i];
                int diff = scored[i] - conceded[i];

                if (points > firstPoints || (points == firstPoints && diff > firstDiff))
                {
                    // New team becomes first, old first becomes second
                    secondIdx = firstIdx;
                    secondPoints = firstPoints;
                    secondDiff = firstDiff;
                    firstIdx = i;
                    firstPoints = points;
                    firstDiff = diff;
                }
                else if (points > secondPoints || (points == secondPoints && diff > secondDiff))
                {
                    // New team becomes second
                    secondIdx = i;
                    secondPoints = points;
                    secondDiff = diff;
                }
            }

            result[0] = firstIdx;
            result[1] = secondIdx;
            return result;
        }

        // Helper method to swap two variables
        private void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
