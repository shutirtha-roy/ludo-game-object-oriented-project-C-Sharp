using LudoGame.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.GameComponents
{
    public interface IDice
    {
        public Dice ChooseDice(int diceNumber);
        public int RollDice();
        public void RollDice(ref Player people, ref List<Player> player);
        public void PlayerRolledThrice(ref Player people);
        public void CheckDiceValue(ref Player people, int diceValue);
        public void FullSidedDice(ref Player people, int diceValue);
        public void PawnUnlock(ref Player people, int diceValue);
        public void PawnLock(ref Player people, int diceValue);
        public void CheckDiceCount(ref Player people);
        public void PawnOutside(ref Player people);

    }
}
