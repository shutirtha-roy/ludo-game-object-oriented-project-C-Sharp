using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LudoGame.InputOutput;

namespace LudoGame.Home
{
    public class Instruction
    {
        public string Message { get; set; }

        public Instruction()
        {
            Message = getMessage();
            IOutput output = new InputOutputProcessor();
            output.GetOutput(Message);
        }

        public string getMessage()
        {
            return OutputMessage.InstructionMessage();
        }
    }
}
