using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.Serialization;
using Microsoft.Win32.SafeHandles;

// Carlos Morales (Lab 5 - Master Mind) 10-28-25

Console.WriteLine("I have created a secret using 4 letters between 'a' and 'g'.");
Console.WriteLine("You have to guess the sequence of the secret by guessing 4 letters.");

string secret = "geac";
string guess;
int attempts = 0;

do
{
    attempts++;

    Console.WriteLine($"Guess # {attempts}: Please guess 4 lowercase letters (a-g) with no repeats.");
    guess = Console.ReadLine();

    //Tell the user that input it too long and to try again.
    if (guess.Length != secret.Length)
    {
        Console.WriteLine("Guess is too long, try again.");
        continue;
    }

    //Makes sure letters are not repeating
    bool letterRepeat = false;

    for (int first = 0; first < guess.Length; first++)
    {
        for (int second = first + 1; second < guess.Length; second++)
        {
            if (guess[first] == guess[second])
            {
                letterRepeat = true;
                break;
            }
        }
        if (letterRepeat)
            break;
    }

    //Making sure the letter are between a and g.
    bool invalid = false;
    foreach (char l in guess)
    {
        if (l < 'a' || l > 'g')
        {
            invalid = true;
            break;
        }
    }
    if (invalid)
    {
        Console.WriteLine("Invalid letter.");
    }

    //Finding the correct and incorrect positions

    int correctPosition = 0;
    int incorrectPosition = 0;

    for (int x = 0; x < secret.Length; x++)
    {
        if (guess[x] == secret[x])
        {
            correctPosition++;
        }
        else
        {
            for (int y = 0; y < secret.Length; y++)
            {
                if (guess[x] == secret[y] && x != y)
                {
                    incorrectPosition++;
                    break;
                }
            }
        }
    }

    //Tell how many in the correct position and how many in the incorrect position.

    if (guess != secret)
    {
        Console.WriteLine($"-{correctPosition} in the right positions.");
        Console.WriteLine($"-{incorrectPosition} in the incorrect positions.");
    }

    //Gives the final result

} while (guess != secret);

Console.WriteLine($"You did it! You guessed the secret ({secret}) in ({attempts}) guesses.");
