#Lab3-Mastermind
Objectives

*ADDING COMMENTS TO YOUR CODE
*Write a challenging guessing/logic game.
*Get more practice with loops.
*Get practice with nested loops.
*Get practice accessing individual characters in a string.

 
#Step 1: Understand the Overview

In this lab, you will implement a guessing game where a secret string of length 4 (like "afdb") is hard-coded into your program. The string should only use letters between 'a' and 'g' and should not have any letters that appear in it twice. (You can make the game easier or harder by changing the length of the string or the number of allowed letters.)

The player's goal will be to guess the secret string using the following clues that your program will provide to the player in response to each guess:

    How many of the letters in the current guess are in the secret and are in the same position as they appeared in the guess.
    How many of the letters in the current guess are somewhere in the secret but not in the position where they appeared in the guess.

For example, if the secret were "afdb", then the string "adbc" has one letter in the correct position ('a') and two letters that are correct but in the wrong positions ('d' and 'b').

After completing the required steps below, you are free to continue to improve the game as you wish.

Here is a sample run of the basic program (secret is "abfc"):
I have chosen 4 letters between 'a' and 'g' and have arranged them in a particular order.
Your job is to guess the letters and put them in the right order.

      _Guess #1: Please guess a sequence of 4 lowercase letters with no repeats.
        fabd
        - 0 in the right positions
        - 3 in the wrong positions

      Guess #2: Please guess a sequence of 4 lowercase letters with no repeats.
        abdf
        - 2 in the right positions
        - 1 in the wrong positions

      Guess #3: Please guess a sequence of 4 lowercase letters with no repeats.
        abfd
        - 3 in the right positions
        - 0 in the wrong positions

      Guess #4: Please guess a sequence of 4 lowercase letters with no repeats.
        abcd
        - 2 in the right positions
        - 1 in the wrong positions

      Guess #5: Please guess a sequence of 4 lowercase letters with no repeats.
        abfe
        - 3 in the right positions
        - 0 in the wrong positions

      Guess #6: Please guess a sequence of 4 lowercase letters with no repeats.
        abfc

      You did it! You guessed my secret (abfc) in 6 guesses.
        
#Step 2: Environment Setup 

    Accept the GitHub Classroom Assignment 
    Open a terminal.
    If you don't have a code directory already:
        Run mkdir my-code-dir to make a new directory named 'my-code-dir'.
    Navigate to your code directory (hint: cd my-code-dir).
    Run git clone {yourUrl} to make a local copy of your repository. (hint: don't include the curly braces in your command---those are just there to indicate that you should replace {yourUrl} with your actual repository url.)
    Run code {nameOfYourRepo} to open that directory in VS Code.
    Open the integrated terminal in VS Code (Ctrl+`, or the Terminal menu -> New Terminal).
    Run dotnet new console to create a new project in the current folder.
    Run dotnet run to compile and execute your code.
  
#Step 3: Programming
Incrementally add the following functionality to your game. After each step, make sure that you can still compile/run and that the program behaves as expected; then commit a checkpoint to your git repository (using git add . and git commit -m "write a description of the step here").

    comment Add a comment to the top of your source code with your name, the date, and the name of the lab. (Remember to run, add, and commit your code.)
    greeting Print a greeting and description of the program to the user. (Remember to run, add, and commit.)
    basic guessing Make a string variable holding your hard-coded secret and then repeatedly ask the user for a guess until the guess matches the secret. (hint: do-while might work well here since you will ask for at least one guess.) (Remember to run, add, and commit.)
    number of guesses Keep track of the number of guesses and report it to the user during each turn and after the secret has been guessed. (Remember to run, add, and commit.)
    correct positions Add a nested loop that counts the number positions in the guess where the character at that position in the guess matches the character at that position in the secret. Report that count to the user. For now, you can assume that the guess is of the same length as the secret. (hints: remember that you can get the length of a string s with s.Length and you can get the next character after skipping the first i characters with s[i], so a for-loop can conveniently loop over all positions from 0 up to the length and count the number of positions with matching characters.) (Remember to run, add, and commit.)
    correct letters at wrong positions Within the main loop body, create a variable that will hold the number of letters that are out of place in the guess. Modify the body of the nested loop so that if the character at a given position in the guess does not match the character at the same position in the secret, then you will check if any of the positions in the secret match that letter (hint: this will be yet another level of nesting; a for loop would work nicely since you know to simply look at every index in the secret). (Remember to run, add, and commit.)
    (Optional) Add the following input validation:
        Ensure that the user's guess is the same length as the secret.
        Ensure that the user's guess only contains letters in the specified range (e.g. 'a' - 'g').
        Ensure that the user's guess contains no duplicate letters.
    (Optional) Consider allowing the user to specify how the length of the secret and the number of letters to chose from and have the secret generated randomly.
    
#Submission

Make sure to add, commit and push so your code makes it back up to GitHub.
#Grading

Grading must be done with me via a teams call.
