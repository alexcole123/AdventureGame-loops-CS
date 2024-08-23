Console.WriteLine("Welcome to the Adventure Game!");
System.Console.WriteLine("Enter your character's name");
string playerName = Console.ReadLine();
Console.WriteLine("Choose your character type (Warrior, Wizard, Archer)");
string characterType = Console.ReadLine();

System.Console.WriteLine($"You, {playerName} the {characterType} find yourself at the edge of a dark forest");

System.Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");

string choice1 = Console.ReadLine();

if (choice1.ToLower() == "enter")
{
    System.Console.WriteLine("You bravely enter the forest");

}
else
{
    System.Console.WriteLine("You decide to camp out and wait for the daylight.");
}

bool gameContinues = true;

while(gameContinues)
{
    System.Console.WriteLine("You came to a fork in the road. Go left or right?");
    string direction = Console.ReadLine();
    if(direction.ToLower() == "left")
    {
        System.Console.WriteLine("You found a treasure chest!");
        gameContinues = false;

    }
    else
    {
        System.Console.WriteLine("You encountered a wild beast!");
        System.Console.WriteLine("Fight or flee? (fight/flee)");
        string fightChoice = Console.ReadLine();
        if(fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck > 5)
            {
                System.Console.WriteLine("You beat the wild beast!");
                if (luck > 8)
                {
                    System.Console.WriteLine("The wild beast dropped a treasure!");
                }
            }
            else
            {
                System.Console.WriteLine("The beast attacked you where you didn't expect it");
                System.Console.WriteLine("It rammed it's tusk int your chest and you bleed out!");
                gameContinues = false;
            }
        }
    }
}
System.Console.WriteLine("Game over!");
System.Console.WriteLine("Thank you for playing the game!");