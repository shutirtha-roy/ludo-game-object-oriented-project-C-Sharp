using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.InputOutput;

namespace LudoGame.Home
{
    public class HomeScreen : WelcomeScreen
    {
        public HomeScreen() : base()
        {
            IOutput showOutput = new InputOutputProcessor();
            message = OutputMessage.HomeMessage();
            showOutput.GetOutput(message);
        }
    }
}
