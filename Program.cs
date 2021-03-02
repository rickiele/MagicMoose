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
        MagicalMooseWisdom("I wasn't going to respond anyway.");
    }
    else
    {
        MagicalMooseWisdom(MagicMooseAnswer());
    }
}

// Function for the Magic Moose to answer
string MagicMooseAnswer()
{
    string Wisdom = "";

    // Generate a random number
    Random Number = new Random();
    // Add minimum and max values
    int RandomNumber = Number.Next(0, 19);

    // Switch statement to have the randomized number correspond to the strings
    switch (RandomNumber)
    {
        case 0:
            Wisdom = "As I see it, yes.";
            break;
        case 1:
            Wisdom = "Ask again later.";
            break;
        case 2:
            Wisdom = "Better not tell you now.";
            break;
        case 3:
            Wisdom = "Cannot predict now.";
            break;
        case 4:
            Wisdom = "Concentrate and ask again.";
            break;
        case 5:
            Wisdom = "Don’t count on it.";
            break;
        case 6:
            Wisdom = "It is certain.";
            break;
        case 7:
            Wisdom = "It is decidedly so.";
            break;
        case 8:
            Wisdom = "Most likely.";
            break;
        case 9:
            Wisdom = "My reply is no.";
            break;
        case 10:
            Wisdom = "My sources say no.";
            break;
        case 11:
            Wisdom = "Outlook not so good.";
            break;
        case 12:
            Wisdom = "Outlook good.";
            break;
        case 13:
            Wisdom = "Reply hazy, try again.";
            break;
        case 14:
            Wisdom = "Signs point to yes.";
            break;
        case 15:
            Wisdom = "Very doubtful.";
            break;
        case 16:
            Wisdom = "Without a doubt.";
            break;
        case 17:
            Wisdom = "Yes.";
            break;
        case 18:
            Wisdom = "Yes – definitely..";
            break;
        case 19:
            Wisdom = "You may rely on it.";
            break;
    };

    return Wisdom;
}


// Function for Magic Moose to provide an answer
void MagicalMooseWisdom(string Wisdom)
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
                                |   / \   |    {Wisdom}
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

