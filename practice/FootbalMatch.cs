using System;
using Delegates;
namespace practice
{
    public class FootballMatch
    {

        public int team1Score = 0;
        public int team2Score = 0;
        public string team1Name;
        public string team2Name;
        public delegate void NotifyOnGoal(string teamName, int team1Score, int team2Score);
        public NotifyOnGoal GoalNotifier;
        public FootballMatch(string Team1, string Team2)
        {
            team1Name = Team1;
            team2Name = Team2;
        }


        public void teamScore(int teamNum)
        {
            if (teamNum == 1)
            {
                team1Score++;
                GoalNotifier?.Invoke(team1Name, team1Score, team2Score);
            }

            else if (teamNum == 2)
            {
                team2Score++;
                GoalNotifier?.Invoke(team2Name, team1Score, team2Score);
            }

            return;


        }
    }
}

