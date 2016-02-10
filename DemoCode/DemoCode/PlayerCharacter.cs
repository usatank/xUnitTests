using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class PlayerCharacter
    {
        public PlayerCharacter()
        {
            Name = GenerateName();
            IsNoob = true;
            CreateStartingWeapons();
        }

        public int Health { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public bool IsNoob { get; set; }

        public List<string> Weapons { get; set; }

        private string GenerateName()
        {
            var names = new[]
            {
                "Name1",
                "Name2",
                "Name3",
                "Name4"
            };

            return names[new Random().Next(0, names.Length)];

        }//GenerateName()

        public void CreateStartingWeapons()
        {
            Weapons = new List<string>()
            {
                "Weapon1",
                "Weapon2",
                "Weapon3",
                
            };
        }


        public void Sleep()
        {
            var rnd = new Random();
            var healthIncrease = rnd.Next(1, 101);

            Health += healthIncrease;
        }

    }
}
