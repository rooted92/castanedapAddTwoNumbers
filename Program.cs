//Pedro Castaneda
//10-17-2022
//Add Two Numbers
//Create a program that will take two numbers given by user and adds them together and shows the sum. Have validation features

bool run = true;

while(run)
{
    bool numCheck1 = false;
    bool numCheck2 = false;
    bool stringValidation = true;
    int validNum1 = 0;
    int validNum2 = 0;
    int total;
    string userInput;
     
    Console.WriteLine("Welcome to Add Two Numbers!");
    Console.WriteLine("Please give me two numbers to add together");
    Console.WriteLine();
    Console.WriteLine("Enter first number:");

    while(!numCheck1)
    {
        numCheck1 = Int32.TryParse(Console.ReadLine(), out validNum1);
        if(numCheck1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter a number!");
        }
    }
    Console.WriteLine("Enter second number:");
    while(!numCheck2)
    {
        numCheck2 = Int32.TryParse(Console.ReadLine(), out validNum2);
        if(numCheck2)
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter a number!");
        }
    }
    total = validNum1 + validNum2;
    Console.WriteLine($"{validNum1} + {validNum2} = {total}");
    Console.WriteLine("Would like to add another pair of numbers? (yes/no)");
    while(stringValidation)
    {
        userInput = Console.ReadLine().ToLower();
        if(userInput == "yes" || userInput == "y")
        {
            stringValidation = false;
            run = true;
        }
        else if(userInput == "no" || userInput == "n")
        {
            stringValidation = false;
            run = false;
        }
        else
        {
            Console.WriteLine("Please enter yes or no");
            stringValidation = true;
        }
    }
}
