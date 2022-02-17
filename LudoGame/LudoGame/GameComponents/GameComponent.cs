using LudoGame.Game;
using LudoGame.InputOutput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.GameComponents
{
    public abstract class GameComponent
    {
        public IInput inputValue = new InputOutputProcessor();
        public IOutput outputValue = new InputOutputProcessor();
        public int DiceValue { get; set; }
        public int CheckPawnNumber { get; set; }
        public List<Player> player;
        public char UnlockPawn { get; set; }
        public Random RandomInt { get; set; }

    }
}
