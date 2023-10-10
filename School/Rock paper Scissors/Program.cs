int playerscore = 0;
int enemyscore = 0;

Console.WriteLine("Hello, we will be playing rock / paper / scissors!");

while ( enemyscore <= 2 && playerscore <= 2 )
{
    Console.Write("The players score is " + playerscore);
    Console.WriteLine("  The enemies score is " + enemyscore);
    Console.WriteLine("Please select what role do you want to pick: ");
    Console.WriteLine("r for Rock\np for Paper\ns for Scissors\n");
    string playerchoice = Console.ReadLine();

    Random rnd = new Random();
    int enemychoice = rnd.Next(0, 3);
    if (enemychoice == 0)
    {
        Console.WriteLine("The enemy has chosen Rock!");

        switch (playerchoice)
        {
            case "r":
                Console.WriteLine("It's a tie!");
                break;
            case "p":
                Console.WriteLine("You have won!");
                playerscore++;
                break;
            default:
                Console.WriteLine("You have lost!");
                enemyscore++;
                break;
        }
    }
    else if (enemychoice == 1)
    {
        Console.WriteLine("The enemy has chosen Paper!");

        switch (playerchoice)
        {
            case "r":
                Console.WriteLine("You have lost!");
                enemyscore++;
                break;
            case "p":
                Console.WriteLine("It's a tie!");
                break;
            default:
                Console.WriteLine("You have won!");
                playerscore++;
                break;
        }
    }
     
    else if (enemychoice == 2)
        {
            Console.WriteLine("The enemy has chosen Scissors!");

            switch (playerchoice)
            {
                case "r":
                    Console.WriteLine("You have won");
                    playerscore++;
                    break;
                case "p":
                    Console.WriteLine("You have lost!");
                    enemyscore++;
                    break;
                default:
                    Console.WriteLine("It's a tie!");
                    break;
            }
        }
    
}

if (playerscore == 3)
{
    Console.WriteLine("Final Score : Player score : " + playerscore + " Enemy score : " + enemyscore);
    Console.Write("You have won!");
}
else
{
    Console.WriteLine("Final Score : Player score : " + playerscore + " Enemy score : " + enemyscore);
    Console.Write("You have lost!");
}