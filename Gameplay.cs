using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Gameplay
    {

        Player currentPlayer = new Player();

        BetOptions game = new BetOptions();
        Graphics graphics = new Graphics();

        public void Start()//initiates actual game
        {

            //welcome screen
            GameScreenSize();
            Console.WriteLine("Let's play Roulette!");// add speed control
            Console.WriteLine("Please enter an amount you want to play with:");
            //ask player for a buy in amount. 
            int cash = int.Parse(Console.ReadLine());
            currentPlayer.buyIn = cash;
            game.Selection(currentPlayer,graphics);


        }
        public void GameScreenSize()
        {


            Console.WindowHeight = 40;
            Console.WindowWidth = 165;
            Console.BufferHeight = 40;
            Console.BufferWidth = 165;

        }
    }
       
}
