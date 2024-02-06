using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koding_med_lærer
{
    internal class harrypotter
    {
        public string Name { get; set; }
        private string House { get; set; }
        private string Items { get; set; }
        public bool Owl { get; set; }

        public int CharId { get; set; }
        
        List<string> spell { get; set; }
        private List<string> inventory { get; set; }

        public harrypotter(string name, string house, string items, bool owl, int charId)
        {
            Name = name;
            House = house;
            Items = items;
            Owl = owl;
            CharId = charId;
            spell = new List<string>() { "hokus pokus", "vingardium leviosa" };
            inventory = new List<string>();
             
        }

        List<string> mailbox = new List<string>();

        public void addLetterToMailbox(string message)
        {
            mailbox.Add(message);
        }

        public bool checkIfHasOwl()
        {
            if (Owl == true)
            {
                return true;
            }
            else return false;
        }

        public void SendLetter(harrypotter reciver)
        {
                Console.WriteLine("You own an owl. You may send a letter. Write what you want to send:");
                string sentletter = Console.ReadLine();
                reciver.addLetterToMailbox(sentletter);
                Console.WriteLine("Letter sent and delivered to another persons mailbox");
        }

        public void Checkinbox()
        {
            Console.WriteLine("Mailbox content:");
            foreach (var letter in mailbox)
            {
                Console.WriteLine(letter);
            }
        }
       
       public void Buysomething(string iteminput)
        {
            inventory.Add(iteminput);
            if (iteminput == "Owl")
            {
                bool owl = true;
            }

        }

       public void Openbackpack()
       {
           foreach (var inventorys in inventory)
           {
           Console.WriteLine($"Your {House} hat is inside of you backpack along with {Items}. The newly purchased {inventorys} is also here.");
           }
       }

        public void Introduction()
        {
            Console.WriteLine(
                $"The students name is: {Name}, the house the student is a part of is: {House} and the items the student brings is: {Items}");
        }

        public void Castspell()
        {
            Console.WriteLine("What spell would you like to cast?");
            Console.WriteLine("Hokus pokus (1) lumgardium leviosa (2)");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("You cast Hokus pokus! It sounded really cool but nothing happened");
            }
            else
            {
                Console.WriteLine("You cast lumgardium leviosa. Your teacher flies away.");
            }
        }
    }
}
