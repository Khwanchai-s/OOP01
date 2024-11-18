using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    internal class DrawChar
    {
        public int size { get; set; }
        public string letter { get; set; }

        public DrawChar()
        {
            size = 5;
            letter = "X";
        }
        public DrawChar(int size, string letter)
        {
            this.size = size;
            this.letter = letter;
        }

        public string Triangle()
        {
            string result = "";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                { 
                    result += letter + " ";
                }
                result += Environment.NewLine;
            }
            return result;
        }

        public string Square()
        {
            string result = "";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    result += letter + " ";
                }
                result += Environment.NewLine;
            }
            return result;
        }
    }
}
