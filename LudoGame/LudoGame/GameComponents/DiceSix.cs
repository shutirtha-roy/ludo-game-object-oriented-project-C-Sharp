using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.Enumerators;

namespace LudoGame.GameComponents
{
    public class DiceSix : Dice
    {

        public DiceSix()
        {
            Sides = (int)DiceType.SixSide;
        }
    }
}
