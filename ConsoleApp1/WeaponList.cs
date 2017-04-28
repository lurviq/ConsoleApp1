using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WeaponList
    {
        List<Weapon> list;
        public WeaponList()
        {
            list.Add(new Weapon(true, "Gladius", 0, 2, 70, 2));          // These are weapons
            list.Add(new Weapon(true, "Pneumatic Fist", 0, 4, 50, 1));    

        }

    }
}
