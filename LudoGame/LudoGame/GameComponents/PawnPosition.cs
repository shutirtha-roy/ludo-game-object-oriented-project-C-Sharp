using LudoGame.Enumerators;
using LudoGame.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.GameComponents
{
    public class PawnPosition : Pawn
    {
        public PawnColor color;
        
        public PawnPosition()
        {

        }
        
        public PawnPosition(ref Player people, int positionPawnValue, int pawnPositon, ref List<Player> player)
        {
            this.player = player;
            CheckPawnPosition(ref people, positionPawnValue, pawnPositon);
        }

        public void CheckPawnPosition(ref Player people, int positionPawnValue, int pawnPositon)
        {
            if (positionPawnValue == (int)PawnPath.FinalPosition)
            {
                ReachedDestination(ref people, positionPawnValue, pawnPositon);
            }
            else if (positionPawnValue % 13 == (int)PawnPath.SafePosition)
            {
                outputValue.GetOutput($"{people.Name} can't attack other pawn");
            }
            else if (positionPawnValue <= (int)PawnPath.NonAttackPosition)
            {
                CheckCompetitorPawn(ref people, positionPawnValue, pawnPositon);
            }
        }

        public void ReachedDestination(ref Player people, int positionPawnValue, int pawnPositon)
        {
            people.pawn.OutsideBoardPawnAmount--;
            people.pawn.WinBoardPawnAmount++;

            if (people.pawn.WinBoardPawnAmount == (int)PawnCondition.AllPawn)
            {
                outputValue.GetOutput($"The Player {people.Name} has won");
            }
        }

        public void CheckCompetitorPawn(ref Player people, int positionPawnValue, int pawnPositon)
        {
            int count = 0;

            foreach (Player competitor in player)
            {
                if (competitor.Name != people.Name)
                {
                    count = 0;
                    foreach (int opponentPawnPosition in competitor.pawn.Position)
                    {
                        if (positionPawnValue % 13 == opponentPawnPosition % 13)
                        {
                            CheckAllPawnValue(people, competitor, positionPawnValue, opponentPawnPosition, count);
                        }
                        count++;
                    }
                }
            }
        }

        public void CheckAllPawnValue(Player people, Player competitor, int positionPawnValue, int opponentPawnPosition, int positionIndex)
        {
            int posPawn = positionPawnValue / 13;
            int oppPawn = opponentPawnPosition / 13;


            if (people.ColorOfPawn.Equals("Red"))
            {
                color = new PawnColor(people, competitor, positionPawnValue, opponentPawnPosition, positionIndex, posPawn, oppPawn, "Red");
                
            }
            else if (people.ColorOfPawn.Equals("Blue"))
            {
                color = new PawnColor(people, competitor, positionPawnValue, opponentPawnPosition, positionIndex, posPawn, oppPawn, "Blue");
                
            }
            else if (people.ColorOfPawn.Equals("Yellow"))
            {
                new PawnColor(people, competitor, positionPawnValue, opponentPawnPosition, positionIndex, posPawn, oppPawn, "Yellow");
                
            }
            else if (people.ColorOfPawn.Equals("Green"))
            {
                new PawnColor(people, competitor, positionPawnValue, opponentPawnPosition, positionIndex, posPawn, oppPawn, "Green");
                
            }
        }

        public void CompetitorPawnLock(ref Player competitor, ref int positionIndex)
        {
            competitor.pawn.InsideBoardPawnAmount++;
            competitor.pawn.OutsideBoardPawnAmount--;
            competitor.pawn.Position[positionIndex] = 0;
        }
    }
}
