using System;
using System.Collections.Generic;


namespace Hockey
{
    public class Player
    {
        public string Name {get; set;}
        public string Position {get; set;}
        public string Team {get; set;}
        public int Goals {get; set;}
        public int Assists {get; set;}

        public void ScoreGoal(Player player)
        {
            player.Goals++;
        }
        public void GetAssist(Player player)
        {
            player.Assists++;
        }
    }
}
