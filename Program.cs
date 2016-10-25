using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            String answer;

            Console.WriteLine("Hello World! Enter a number though.");

            num = Convert.ToInt32(Console.ReadLine());

            for(int a = 1; a < 10; a++)
            {
                num += 10;
                a = num;
            }

            Console.WriteLine("Nice! Is your number " + num + " ?");
            answer = Convert.ToString(Console.ReadLine());

            if(answer == "No")
            {
                Console.WriteLine("Sorry, we screwed up.");
                Console.ReadLine();
            }
            else if(answer == "Yes")
            {
                Console.WriteLine("Nice bro!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I have no idea what you just said. Just type \"exit\" then hit the \"Enter\" key.");
                Console.ReadLine();
            }
        }
    }
}
