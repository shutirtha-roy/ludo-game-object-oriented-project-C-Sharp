using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.InputOutput;
using LudoGame.GameComponents;
using LudoGame.Enumerators;

namespace LudoGame.Game
{
    public class BoardGame : Game
    {
        public BoardGame()
        {
            outputValue = new InputOutputProcessor();
            inputValue = new InputOutputProcessor();
            outputValue.GetOutput(OutputMessage.GameStartMessage());
            StartGame();
        }

        public BoardGame(List<Player> person, Dice dice)
        {
            outputValue = new InputOutputProcessor();
            inputValue = new InputOutputProcessor();
            player = person;
            this.dice = dice;
            dice.player = person;
            StartGame();
        }

        public void StartGame()
        {
            while (true)
            {
                foreach (Player people in player)
                {
                    people.PlayerMaxDiceCount = 0;
                    individualPlayer = people;
                    dice.RollDice(ref individualPlayer, ref player);
                    dice.CheckDiceValue(ref individualPlayer, dice.DiceValue);
                    outputValue.GetOutput($"{people.Name}({people.ColorOfPawn}) has {people.pawn.OutsideBoardPawnAmount} Pawns");
                    outputValue.GetOutput("");
                }
            }
        }
    }
}
