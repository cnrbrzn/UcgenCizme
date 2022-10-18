using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcgenCizme
{
    public class Draw
    {
        public void Triangle(int triangleLength)
        {
            for (int i = 1; i <= triangleLength; i++)
            {
                for (int j = 0; j < triangleLength - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
