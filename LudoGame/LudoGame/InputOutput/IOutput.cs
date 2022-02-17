using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame.InputOutput
{
    public interface IOutput
    {
        void GetOutput(string message);
        void ClearScreen();
    }
}
