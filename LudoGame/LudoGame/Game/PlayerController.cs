using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.GameComponents;
using LudoGame.Game;
using LudoGame.InputOutput;

namespace LudoGame.Game
{
    public class PlayerController : PlayerWindow
    {
        public IInput inputValue;
        public IOutput outputValue;
        
        public Color color;

        public PlayerController() : base()
        {
            inputValue = new InputOutputProcessor();
            outputValue = new InputOutputProcessor();
            color = new Color(TotalPlayer);
            outputValue.ClearScreen();
            outputValue.GetOutput($"{OutputMessage.PlayerName()} {TotalPlayer}");
            AddAllPlayers(TotalPlayer);
            outputValue.GetOutput(OutputMessage.TotalPlayerMessage());
            PrintAllPlayers();
        }

        public void AddAllPlayers(int totalPlayer)
        {
            for (var i = 1; i <= totalPlayer; i++)
            {
                AddPlayer(new Player(i, inputValue.GetInput(), color.RandomColor[i - 1]));
            }
        }

        public void PrintAllPlayers()
        {
            Person.ForEach(person => outputValue.GetOutput($"{person.Id} {person.Name} {person.ColorOfPawn}"));
        }
    }
}
