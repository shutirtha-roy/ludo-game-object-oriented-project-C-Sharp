using LudoGame.GameComponents;
using LudoGame.InputOutput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.Game;

namespace LudoGame.Game
{
    public abstract class Game
    {
        public IOutput outputValue;
        public IInput inputValue;
        public List<Player> player;
        public Dice dice;
        public Player individualPlayer;
        public int DiceValue { get; set; }
        
        public StringBuilder pawnPos = new StringBuilder();





    }
}
