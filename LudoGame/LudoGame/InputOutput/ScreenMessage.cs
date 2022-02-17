using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.InputOutput
{
    public static partial class OutputMessage
    {
        private static readonly string diceChooseMessage = "************************DICE*************************\n" +
                                                            "Please choose the dice number for the game\nFor Six Sided[Press 0]\n" +
                                                            "For Ten Sided[Press 1]" +
                                                            "\n************************DICE*************************";

        private static readonly string gameStartMessage = "The Ludo Game has been started.\nPlayer 1 will start the Dice Roll and will eventually pass others.";

        private static readonly string rollingDice = "is rolling the Dice.";
        private static readonly string continueMessage = "Press any key to continue";
        private static readonly string rollThreeTimes = "You have rolled 3 times, 2 Pawns will be kept Inside the Board.\nYou need to unlock it again";
        private static readonly string unlockMessage = "Do you want to Unlock the Pawn? [Press y for YES, n for NO]";

        public static string DiceChooseMessage()
        {
            return diceChooseMessage;
        }

        public static string GameStartMessage()
        {
            return gameStartMessage;
        }

        public static string RollingDice()
        {
            return rollingDice;
        }

        public static string ContinueMessage()
        {
            return continueMessage;
        }

        public static string RollThreeTimes()
        {
            return rollThreeTimes;
        }
        public static string UnlockMessage()
        {
            return unlockMessage;
        }
    }
}
