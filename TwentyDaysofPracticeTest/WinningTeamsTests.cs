namespace TwentyDaysofPracticeTest
{
    using NUnit.Framework;
    using NUnit.Framework.Legacy;

    [TestFixture]
    public class WinningTeamsTests
    {
        private int[] NewSolution(int[] wins, int[] draws, int[] scored, int[] conceded)
        {
            // Placeholder implementation
            int n = wins.Length;
            var teams = new (int points, int goalDiff, int index)[n];

            // Calculate points and goal difference for each team
            for (int i = 0; i < n; i++)
            {
                int points = 3 * wins[i] + draws[i];
                int goalDiff = scored[i] - conceded[i];
                teams[i] = (points, goalDiff, i);
            }

            // Sort by points descending, then goal difference descending
            var sorted = teams.OrderByDescending(t => t.points)
                             .ThenByDescending(t => t.goalDiff)
                             .ToArray();

            // Return indices of top 2 teams
            return new int[] { sorted[0].index, sorted[1].index };
        }

        [Test]
        public void Test_TwoTeams_DistinctPoints()
        {
            // Arrange
            int[] wins = { 2, 1 };        // Points: 6, 3
            int[] draws = { 0, 0 };
            int[] scored = { 4, 2 };
            int[] conceded = { 1, 1 };
            int[] expected = { 0, 1 };    // Team 0: 6 pts, Team 1: 3 pts

            // Act
            int[] result = NewSolution(wins, draws, scored, conceded);

            // Assert
            Assert.That(result, Is.EqualTo(expected).AsCollection);
        }

        [Test]
        public void Test_ThreeTeams_TieOnPoints_GoalDiffDecides()
        {
            // Arrange
            int[] wins = { 1, 1, 1 };        // Points: 3, 3, 3
            int[] draws = { 0, 0, 0 };
            int[] scored = { 5, 3, 1 };      // Goal Diff: 4, 1, -1
            int[] conceded = { 1, 2, 2 };
            int[] expected = { 0, 1 };       // Team 0: 3 pts GD 4, Team 1: 3 pts GD 1

            // Act
            int[] result = NewSolution(wins, draws, scored, conceded);

            // Assert
            Assert.That(result, Is.EqualTo(expected).AsCollection);
        }

        [Test]
        public void Test_SingleTeam_ThrowsException()
        {
            // Arrange
            int[] wins = { 1 };
            int[] draws = { 0 };
            int[] scored = { 2 };
            int[] conceded = { 1 };

            // Act & Assert
            Assert.Throws<System.IndexOutOfRangeException>(() => NewSolution(wins, draws, scored, conceded));
            // Assuming the method would fail with < 2 teams
        }

        [Test]
        public void Test_FourTeams_MixedResults()
        {
            // Arrange
            int[] wins = { 2, 1, 3, 0 };     // Points: 6, 3, 9, 0
            int[] draws = { 1, 2, 0, 1 };    // Points: 7, 5, 9, 1
            int[] scored = { 5, 4, 8, 2 };   // Goal Diff: 2, 1, 5, -1
            int[] conceded = { 3, 3, 3, 3 };
            int[] expected = { 2, 0 };       // Team 2: 9 pts GD 5, Team 0: 7 pts GD 2

            // Act
            int[] result = NewSolution(wins, draws, scored, conceded);

            // Assert
            Assert.That(result, Is.EqualTo(expected).AsCollection);
        }

        [Test]
        public void Test_TwoTeams_TieOnPointsAndGoalDiff()
        {
            // Arrange
            int[] wins = { 1, 1 };        // Points: 3, 3
            int[] draws = { 0, 0 };
            int[] scored = { 2, 2 };      // Goal Diff: 1, 1
            int[] conceded = { 1, 1 };
            int[] expected = { 0, 1 };    // Team 0 and Team 1 tied, order may be 0,1 or 1,0

            // Act
            int[] result = NewSolution(wins, draws, scored, conceded);

            // Assert
            Assert.That(result, Is.EqualTo(expected).AsCollection);
        }

        [Test]
        public void Test_ThreeTeams_AllZeros()
        {
            // Arrange
            int[] wins = { 0, 0, 0 };     // Points: 0, 0, 0
            int[] draws = { 0, 0, 0 };
            int[] scored = { 0, 0, 0 };   // Goal Diff: 0, 0, 0
            int[] conceded = { 0, 0, 0 };
            int[] expected = { 0, 1 };    // All tied, picks first two indices

            // Act
            int[] result = NewSolution(wins, draws, scored, conceded);

            // Assert
            Assert.That(result, Is.EqualTo(expected).AsCollection);
        }
    }
}
