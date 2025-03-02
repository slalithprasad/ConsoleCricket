#region Wickets
Console.Write("Please enter the number of wickets for the match (enter value between 1 and 10): ");
string? numberOfWicketsString = Console.ReadLine();
int numberOfWickets = 0;
while (!int.TryParse(numberOfWicketsString, out numberOfWickets) || !(numberOfWickets >= 1 && numberOfWickets <= 10))
{
    Console.Write("The entered value is not valid. Please re-enter the number of wickets for the match between 1 and 10: ");
    numberOfWicketsString = Console.ReadLine();
}

Console.WriteLine("\n****************************");
Console.WriteLine($"Number Of Wickets Selected: {numberOfWickets}");
Console.WriteLine("****************************\n");
#endregion

#region Overs
Console.Write("Please enter the number of overs for the match (enter value between 1 and 20): ");
string? numberOfOversString = Console.ReadLine();
int numberOfOvers = 0;
while (!int.TryParse(numberOfOversString, out numberOfOvers) || !(numberOfOvers >= 1 && numberOfOvers <= 20))
{
    Console.Write("The entered value is not valid. Please re-enter the number of overs for the match between 1 and 20: ");
    numberOfOversString = Console.ReadLine();
}
Console.WriteLine("\n****************************");
Console.WriteLine($"Number Of Overs Selected: {numberOfOvers}");
Console.WriteLine("****************************\n");
#endregion

#region Toss
Console.Write("It's toss time! Enter 'H' for Heads or 'T' for Tails: ");
string? tossString = Console.ReadLine();

while (string.IsNullOrEmpty(tossString) || !(tossString.Equals("H", StringComparison.OrdinalIgnoreCase) || tossString.Equals("T", StringComparison.OrdinalIgnoreCase)))
{
    Console.Write("Invalid input. Please enter 'H' for Heads or 'T' for Tails: ");
    tossString = Console.ReadLine();
}
#endregion

#region Toss Decider
Random random = new Random();
int tossDecider = random.Next(1, 3);
string? playerInnings;

if (tossDecider == 1)
{
    Console.WriteLine("You have won the toss!");
    Console.Write("What would you like to choose? (Enter 'bat' for Batting or 'bowl' for Bowling): ");
    playerInnings = Console.ReadLine()?.ToLower();

    while (string.IsNullOrEmpty(playerInnings) || !(playerInnings.Equals("bat", StringComparison.OrdinalIgnoreCase) || playerInnings.Equals("bowl", StringComparison.OrdinalIgnoreCase)))
    {
        Console.Write("Invalid choice. Please enter 'bat' for Batting or 'bowl' for Bowling: ");
        playerInnings = Console.ReadLine();
    }

    Console.WriteLine("\n****************************");
    Console.WriteLine($"You have chosen to {playerInnings} first.");
    Console.WriteLine("****************************\n");
}
else
{
    Console.WriteLine("You have lost the toss. Bot will decide.");

    int botDecisionRn = random.Next(1, 3);

    string botDecision = botDecisionRn == 1 ? "bat" : "bowl";
    playerInnings = botDecisionRn == 1 ? "bowl" : "bat";

    Console.WriteLine("\n****************************");
    Console.WriteLine($"Bot has decided to {botDecision}");
    Console.WriteLine("****************************\n");
}
#endregion

#region Game
decimal playerOverCounter = 0.0m;
int playerWicketCounter = 0;
int playerScoreCounter = 0;

decimal botOverCounter = 0.0m;
int botWicketCounter = 0;
int botScoreCounter = 0;

int target = 0;

string scoreString = string.Empty;
string resultString = string.Empty;

int[] allowedValues = { 0, 1, 2, 3, 4, 6 };

int numberOfBalls = numberOfOvers * 6;
bool firstInningsOver = false;

