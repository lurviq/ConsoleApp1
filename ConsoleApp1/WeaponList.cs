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
            list.Add(new Weapon(true, "Gladius", 0, 2, 70, 4, false));          // list.Add(new Weapon(true, "", 0, 0, 0, 0, true/false));
            list.Add(new Weapon(true, "Pneumatic Fist", 0, 4, 80, 1, false));   // Clean slate ^^^^^^^^^^   Name,ammo,accuracy,burst,true/false twohanded
            list.Add(new Weapon(true, "Zweihänder", 0, 7, 60, 1, ));

        }

    }
}
