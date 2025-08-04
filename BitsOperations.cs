using C_Advanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    // This class demonstrates the use of bitwise operations to manage different states of a gun only by allocateing 1byte of memmory.
    // Good to use for flags states
    class Gun
    {
        // 00000000 -> cannot shoot
        // 00000001 -> classic dmg
        // 00000010 -> stun dmg
        // 01000000 -> poison dmg
        public byte state;

        public void Shoot()
        {
            if ((state & 0b00000001) != 0)
            {
                Console.WriteLine("Shooting with classic damage!");
            }
            if ((state & 0b00000010) != 0)
            {
                Console.WriteLine("Shooting with stun damage!");
            }
            if ((state & 0b01000000) != 0)
            {
                Console.WriteLine("Shooting with poison damage!");
            }
        }

        public void EnableClassicDamage()
        {

            state = 1 << 0; // Set the first bit to 1
        }

        public void EnableStunDamage()
        {
            state = 1 << 1; // Set the second bit to 1
        }

        public void EnablePoisonDamage()
        {
            state = 1 << 6; // Set the seventh bit to 1
        }
    }
}

//public static void Main(string[] args)
//{
//    Gun gun = new Gun();
//    gun.EnableClassicDamage();

//    gun.Shoot();
//    gun.EnableStunDamage();
//    gun.Shoot();
//    gun.EnablePoisonDamage();
//    gun.Shoot();

//}