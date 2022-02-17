using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.InputOutput
{
    public class InputOutputProcessor : IInput, IOutput
    {
        public void ReadKey()
        {
            Console.ReadKey();
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }

        public int GetIntInput()
        {
            return int.Parse(GetInput());
        }

        public void GetOutput(string message)
        {
            Console.WriteLine(message);
        }

        public void ClearScreen()
        {
            Console.Clear();
        }

        public char GetCharInput()
        {
            return char.Parse(GetInput());
        }
    }
}
