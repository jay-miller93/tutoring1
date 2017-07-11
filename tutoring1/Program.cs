using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoring1
{
    class Program
    {
        static void Main(string[] args)
        {
            BadGuyscs volcanoeMan = new BadGuyscs();
            BadGuyscs badguy2 = new BadGuyscs("Ehhhh", "Street Clothes", 75);
            Console.WriteLine(badguy2.GetPowers());
        }
    }
}
