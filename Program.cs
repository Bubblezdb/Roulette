using System;

namespace Roulette
{
    class Program
    {
        /*This is a console style roulette game. 
            It will use an multidimensional array as the game board that will store two 
            values: An integer(space number) and a string(Color-Black or Red).
            
            The player will be asked to enter a buy in amount.
            The player will then be asked to make a bet, choosing between the different options
            1 bet per round
           bet options will have certain criteria. The player will be able to play as many rounds
            as long as the player does not run out of money. 

            After each round the program will check if the players input matches the value at the 
            array coordinate. If the player is a winner, the player will earn the amount specified 
            in the bet option multiplied by the amount used to bet. 

            If the player loses, the amount used to bet will be deducted from the players bank. 
            */
        static void Main(string[] args)
        {
            //instantiate game

            Gameplay game = new Gameplay();
        
            game.Start();
        }
        

    }
}
