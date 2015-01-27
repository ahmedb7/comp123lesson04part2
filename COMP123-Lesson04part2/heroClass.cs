using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04part2
{
    class hero
    {
        //Private Properties ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        bool bravery = true;
        private int health;
        private int smarts;
        private string gender;
        //Constructor+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public hero(int health, int smarts, string gender)
    {
        this.health = health;
        this.smarts = smarts;
        this.gender = gender;

    }
        public void doesGoodThings()
        {
            Console.WriteLine("Doin'good things....YEAH");
        }
    }
}
