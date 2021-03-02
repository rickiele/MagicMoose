using System;


Main();

void Main()
{
    // Make it pretty
    Console.Title = "Magic Moose";
    Console.ForegroundColor = ConsoleColor.Green;

    // Magic Moose asks you a question
    MagicMooseAsks();
}


// Function for Magic Moose asking you a question
void MagicMooseAsks()
{
    // Magic Moose asks you... \n similar to line break
    Console.WriteLine("Hello, I am Magic Moose. \nSomething troubling you? Ask me a question.");

    // Read user's question
    string YourQuestion = Console.ReadLine();

    // If statement - If space is empty then do this, else run MagicMooseAnswer
    if (string.IsNullOrWhiteSpace(YourQuestion))
    {
        MagicalMooseWisdom("I wasn't going to answer anyway.");
    }
    else
    {
        MagicalMooseWisdom("What the");
    }
}

// Function for the Magic Moose to answer
string MagicMooseAnswer()
{
    // Generate a random number
    Random Number = new Random();
    // Add minimum and max values
    int RandomNumber = Number.Next(0, 19);

    // Switch statement to have the randomized number correspond to the strings
    switch (RandomNumber)
    {
        case 0:
            Console.WriteLine("As I see it, yes.");
            break;
        case 1:
            Console.WriteLine("Ask again later.");
            break;
        case 2:
            Console.WriteLine("Better not tell you now.");
            break;
        case 3:
            Console.WriteLine("Cannot predict now.");
            break;
        case 4:
            Console.WriteLine("Concentrate and ask again.");
            break;
        case 5:
            Console.WriteLine("Don’t count on it.");
            break;
        case 6:
            Console.WriteLine("It is certain.");
            break;
        case 7:
            Console.WriteLine("It is decidedly so.");
            break;
        case 8:
            Console.WriteLine("Most likely.");
            break;
        case 9:
            Console.WriteLine("My reply is no.");
            break;
        case 10:
            Console.WriteLine("My sources say no.");
            break;
        case 11:
            Console.WriteLine("Outlook not so good.");
            break;
        case 12:
            Console.WriteLine("Outlook good.");
            break;
        case 13:
            Console.WriteLine("Reply hazy, try again.");
            break;
        case 14:
            Console.WriteLine("Signs point to yes.");
            break;
        case 15:
            Console.WriteLine("Very doubtful.");
            break;
        case 16:
            Console.WriteLine("Without a doubt.");
            break;
        case 17:
            Console.WriteLine("Yes.");
            break;
        case 18:
            Console.WriteLine("Yes – definitely..");
            break;
        case 19:
            Console.WriteLine("You may rely on it.");
            break;
    }

    return RandomNumber;
}


// Function for Magic Moose to provide an answer
void MagicalMooseWisdom(string BitOfWisdom)
{
    Console.WriteLine($@"
                                                _.--^^^--,
                                                .'          `\
            .-^^^^^^-.                      .'              |
            /          '.                   /            .-._/
            |             `.                |             |
            \              \          .-._ |          _   \
            `^^'-.         \_.-.     \   `          ( \__/
                    |             )     '=.       .,   \
                /             (         \     /  \  /
                /`               `\        |   /    `'
                '..-`\        _.-. `\ _.__/   .=.
                    |  _    / \  '.-`    `-.'  /
                    \_/ |  |   './ _     _  \.'
                        '-'    | /       \ |
                                |  .-. .-.  |
                                \ / o| |o \ /
                                |   / \   |    {BitOfWisdom}
                                / `^`   `^` \
                                /             \
                                | '._.'         \
                                |  /             |
                                \ |             |
                                ||    _    _   /
                                /|\  (_\  /_) /
                                \ \'._  ` '_.'
                                `^^` `^^^`
                ");
}

