using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.GameComponents;

namespace LudoGame.Game
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ColorOfPawn { get; set; }
        public Pawn pawn { get; set; }
        public int PlayerMaxDiceCount { get; set; }
        public StringBuilder pawnPos = new StringBuilder();



        public Player()
        {
            Id = 0;
            Name = "Default";
        }
        public Player(int id, string name, string color)
        {
            Id = id;
            Name = name;
            ColorOfPawn = color;
            AddPawn();
        }

        public void AddPawn()
        {
            pawn = new Pawn();
        }

        public void CheckPlayerPosition(ref Player people)
        {
            if (people.pawn.Position[0] != 0)
            {
                pawnPos.AppendLine($"Position 0:{people.pawn.Position[0]}");
            }
            if (people.pawn.Position[1] != 0)
            {
                pawnPos.AppendLine($"Position 1:{people.pawn.Position[1]}");
            }
            if (people.pawn.Position[2] != 0)
            {
                pawnPos.AppendLine($"Position 2:{people.pawn.Position[2]}");
            }
            if (people.pawn.Position[3] != 0)
            {
                pawnPos.AppendLine($"Position 3:{people.pawn.Position[3]}");
            }

            for (int i = 0; i < pawnPos.ToString().Length; i++)
            {
                Console.Write(pawnPos[i].ToString());
            }
            pawnPos.Clear();
        }
    }
}
