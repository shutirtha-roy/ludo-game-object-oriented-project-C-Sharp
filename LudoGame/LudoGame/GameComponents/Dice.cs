using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.Enumerators;
using LudoGame.InputOutput;
using LudoGame.Game;

namespace LudoGame.GameComponents
{
    public class Dice : GameComponent, IDice
    {
        public int Sides { get; set; }
        protected Dice DiceModify { get; set; }
        public int DiceNumber { get; set; }
        public int DiceScore { get; set; }
        

        public Dice()
        {
            RandomInt = new Random();
        }
        
        public Dice(int player)
        {
            RandomInt = new Random();
            outputValue.GetOutput(OutputMessage.DiceChooseMessage());
            DiceNumber = inputValue.GetIntInput();
            outputValue.ClearScreen();
            DiceModify = ChooseDice(DiceNumber);
            Sides = DiceModify.Sides;
            outputValue.GetOutput($"{Sides}");
        }

        public Dice ChooseDice(int diceNumber)
        {
            if (diceNumber == (int)DiceType.Six)
            {
                return new DiceSix();
            }
            else if (diceNumber == (int)DiceType.Ten)
            {
                return new DiceTen();
            }
            return null;
        }

        public int RollDice()
        {
            if(RandomInt.Next(0, 3 + 1) == 0)
                return Sides;
            else
                return RandomInt.Next(1, Sides + 1);
        }

        public void RollDice(ref Player people, ref List<Player> player)
        {
            this.player = player;
            outputValue.GetOutput($"{people.Name}({people.ColorOfPawn}){OutputMessage.RollingDice()}");
            people.CheckPlayerPosition(ref people);
            outputValue.GetOutput($"{OutputMessage.ContinueMessage()}");
            inputValue.ReadKey();
            DiceValue = RollDice();
            outputValue.GetOutput($"{people.Name}({people.ColorOfPawn}) rolled {DiceValue}");
        }

        public void PlayerRolledThrice(ref Player people)
        {
            outputValue.GetOutput($"{OutputMessage.RollThreeTimes()}");
            people.pawn.InsideBoardPawnAmount += 3;
            people.pawn.OutsideBoardPawnAmount -= 3;
            people.PlayerMaxDiceCount = 0;
            RollDice(ref people, ref player);
            CheckDiceValue(ref people, DiceValue);
        }


        public void CheckDiceValue(ref Player people, int diceValue)
        {
            if (diceValue == Sides && people.pawn.InsideBoardPawnAmount >= 1)
            {
                FullSidedDice(ref people, diceValue);
            }
            else
            {
                people.pawn.MovePawn(ref people, diceValue, ref player);
            }
        }

        public void FullSidedDice(ref Player people, int diceValue)
        {
            outputValue.GetOutput($"{OutputMessage.UnlockMessage()}");
            UnlockPawn = inputValue.GetCharInput();

            if (UnlockPawn.Equals('y'))
            {
                PawnUnlock(ref people, diceValue);
            }
            else if (UnlockPawn.Equals('n'))
            {
                PawnLock(ref people, diceValue);
            }
        }

        public void PawnUnlock(ref Player people, int diceValue)
        {
            PawnOutside(ref people);
            CheckDiceCount(ref people);
            RollDice(ref people, ref player);
            CheckDiceValue(ref people, DiceValue);
        }

        public void PawnLock(ref Player people, int diceValue)
        {
            people.pawn.MovePawn(ref people, diceValue, ref player);
            RollDice(ref people, ref player);
            CheckDiceValue(ref people, diceValue);
        }

        public void CheckDiceCount(ref Player people)
        {
            if (people.PlayerMaxDiceCount == 3)
            {
                PlayerRolledThrice(ref people);
            }
        }

        public void PawnOutside(ref Player people)
        {
            people.pawn.InsideBoardPawnAmount--;
            people.pawn.OutsideBoardPawnAmount++;
            people.PlayerMaxDiceCount++;
        }
    }
}
