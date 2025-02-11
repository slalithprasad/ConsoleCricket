# ConsoleCricket

## Overview

This is a simple cricket game where you can play a quick match against a bot. The game allows you to choose the number of wickets and overs for the match. A toss decides which side bats/bowls first, and the game proceeds with batting and bowling turns. The objective is to either outscore the bot or take all its wickets before it reaches the target to secure a victory.

## How to Play

### 1. Clone the Repository  
```sh
git clone https://github.com/slalithprasad/ConsoleCricket
cd ConsoleCricket
```

### 2. Install .NET 9 Runtime  
Ensure you have .NET 9 runtime installed on your system. You can download it from the official [Microsoft .NET website](https://dotnet.microsoft.com/download).

### 3. Build the Project  
Run the following command in the project directory:  
```sh
dotnet build
```

### 4. Run the Executable  
After building, navigate to the output directory and run the game:  
- On Windows:  
  ```sh
  cd bin/Debug/net9.0
  ConsoleCricket.exe
  ```
- On macOS/Linux:  
  ```sh
  cd bin/Debug/net9.0
  ./ConsoleCricket
  ```

### 5. Playing the Game  
- Enter the number of wickets (1-10).  
- Enter the number of overs (1-20).  
- Participate in the toss by entering 'H' (Heads) or 'T' (Tails).  
- If you win the toss, choose to bat or bowl first. If the bot wins, it will decide.  
- Play your turn by entering runs (0, 1, 2, 3, 4, or 6).  
- Try to outscore the bot before the overs run out or take all its wickets before it reaches the target.


## Sample Output

```text
Please enter the number of wickets for the match (enter value between 1 and 10): 2

****************************
Number Of Wickets Selected: 2
****************************

Please enter the number of overs for the match (enter value between 1 and 20): 2

****************************
Number Of Overs Selected: 2
****************************

It's toss time! Enter 'H' for Heads or 'T' for Tails: h
You have lost the toss. Bot will decide.

****************************
Bot has decided to bat
****************************

You are currently bowling, please enter one of the following values (0,1,2,3,4,6): 2
SCORE >>> BOT: 6/0 from 0.1 overs
You are currently bowling, please enter one of the following values (0,1,2,3,4,6): 4
SCORE >>> BOT: 6/1 from 0.2 overs
You are currently bowling, please enter one of the following values (0,1,2,3,4,6): 2
SCORE >>> BOT: 12/1 from 0.3 overs
You are currently bowling, please enter one of the following values (0,1,2,3,4,6): 6
SCORE >>> BOT: 12/2 from 0.4 overs

****************************
Innings Over, BOT SCORE: 12/2 from 0.4 overs,  PLAYER has to score 13 runs in 2 overs.
****************************

You are currently batting and the target is 13, please enter one of the following values (0,1,2,3,4,6): 4
SCORE >>> BOT: 12/2 from 0.4 overs || PLAYER: 4/0 from 0.1 overs
You are currently batting and the target is 13, please enter one of the following values (0,1,2,3,4,6): 6
SCORE >>> BOT: 12/2 from 0.4 overs || PLAYER: 4/1 from 0.2 overs
You are currently batting and the target is 13, please enter one of the following values (0,1,2,3,4,6): 6
SCORE >>> BOT: 12/2 from 0.4 overs || PLAYER: 10/1 from 0.3 overs
You are currently batting and the target is 13, please enter one of the following values (0,1,2,3,4,6): 6
SCORE >>> BOT: 12/2 from 0.4 overs || PLAYER: 16/1 from 0.4 overs

****************************
PLAYER Wins
****************************
```

Enjoy the game! 🎮🏏