using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.InputOutput;
using LudoGame.Enumerators;
using LudoGame.Game;

namespace LudoGame.Home
{
    public class HomeMenu
    {
        private IInput inputValue;
        private IOutput outputValue;

        public HomeMenu()
        {
            inputValue = new InputOutputProcessor();
            outputValue = new InputOutputProcessor();
            int homeInput = inputValue.GetIntInput();
            outputValue.ClearScreen();
            int homeCondition = (int)Menu(homeInput);
            CheckMenuCondition(homeCondition);
        }
        
        public LudoHome Menu (int homeInput)
        {
            if (Match<LudoHome>(homeInput, LudoHome.Start))
            {
                return LudoHome.Start;
            }
            else if (Match<LudoHome>(homeInput, LudoHome.Instructions))
            {
                Instruction instruct = new Instruction();
                return LudoHome.Instructions;
            }
            else if (Match<LudoHome>(homeInput, LudoHome.About))
            {
                About about = new About();
                return LudoHome.About;
            }
            return LudoHome.Default;
        }

        public void CheckMenuCondition(int homeCondition)
        {
            while (homeCondition != (int)LudoHome.Start)
            {
                outputValue.GetOutput(OutputMessage.AnyKeyMessage());
                inputValue.ReadKey();
                outputValue.ClearScreen();
                outputValue.GetOutput(OutputMessage.HomeMessage());
                homeCondition = (int)Menu(inputValue.GetIntInput());
            }
        }

        public bool Match<T>(int homeInput, T menu) where T: Enum
        {
            return (int)homeInput == Convert.ToInt32(menu);
        }

    }
}
