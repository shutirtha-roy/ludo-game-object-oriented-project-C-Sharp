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
        public string Message { get; set; }
        public IOutput ShowOutput { get; set; }
        public IInput Key { get; set; }
        public WelcomeScreen()
        {
            ShowOutput = new InputOutputProcessor();
            Key = new InputOutputProcessor();
            DisplayScreen(ShowOutput, Key);
        }

        public void DisplayScreen(IOutput showOutput, IInput key)
        {
            Console.BackgroundColor = ConsoleColor.White;
            showOutput.ClearScreen();
            Console.ForegroundColor = ConsoleColor.Black;
            Message = OutputMessage.WelcomeMessage();
            showOutput.GetOutput(Message);
            key.ReadKey();
            showOutput.ClearScreen();
        }

    }
}
