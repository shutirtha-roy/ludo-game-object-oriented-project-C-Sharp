using LudoGame.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.GameComponents
{
    public class PawnColor : PawnPosition
    {
        public PawnColor()
        {

        }
        
        public PawnColor(Player people, Player competitor, int positionPawnValue, int opponentPawnPosition, int positionIndex, int posPawn, int oppPawn, string color)
        {
            if(color.Equals("Red"))
            {
                PlayerPawnRed(people, competitor, positionPawnValue, opponentPawnPosition, positionIndex, posPawn, oppPawn);
            }
            else if(color.Equals("Blue"))
            {
                PlayerPawnBlue(people, competitor, positionPawnValue, opponentPawnPosition, positionIndex, posPawn, oppPawn);
            }
            else if(color.Equals("Yellow"))
            {
                PlayerPawnYellow(people, competitor, positionPawnValue, opponentPawnPosition, positionIndex, posPawn, oppPawn);
            }
            else if (color.Equals("Green"))
            {
                PlayerPawnGreen(people, competitor, positionPawnValue, opponentPawnPosition, positionIndex, posPawn, oppPawn);
            }
        }

        public void PlayerPawnRed(Player people, Player competitor, int positionPawnValue, int opponentPawnPosition, int positionIndex, int posPawn, int oppPawn)
        {
            if (competitor.ColorOfPawn == "Blue")
            {
                if (posPawn == oppPawn + 2)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
            else if (competitor.ColorOfPawn == "Yellow")
            {
                if (posPawn == oppPawn + 3)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
            else if (competitor.ColorOfPawn == "Green")
            {
                if (posPawn == oppPawn + 1)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
        }

        public void PlayerPawnBlue(Player people, Player competitor, int positionPawnValue, int opponentPawnPosition, int positionIndex, int posPawn, int oppPawn)
        {
            if (competitor.ColorOfPawn == "Red")
            {
                if (posPawn == oppPawn + 2)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
            else if (competitor.ColorOfPawn == "Yellow")
            {
                if (posPawn == oppPawn + 1)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
            else if (competitor.ColorOfPawn == "Green")
            {
                if (posPawn == oppPawn + 3)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
        }

        public void PlayerPawnYellow(Player people, Player competitor, int positionPawnValue, int opponentPawnPosition, int positionIndex, int posPawn, int oppPawn)
        {
            if (competitor.ColorOfPawn == "Red")
            {
                if (posPawn == oppPawn + 1)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
            else if (competitor.ColorOfPawn == "Blue")
            {
                if (posPawn == oppPawn + 3)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
            else if (competitor.ColorOfPawn == "Green")
            {
                if (posPawn == oppPawn + 2)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
        }

        public void PlayerPawnGreen(Player people, Player competitor, int positionPawnValue, int opponentPawnPosition, int positionIndex, int posPawn, int oppPawn)
        {
            if (competitor.ColorOfPawn == "Red")
            {
                if (posPawn == oppPawn + 3)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
            else if (competitor.ColorOfPawn == "Blue")
            {
                if (posPawn == oppPawn + 1)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
            else if (competitor.ColorOfPawn == "Yellow")
            {
                if (posPawn == oppPawn + 2)
                {
                    CompetitorPawnLock(ref competitor, ref positionIndex);
                    outputValue.GetOutput($"{competitor.Name}'s Pawn {positionIndex + 1} Removed.");
                }
            }
        }
    }
}
