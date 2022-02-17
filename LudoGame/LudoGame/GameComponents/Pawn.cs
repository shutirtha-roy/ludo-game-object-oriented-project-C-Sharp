using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.Game;
using LudoGame.Enumerators;
using LudoGame.InputOutput;

namespace LudoGame.GameComponents
{
    public class Pawn : GameComponent, IPawn
    {
        public int[] Position { get; set; }
        public int InsideBoardPawnAmount { get; set; }
        public int OutsideBoardPawnAmount { get; set; }
        public int WinBoardPawnAmount { get; set; }
        public PawnPosition position;


        public Pawn()
        {
            InsideBoardPawnAmount = (int)PawnCondition.AllPawn;
            OutsideBoardPawnAmount = (int)PawnCondition.NoPawn;
            Position = new int[(int)PawnCondition.AllPawn];
        }


        public void MovePawn(ref Player people, int diceValue, ref List<Player> player)
        {
            DiceValue = diceValue;
            this.player = player;
            if (people.pawn.OutsideBoardPawnAmount == (int)PawnCondition.NoPawn)
            {
            }
            else if (people.pawn.OutsideBoardPawnAmount == (int)PawnCondition.OnePawn)
            {
                OnePawnUnlocked(ref people);
            }
            else if (people.pawn.OutsideBoardPawnAmount == (int)PawnCondition.TwoPawn)
            {
                TwoPawnUnlocked(ref people);
            }
            else if (people.pawn.OutsideBoardPawnAmount == (int)PawnCondition.ThreePawn)
            {
                ThreePawnUnlocked(ref people);
            }
            else if (people.pawn.OutsideBoardPawnAmount == (int)PawnCondition.AllPawn)
            {
                AllPawnUnlocked(ref people);
            }
        }

        public void OnePawnUnlocked(ref Player people)
        {
            MoveFirstPawn(ref people);
        }

        public void TwoPawnUnlocked(ref Player people)
        {
            outputValue.GetOutput($"{OutputMessage.TwoPawnUnlockedMessage()}");
            CheckPawnNumber = inputValue.GetIntInput();
            if (CheckPawnNumber == (int)PawnCondition.OnePawn)
            {
                MoveFirstPawn(ref people);
            }
            else if (CheckPawnNumber == (int)PawnCondition.TwoPawn)
            {
                MoveSecondPawn(ref people);
            }
        }

        public void ThreePawnUnlocked(ref Player people)
        {
            outputValue.GetOutput($"{OutputMessage.ThreePawnUnlockedMessage()}");
            CheckPawnNumber = inputValue.GetIntInput();
            if (CheckPawnNumber == (int)PawnCondition.OnePawn)
            {
                MoveFirstPawn(ref people);
            }
            else if (CheckPawnNumber == (int)PawnCondition.TwoPawn)
            {
                MoveSecondPawn(ref people);
            }
            else if (CheckPawnNumber == (int)PawnCondition.ThreePawn)
            {
                MoveThirdPawn(ref people);
            }
        }

        public void AllPawnUnlocked(ref Player people)
        {
            outputValue.GetOutput($"{OutputMessage.AllPawnUnlockedMessage()}");
            CheckPawnNumber = inputValue.GetIntInput();
            if (CheckPawnNumber == (int)PawnCondition.OnePawn)
            {
                MoveFirstPawn(ref people);
            }
            else if (CheckPawnNumber == (int)PawnCondition.TwoPawn)
            {
                MoveSecondPawn(ref people);
            }
            else if (CheckPawnNumber == (int)PawnCondition.ThreePawn)
            {
                MoveThirdPawn(ref people);
            }
            else if (CheckPawnNumber == (int)PawnCondition.FourthPawn)
            {
                MoveFourthPawn(ref people);
            }
        }

        public void MoveFirstPawn(ref Player people)
        {
            if (people.pawn.Position[0] + DiceValue <= (int)PawnPath.FinalPosition)
            {
                people.pawn.Position[0] += DiceValue;
            }

            outputValue.GetOutput($"Pawn 1 moved by {people.pawn.Position[0]}");
            position = new PawnPosition(ref people, people.pawn.Position[0], 0, ref player);
        }

        public void MoveSecondPawn(ref Player people)
        {
            if (people.pawn.Position[1] + DiceValue <= (int)PawnPath.FinalPosition)
            {
                people.pawn.Position[1] += DiceValue;
            }

            outputValue.GetOutput($"Pawn 2 moved by {people.pawn.Position[1]}");
            position = new PawnPosition(ref people, people.pawn.Position[1], 1, ref player);
        }

        public void MoveThirdPawn(ref Player people)
        {
            if (people.pawn.Position[2] + DiceValue <= (int)PawnPath.FinalPosition)
            {
                people.pawn.Position[2] += DiceValue;
            }

            outputValue.GetOutput($"Pawn 3 moved by {people.pawn.Position[2]}");
            position = new PawnPosition(ref people, people.pawn.Position[2], 2, ref player);
        }

        public void MoveFourthPawn(ref Player people)
        {
            if (people.pawn.Position[3] + DiceValue <= (int)PawnPath.FinalPosition)
            {
                people.pawn.Position[3] += DiceValue;
            }

            outputValue.GetOutput($"Pawn 4 moved by {people.pawn.Position[3]}");
            position = new PawnPosition(ref people, people.pawn.Position[3], 3, ref player);
        }
        
       
    }
}
