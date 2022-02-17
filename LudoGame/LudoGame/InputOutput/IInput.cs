using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.InputOutput
{
    public interface IInput
    {
        void ReadKey();
        string GetInput();
        int GetIntInput();
        char GetCharInput();
    }
}
