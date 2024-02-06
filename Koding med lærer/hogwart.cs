using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Koding_med_lærer
{
    internal class hogwart
    {
        List<harrypotter> Students { get; set; }

        public hogwart(List<harrypotter> charList)
        {
            Students = charList;
        }
        
        public harrypotter ChooseChar()
        {
            Console.WriteLine("Who would you like to play as?"); ;
            foreach (var chars in Students)
            {
                Console.WriteLine($"{chars.Name}, charid: {chars.CharId}");
            }
            var charInput = Console.ReadLine();
            var selectedStudent = Students.Where(student => student.CharId == int.Parse(charInput)).First();
            return selectedStudent;
        }
        public harrypotter GetReciver()
        {
            Console.WriteLine("Who would you like to send a message to?"); ;
            foreach (var chars in Students)
            {
                Console.WriteLine($"{chars.Name}, charid: {chars.CharId}");
            }
            var charInput = Console.ReadLine();
            var selectedStudent = Students.Where(student => student.CharId == int.Parse(charInput)).First();
            return selectedStudent;
        }
    }
}
