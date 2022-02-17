using System;
using LudoGame.Enumerators;
using LudoGame.Home;
using LudoGame.InputOutput;
using LudoGame.Game;
using LudoGame.GameComponents;

namespace LudoGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            WelcomeScreen welcome = new HomeScreen();
            HomeMenu menu = new HomeMenu();
            PlayerWindow playerControl = new PlayerController();
            BoardGame ludo = new BoardGame(playerControl.Person, new Dice(playerControl.TotalPlayer));
        }
    }
}
