# Guessing-Game-CSharp

**Overview**
This is a C# program. It is a number-guessing game, very common to make for experimenting with programming languages, where the player is given 5 attempts to guess a randomly generated number between 0 and 100. After each guess, the program will output whether the guess was high, low, or correct. If the player gueeses the number correctly, the game ends with it displaying the number of attempts. Otherwise, the game will end after 5 incorrect guesses.


**Documentation**

**Namespace and Classes**
1. **Namespace**: GuessingGame
  Contains the main class
   
2. **Class**: Program
   Handles initialization, user input, logic


**Methods**

1. **Main Method**: _Main()_
   Initialization, sets guess restrictions, generates randomly generated number for player to guess
   Controls main loop for guesses and response
   Handles whether player wins or loses

**Variables**

1. **int**: guesses
   Tracks total number of guesses made by player

2. **int**: usrguess
   Tracks the current guess made by user

3. **Random**: rand
   Instance of _Random_ class, for randomly generated number
   Number generated between 0 to 100

4.**int**: randnum
  Stores the randomly generated number for the player to guess
  One time generation





This is a simple program, nothing too complex. I made it to build my understanding in C# and how the programming language works. Will start working on more complex projects with the current one on building a weather application. This project will be a long one. Will co-op it.
