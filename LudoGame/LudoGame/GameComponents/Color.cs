using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.GameComponents
{
    public class Color
    {
        public List<string> RandomColor { get; set; }
        public List<string> NormalColor { get; set; }
        public Random RandomInt { get; set; }
        public int AssignColor { get; set; }


        public Color(int players)
        {
            NormalColor = new List<string>();
            RandomColor = new List<string>();
            RandomInt = new Random();
            addAllColor();
            AssignRandomColors(players);
        }


        public void AssignRandomColors(int players)
        {
            int playerLength = players;
            for (var i = 0; i < players; i++)
            {
                AssignColor = RandomInt.Next(0, playerLength);
                RandomColor.Add(NormalColor[AssignColor]);
                NormalColor.Remove(NormalColor[AssignColor]);
                playerLength--;
            }
        }

        public void addAllColor()
        {
            NormalColor.Add("Red");
            NormalColor.Add("Blue");
            NormalColor.Add("Green");
            NormalColor.Add("Yellow");
        }
    }
}
