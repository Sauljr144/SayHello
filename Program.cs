//---- Challange #1 ----//

//Challege is to be able to input a name and have the computer say "Hello ______"

//----Say Hello----//

string playAgain = "Y";

//This is a variable to store the input of the user//
string name1;

while(playAgain != "N")
{
    //This will display the question "What is your name?"//
    Console.WriteLine("What is your name?");

    //stores users input
    name1 = Console.ReadLine();

    //this wiill display users input for example "Hello, T-1000" by using interpolatioon

    Console.WriteLine($"Hello, {name1}");

    Console.WriteLine("Do you want to play again? Y/N");
    playAgain = Console.ReadLine().ToUpper();
}

Console.WriteLine("Bye!");
