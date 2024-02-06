
using System.Runtime.InteropServices;
using Koding_med_lærer;

var student1Harrypotter = new harrypotter("Dodda", "Huffelpuff", "Owl", true, 1);
var student2Harrypotter = new harrypotter("Gundersen", "Slytherin", "Magic snacks", false, 2);
var student3Harrypotter = new harrypotter("Ole Lukkøye", "Raven Claw", "Maggic poweder", false, 3);
List<harrypotter> Studenlist = new List<harrypotter>(){student1Harrypotter, student2Harrypotter, student3Harrypotter};
var Magicstore = new Magicstore();
var studentlist = new hogwart(Studenlist);
var currentPlayer = studentlist.ChooseChar();





student1Harrypotter.Introduction();
while (true)
{
    Console.WriteLine($"You are currently playing as {currentPlayer.Name}");
Console.WriteLine($"Hello wizard. What would you like to do? press (1) to visit the Magic store and (2) to cast a magical spell. If you want to (3) open your backpack press 3. If you would like to (4) buy something press 4. If you would like to (5) send a letter press 5. Press (6) if you want to check your inbox. Press (7) if you want to change character.");

var input = Console.ReadLine();

switch (input)
{
    case "1": 
        Magicstore.Store(currentPlayer);
        break;
    case "2":
        currentPlayer.Castspell();
        break;
    case "3":
        currentPlayer.Openbackpack();
        break;
    case "4":  
        currentPlayer.Buysomething(input);
        break;
    case "5":
        if (currentPlayer.checkIfHasOwl() == true)
        {
            var reciver = studentlist.GetReciver();
            currentPlayer.SendLetter(reciver);
        }
        else Console.WriteLine("You don't own an owl. It is then impossible to send mail. There is possible to buy one from the magic store.");
            break;
    case "6":
        currentPlayer.Checkinbox();
        break;
    case "7":
        currentPlayer = studentlist.ChooseChar();
        break;
    default: break;
}

}
