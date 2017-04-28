using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Weapon
    {
        bool melee;
        string name;
        int ammo;
        int damage;
        int accuracy;
        int burst;
        public Weapon(bool isMelee,string whatName,int whatAmmo,int whatDamage,int whatAccuracy,int whatburst)    //Reeeeeeeee
        {
            melee = isMelee;
            name = whatName;
            ammo = whatAmmo;
            damage = whatDamage;
            accuracy = whatAccuracy;
            burst = whatburst;

        }
    }
}
