using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.InputOutput;

namespace LudoGame.Home
{
    public abstract class WelcomeScreen
    {
        public string message { get; set; }
        public WelcomeScreen()
        {
            IOutput showOutput = new InputOutputProcessor();
            Console.BackgroundColor = ConsoleColor.White;
            showOutput.ClearScreen();
            Console.ForegroundColor = ConsoleColor.Black;
            message = OutputMessage.WelcomeMessage();
            showOutput.GetOutput(message);
            IInput key = new InputOutputProcessor();
            key.ReadKey();
            showOutput.ClearScreen();
            
            
        }

    }
}
