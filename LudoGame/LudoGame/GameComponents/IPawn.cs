using LudoGame.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.GameComponents
{
    public interface IPawn
    {
        public void MovePawn(ref Player people, int diceValue, ref List<Player> player);
        public void OnePawnUnlocked(ref Player people);
        public void TwoPawnUnlocked(ref Player people);
        public void ThreePawnUnlocked(ref Player people);
        public void AllPawnUnlocked(ref Player people);
        public void MoveFirstPawn(ref Player people);
        public void MoveSecondPawn(ref Player people);
        public void MoveThirdPawn(ref Player people);
        public void MoveFourthPawn(ref Player people);


    }
}
