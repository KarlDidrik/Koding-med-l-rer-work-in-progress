using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koding_med_lærer
{
    internal class Voldemort
    {
        private int Health { get; set; }
        private int Damage { get; set; }


        public Voldemort(int health, int damage)
        {
            health = health;
            damage = damage;
        }

        public void Fight(Voldemort opponent)
        {
            while (Health > 0 && opponent.Health > 0)
            {
                Console.WriteLine($"Voldemort's Health: {Health}");
                Console.WriteLine($"Your Health: {opponent.Health}");

                opponent.TakeDamage(Damage);

                if (opponent.Health <= 0)
                {
                    Console.WriteLine("You defeated Voldemort!");
                    break;
                }

                TakeDamage(opponent.Damage);

                if (Health <= 0)
                {
                    Console.WriteLine("Voldemort defeated you!");
                    break;
                }

                Console.WriteLine("------------------------");
            }
        }
        private void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"Voldemort dealt {damage} damage to you!");
        }

    }
}
