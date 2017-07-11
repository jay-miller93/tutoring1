using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoring1
{
    class BadGuyscs
    {
        private string costumes;
        private string name;
        private string evilPowers;
        private int strengthLevel;

        public string Costumes { get; set; }
        public string Name { get; set; }
        public string EvilPowers { get; set; }
        public int StrengthLevel { get; set; }

        public BadGuyscs()
        {
            Random random = new Random();
            this.costumes = "A bed sheet";
            this.name = "Volcanotor";
            this.evilPowers = "I can control volcanoes!!";
            this.strengthLevel = random.Next(0, 51);
        }

        public BadGuyscs(string name, string costumes, int strengthLevel)
        {
            this.name = name;
            this.costumes = costumes;
            this.evilPowers = GetPowers();
            this.strengthLevel = strengthLevel;
        }
        public string GetPowers()
        {
            string[] powers = { "Killer Farts", "Mind Control", "Throwing Fire", "Throwing Shade" };
            Random random = new Random();
            string newPower =powers[random.Next(0, powers.Length)];
            return newPower;
        }


    }
}