for (int i = 0; i <= numberOfBalls; i++)
{
    string currentInnings = playerInnings == "bat" ? "batt" : playerInnings;
    string message = firstInningsOver ? $"You are currently {currentInnings}ing and the target is {target}, please enter one of the following values ({string.Join(",", allowedValues)}): " : $"You are currently {currentInnings}ing, please enter one of the following values ({string.Join(",", allowedValues)}): ";
    Console.Write(message);
    string? playerChoiceString = Console.ReadLine();
    int playerChoice = -1;

    while (!int.TryParse(playerChoiceString, out playerChoice) || !allowedValues.Contains(playerChoice))
    {
        Console.Write($"You have entered a wrong choice, please enter one of the following values ({string.Join(",", allowedValues)}): ");
        playerChoiceString = Console.ReadLine();
    }

    int botChoice = allowedValues[random.Next(allowedValues.Length)];

    switch (playerInnings)
    {
        case "bat":


            if (playerChoice == botChoice)
            {
                if (playerWicketCounter < numberOfWickets)
                {
                    playerWicketCounter++;
                }
            }
            else
            {
                playerScoreCounter += playerChoice;
            }

            if (playerOverCounter < numberOfOvers)
            {
                if (playerOverCounter % 1.0m == 0.5m)
                {
                    playerOverCounter += 0.5m;
                }
                else
                {
                    playerOverCounter += 0.1m;
                }
            }


            scoreString = firstInningsOver ? $"SCORE >>> BOT: {botScoreCounter}/{botWicketCounter} from {botOverCounter} overs || PLAYER: {playerScoreCounter}/{playerWicketCounter} from {playerOverCounter} overs" : $"SCORE >>> PLAYER: {playerScoreCounter}/{playerWicketCounter} from {playerOverCounter} overs";

            if (firstInningsOver && playerScoreCounter > target)
            {
                resultString = CalculateResult();
            }
            else if (playerOverCounter == numberOfOvers || playerWicketCounter == numberOfWickets)
            {
                if (!firstInningsOver)
                {
                    target = playerScoreCounter + 1;
                    firstInningsOver = true;
                    i = 0;
                    playerInnings = "bowl";

                    scoreString += $"\n\n****************************\nInnings Over, PLAYER SCORE: {playerScoreCounter}/{playerWicketCounter} from {playerOverCounter} overs,  BOT has to score {target} runs in {numberOfOvers} overs.\n****************************\n";
                }
                else
                {
                    resultString = CalculateResult();
                }
            }

            break;

        case "bowl":
            if (playerChoice == botChoice)
            {
                if (botWicketCounter < numberOfWickets)
                {
                    botWicketCounter++;
                }
            }
            else
            {
                if (target == 0 || botScoreCounter < target)
                {
                    botScoreCounter += botChoice;
                }
            }

            if (botOverCounter < numberOfOvers)
            {
                if (botOverCounter % 1.0m == 0.5m)
                {
                    botOverCounter += 0.5m;
                }
                else
                {
                    botOverCounter += 0.1m;
                }
            }

            scoreString = firstInningsOver ? $"SCORE >>> PLAYER: {playerScoreCounter}/{playerWicketCounter} from {playerOverCounter} overs || BOT: {botScoreCounter}/{botWicketCounter} from {botOverCounter} overs" : $"SCORE >>> BOT: {botScoreCounter}/{botWicketCounter} from {botOverCounter} overs";

            if (firstInningsOver && botScoreCounter > target)
            {
                resultString = CalculateResult();
            }
            else if (botOverCounter == numberOfOvers || botWicketCounter == numberOfWickets)
            {
                if (!firstInningsOver)
                {
                    firstInningsOver = true;
                    target = botScoreCounter + 1;
                    i = 0;
                    playerInnings = "bat";

                    scoreString += $"\n\n****************************\nInnings Over, BOT SCORE: {botScoreCounter}/{botWicketCounter} from {botOverCounter} overs,  PLAYER has to score {target} runs in {numberOfOvers} overs.\n****************************\n";
                }
                else
                {
                    resultString = CalculateResult();
                }
            }

            break;
    }

    Console.WriteLine(scoreString);

    if (!string.IsNullOrEmpty(resultString))
    {
        Console.WriteLine("\n****************************");
        Console.WriteLine(resultString);
        Console.WriteLine("****************************\n");
        break;
    }
}

Console.ReadLine();
#endregion

#region Calculate Result
string CalculateResult()
{
    if (botScoreCounter > playerScoreCounter)
    {
        return "BOT Wins";
    }
    else if (playerScoreCounter > botScoreCounter)
    {
        return "PLAYER Wins";
    }
    else
    {
        return "DRAW";
    }
}
#endregion