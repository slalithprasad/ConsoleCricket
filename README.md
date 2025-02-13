# Console Cricket 🏏  

A console-based cricket game built with **C#** where you can play a quick match against a bot. Choose the number of wickets and overs, participate in a toss, and try to outscore the bot or take all its wickets to secure victory!

## How It Works  

- Enter the number of wickets (1-10) and overs (1-20).  
- Participate in the toss by entering **'H'** (Heads) or **'T'** (Tails).  
- If you win the toss, choose to bat or bowl first. If the bot wins, it will decide.  
- Play your turn by entering runs **(0, 1, 2, 3, 4, or 6)**.  
- The objective is to either outscore the bot or take all its wickets before it reaches the target.  

## Prerequisites  
- Download and Install [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download)

## Setup  
1. Clone the repository:  
    ```bash
    git clone https://github.com/slalithprasad/ConsoleCricket
    cd ConsoleCricket
    ```
2. Install the required NuGet packages:  
    ```bash
    dotnet restore
    ```

## Running the Game  
```bash
dotnet run
```

## Gameplay  
- 🎲 Enter the number of wickets (1-10) and overs (1-20).  
- 🪙 Participate in the toss with **'H'** (Heads) or **'T'** (Tails).  
- 🏏 If you bat, enter runs **(0, 1, 2, 3, 4, or 6)** to score.  
- 🎳 If you bowl, enter runs **(0, 1, 2, 3, 4, or 6)** to try and get the bot out.  
- 🎉 Outscore the bot or take all its wickets before it reaches the target to win!  

## Example Gameplay  

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

---

**Happy Cricketing!** 🎉🏏