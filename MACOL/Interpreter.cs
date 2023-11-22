using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACOL
{
    internal class Interpreter
    {
        int accumulator = 0;
        int[] memory = new int[1000];


        public void ProcessCode(string code)
        {
            for (int i = 0; i < code.Length; i++)
            {

                switch (code[i])
                {
                    case '=':
                        accumulator = ReadValue(ref i, code);
                        break;
                    case '+':
                        accumulator += ReadValue(ref i, code);
                        break;
                    case '-':
                        accumulator -= ReadValue(ref i, code);
                        break;
                    case 'w':
                        memory[ReadValue(ref i, code)] = accumulator;
                        break;
                    case 'r':
                        accumulator = memory[ReadValue(ref i, code)];
                        break;
                    case 'c':
                        Console.WriteLine(memory[ReadValue(ref i, code)]);
                        break;
                    default:
                        break;
                }
            }
        }

        public void MemoryDump()
        {
            for (int i = 0; i < memory.Length; i++)
                Console.Write("{0}\t", memory[i]);
        }


        private static int ReadValue(ref int i, string code)
        {
            string buffer = "";

            i += 1;

            while (i < code.Length && char.IsDigit(code[i]))
                buffer += code[i++];

            i -= 1;

            return Convert.ToInt32(buffer);
        }
    }
}
