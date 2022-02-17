using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.Game;
using LudoGame.InputOutput;

namespace LudoGame.GameComponents
{
    public abstract class PlayerWindow
    {
        public List<Player> Person { get; set; }
        public int TotalPlayer { get; set; }
        public Dice dice { get; set; }

        public PlayerWindow()
        {
            IOutput output = new InputOutputProcessor();
            IInput input = new InputOutputProcessor();
            Person = new List<Player>();
            output.GetOutput(OutputMessage.NoOfPlayerChooseMessage());
            TotalPlayer = input.GetIntInput();
        }

        public void AddPlayer(Player player)
        {
            Person.Add(player);
        }
    }
}
