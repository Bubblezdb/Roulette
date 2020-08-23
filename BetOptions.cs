using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Text;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;

namespace Roulette
{
    
    public class BetOptions
    {

        Random rand = new Random(); 
        public int x { get; set; }
        public int y { get; set; }
        public int direction { get; set; }
        public int number;
        public string bets;
        public int bet;

        public string[,] bin;// this will hold the random array value
        public string bid;// what the player bids

        public string[,] arrayBoard = new string[,]// board array
            {
                // 0                1                 2                3               4                5                    6             7                   8               9                     10            11                    12
             /*0*/ {"36"+ " " + "Red","33"+ " " + "Black","30"+ " " + "Red","27"+ " " + "Red","24"+ " " + "Black","21"+ " " + "Red","18"+ " " + "Red","15"+ " " + "Black","12"+ " " + "Red","9"+ " " + "Red","6"+ " " + "Black","3"+ " " + "Red", "0"+ " " + "Green"},
             /*1*/ {"35"+ " " + "Black","32"+ " " + "Red","29"+ " " + "Black","26"+ " " + "Black","23"+ " " + "Red","20"+ " " + "Black","17"+ " " + "Black","14"+ " " + "Red","11"+ " " + "Black","8"+ " " + "Black","5"+ " " + "Red","2"+ " " + "Black","0"+ " " + "Green"},
              /*2*/ {"34"+ " " + "Red","31"+ " " + "Black","28"+ " " + "Black","25"+ " " + "Red","22"+ " " + "Black","19"+ " " + "Red","16"+ " " + "Red","13"+ " " + "Black","10"+ " " + "Black","7"+ " " + "Red","4"+ " " + "Black","1"+ " " + "Red","00"+ " " + "Green"}

            };
        public void PlayAgain(Player player,Graphics graphics)
        {
            Console.WriteLine("Play again? (1) for yes, (0) to exit");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Selection(player,graphics);
            }
            else if (answer == 0)
            {
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter a valid selection");
                PlayAgain(player,graphics);
            }

        }
        public void NumberBet(Player player)
        {
            try
            {
                Console.WriteLine("Choose number to place the bet on:");
        
                number = int.Parse(Console.ReadLine());
                if (number <= 36 || number==0 || number== 00)
                {
                    bets = Convert.ToString(number);
                    player.bet = bets;

                }
                else
                {
                    Console.WriteLine("Enter a valid selection, numbers(00,0 or 1-36)");
                    NumberBet(player);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number");
                NumberBet(player);
            }
            
        }
        public void ColumnBet(Player player)
        {
            Console.WriteLine("Choose your column:  ");
            Console.WriteLine("(1) Numbers 3,6,9,12,15,18,21,24,27,30,33,36");
            Console.WriteLine("(2) Numbers 2,5,8,11,14,17,20,23,26,29,32,35");
            Console.WriteLine("(3) Numbers 1,4,7,10,13,16,19,22,25,28,31,34");
            
            int column = int.Parse(Console.ReadLine());
            if (column==1)
            {
                Console.WriteLine("You have chosen Column 1");
                player.numberValues = "3,6,9,12,15,18,21,24,27,30,33,36";
                
            }
            else if (column == 2)
            {
                Console.WriteLine("You have chosen Column 2");
                player.numberValues = "2,5,8,11,14,17,20,23,26,29,32,35";
                
            }
            else if (column == 3)
            {
                Console.WriteLine("You have chosen Column 3");
                player.numberValues = "1,4,7,10,13,16,19,22,25,28,31,34";
                
            }
            else
            {
                
                Console.WriteLine("Please Enter a valid selection");
                
            }
        }
        public void StreetBet(Player player)
        {
            Console.WriteLine("Choose your street number:  ");
            Console.WriteLine("(1) Numbers 1,2,3");
            Console.WriteLine("(2) Numbers 4,5,6");
            Console.WriteLine("(3) Numbers 7,8,9");
            Console.WriteLine("(4) Numbers 10,11,12");
            Console.WriteLine("(5) Numbers 13,14,15");
            Console.WriteLine("(6) Numbers 16,17,18");
            Console.WriteLine("(7) Numbers 19,20,21");
            Console.WriteLine("(8) Numbers 22,23,24");
            Console.WriteLine("(9) Numbers 25,26,27");
            Console.WriteLine("(10) Numbers 28,29,30");
            Console.WriteLine("(11) Numbers 31,32,33");
            Console.WriteLine("(12) Numbers 34,35,36");

            int street = int.Parse(Console.ReadLine());
            if (street == 1)
            {
                Console.WriteLine("You have chosen Street 1");
                player.numberValues = "1,2,3";
                
            }
            else if (street == 2)
            {
                Console.WriteLine("You have chosen Street 2");
                player.numberValues = "4,5,6";
                
            }
            else if (street == 3)
            {
                Console.WriteLine("You have chosen Street 3");
                player.numberValues = "7,8,9";
                
            }
            if (street == 4)
            {
                Console.WriteLine("You have chosen Street 4");
                player.numberValues = "10,11,12";
                
            }
            else if (street == 5)
            {
                Console.WriteLine("You have chosen Street 5");
                player.numberValues = "13,14,15";
               
            }
            else if (street == 6)
            {
                Console.WriteLine("You have chosen Street 6");
                player.numberValues = "16,17,18";
               
            }
            if (street == 7)
            {
                Console.WriteLine("You have chosen Street 7");
                player.numberValues = "19,20,21";
               
            }
            else if (street == 8)
            {
                Console.WriteLine("You have chosen Street 8");
                player.numberValues = "22,23,24";
                
            }
            else if (street == 9)
            {
                Console.WriteLine("You have chosen Street 9");
                player.numberValues = "25,26,27";
                
            }
            if (street == 10)
            {
                Console.WriteLine("You have chosen Street 10");
                player.numberValues = "28,29,30";
               
            }
            else if (street == 11)
            {
                Console.WriteLine("You have chosen Street 11");
                player.numberValues = "31,32,33";
               
            }
            else if (street == 12)
            {
                Console.WriteLine("You have chosen Street 12");
                player.numberValues = "34,35,36";
                
            }
            else
            {

                Console.WriteLine("Please Enter a valid selection");
                StreetBet(player);
            }
        }// todo
        public void DblStreetBet(Player player)
        {
            
                Console.WriteLine("Choose your street number:  ");
                Console.WriteLine("(1) Numbers 1,2,3,4,5,6");
                Console.WriteLine("(2) Numbers 4,5,6,7,8,9");
                Console.WriteLine("(3) Numbers 7,8,9,10,11,12");
                Console.WriteLine("(4) Numbers 10,11,12,13,14,15");
                Console.WriteLine("(5) Numbers 13,14,15,16,17,18");
                Console.WriteLine("(6) Numbers 16,17,18,19,20,21");
                Console.WriteLine("(7) Numbers 19,20,21,22,23,24");
                Console.WriteLine("(8) Numbers 22,23,24,25,26,27");
                Console.WriteLine("(9) Numbers 25,26,27,28,29,30");
                Console.WriteLine("(10) Numbers 28,29,30,31,32,33");
                Console.WriteLine("(11) Numbers 31,32,33,34,35,36");


                int street = int.Parse(Console.ReadLine());
                if (street == 1)
                {
                    Console.WriteLine("You have chosen Street 1");
                    player.numberValues = "1,2,3,4,5,6";
                    
                }
                else if (street == 2)
                {
                    Console.WriteLine("You have chosen Street 2");
                    player.numberValues = "4,5,6,7,8,9";
                    
                }
                else if (street == 3)
                {
                    Console.WriteLine("You have chosen Street 3");
                    player.numberValues = "7,8,9,10,11,12";
                    
                }
                if (street == 4)
                {
                    Console.WriteLine("You have chosen Street 4");
                    player.numberValues = "10,11,12,13,14,15";
                    
                }
                else if (street == 5)
                {
                    Console.WriteLine("You have chosen Street 5");
                    player.numberValues = "13,14,15,16,17,18";
                   
                }
                else if (street == 6)
                {
                    Console.WriteLine("You have chosen Street 6");
                    player.numberValues = "16,17,18,19,20,21";
                    
                }
                if (street == 7)
                {
                    Console.WriteLine("You have chosen Street 7");
                    player.numberValues = "19,20,21,22,23,24";
                    
                }
                else if (street == 8)
                {
                    Console.WriteLine("You have chosen Street 8");
                    player.numberValues = "22,23,24,25,26,27";
                   
                }
                else if (street == 9)
                {
                    Console.WriteLine("You have chosen Street 9");
                    player.numberValues = "25,26,27,28,29,30";
                   
                }
                if (street == 10)
                {
                    Console.WriteLine("You have chosen Street 10");
                    player.numberValues = "28,29,30,31,32,33";
                    
                }
                else if (street == 11)
                {
                    Console.WriteLine("You have chosen Street 11");
                    player.numberValues = "31,32,33,34,35,36";
                   
                }

                else
                {

                    Console.WriteLine("Please Enter a valid selection");
                   DblStreetBet(player);
                }
           
        }
        public void MoneyBet(Player player)
        {
            try
            {
                Console.WriteLine("How much are you willing to wager?");
                bet = int.Parse(Console.ReadLine());
                if (bet <= player.buyIn && bet > 0)
                {
                    player.currentbet = bet;

                }
                else
                {
                    Console.WriteLine("Please enter a value that you have.");
                    MoneyBet(player);
                }
            } 
            catch(FormatException)
            {
                Console.WriteLine("Please enter a whole number");
                MoneyBet(player);
            }
            
        }
        //public void HighLow(Player player)
        //{
        //    try
        //    {
        //        Console.WriteLine("Select (1) for numbers 19-36, (2) for numbers 1-18");
        //        int selection = int.Parse(Console.ReadLine());
        //        if (selection == 1)
        //        {
        //            Console.WriteLine("You have selected Highs");
        //            High(player);
        //        }
        //        else if (selection == 2)
        //        {
        //            Console.WriteLine("You have selected Lows");
        //            Lows(player);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Please enter a valid selection");
        //            HighLow(player);
        //        }
        //    }
        //    catch(FormatException)
        //    {
        //        Console.WriteLine("Please enter a valid selection");
        //        HighLow(player);
        //    }
            

        //}
        public void DozenBet(Player player)
        {
            Console.WriteLine("Select the Dozen you want to place a bet on:");
            Console.WriteLine("Dozen 1: 1-12");
            Console.WriteLine("Dozen 2: 13-24");
            Console.WriteLine("Dozen 3: 25-36");
            int selection = int.Parse(Console.ReadLine());
            if (selection== 1)
            {
                Console.WriteLine("You have chosen Dozen 1");
                player.numberValues = "1,2,3,4,5,6,7,8,9,10,11,12";
                
            }
            else if(selection== 2)
            {
                Console.WriteLine("You have chosen Dozen 2");
                player.numberValues = "13,14,15,16,17,18,19,20,21,22,23,24";
                
            }
            else if(selection==3)
            {
                Console.WriteLine("You have chosen Dozen 3");
                player.numberValues = "25,26,27,28,29,30,31,32,33,34,35,36";
                
            }
            else
            {
                Console.WriteLine("Please enter a valid selection");
                DozenBet(player);
            }
        }
        public void Selection(Player player, Graphics graphics)
        {
            Console.Clear();
            graphics.GameBoard(player);

            Console.WriteLine("Please enter the type of bet you want to make using the letters located in the selection menu \n");
           
            //add menu
            ConsoleKey key;// makes option choice selections using key input
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            key = keyInfo.Key;

            switch (key)
            {

                case ConsoleKey.N:// straight up //works
                    Console.WriteLine("Straight UP!");
                    NumberBet(player);
                    MoneyBet(player);
                    StraightUp(player, graphics); 
                    break;

                case ConsoleKey.S://split
                                  //ask player to put a bet on a number.
                    Console.WriteLine("Split!");
                    NumberBet(player);
                    MoneyBet(player);
                Restart:
                    Console.WriteLine("Use the arrow keys to place identify where you want to put the split:\n");
                    Console.WriteLine("(1) for above, (2) for below, (3) for Left, (4) for Right");
                    int direction = int.Parse(Console.ReadLine());
                    if (direction == 1)
                    {
                        Console.WriteLine("Split placed above the number");
                        player.direction = 1;
                        Split(player, graphics);

                    }
                    else if (direction == 2)
                    {
                        Console.WriteLine("Split placed below the number");
                        player.direction = 2;
                        Split(player, graphics);

                    }
                    else if (direction == 3)
                    {
                        Console.WriteLine("Split placed left of the number");
                        player.direction = 3;
                        Split(player, graphics);

                    }
                    else if (direction == 4)
                    {
                        Console.WriteLine("Split placed right of the number");
                       player.direction = 4;
                        Split(player, graphics);

                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid selection");
                        goto Restart;
                    }
                    break;


                case ConsoleKey.C:// Corner
                    Console.WriteLine("Corner!");
                    NumberBet(player);
                    MoneyBet(player);
                    Console.WriteLine("What corner are you choosing?");
                  CRestart:
                    Console.WriteLine("(1) for Right upper corner, (2) for left upper corner, (3) for left bottom corner, (4) for  right bottom corner");
                    int corner = int.Parse(Console.ReadLine());
                    if (corner == 1)
                    {
                        Console.WriteLine("You have selected the Right upper corner or the number");
                        player.direction = 1;
                        Corner(player, graphics);

                    }
                    else if (corner == 2)
                    {
                        Console.WriteLine("You have selected the left upper corner or the number");
                        player.direction = 2;
                        Corner(player, graphics);

                    }
                    else if (corner == 3)
                    {
                        Console.WriteLine("You have selected the left bottom corner or the number");
                        player.direction = 3;
                        Corner(player, graphics);

                    }
                    else if (corner == 4)
                    {
                        Console.WriteLine("You have selected the right bottom corner of the number");
                        player.direction = 4;
                        Corner(player, graphics);

                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid selection");
                        goto CRestart;
                    }
                    break;

                  
                case ConsoleKey.T://Street
                    Console.WriteLine("Street!");
                   
                    MoneyBet(player);
                    StreetBet(player);
                    Street(player, graphics);
                    break;
                case ConsoleKey.D:// DoubleStreet
                    Console.WriteLine("Double Street!");
                    
                    MoneyBet(player);
                    DblStreetBet(player);
                    DblStreet(player, graphics);
                    break;
                case ConsoleKey.I:// Columns
                    Console.WriteLine("Columns!");
                    ColumnBet(player);
                    MoneyBet(player);
                    Columns(player, graphics);
                    break;
                case ConsoleKey.H://High/Lows (19-36)
                    Console.WriteLine("Highs!");
                    MoneyBet(player);
                    High(player, graphics);
                    break;
                case ConsoleKey.L://High/Lows (19-36)
                    Console.WriteLine("Lows!");
                    MoneyBet(player);
                    Lows(player, graphics);
                    break;
                case ConsoleKey.R://Red
                    Console.WriteLine("Red!");
                    MoneyBet(player);
                    Red(player, graphics);
                    break;
                case ConsoleKey.B://Black
                    Console.WriteLine("Black!");
                    MoneyBet(player);
                    Black(player, graphics);
                    break;
                case ConsoleKey.E:// Even
                    Console.WriteLine("Even!");
                    MoneyBet(player);
                    Even(player, graphics);
                    break;
                case ConsoleKey.G:// Dozen
                    Console.WriteLine("Dozen!");
                    MoneyBet(player);
                    DozenBet(player);
                    Dozens(player, graphics);
                    break;
                case ConsoleKey.O://Odds
                    Console.WriteLine("Odds!");
                    MoneyBet(player);
                    Odd(player, graphics);
                    break;
                case ConsoleKey.Q:
                    Console.WriteLine("Thank you for playing, press 0 to continue.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    break;
            }

        }

        public void StraightUp(Player player, Graphics graphics)//Straight up
        {
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;
            if (arrayBoard[x, y].Contains(player.bet))
            {
                Console.WriteLine($"Your bet was on {player.bet}");
                Console.WriteLine($"The winning number is {arrayBoard[x,y]}");
                Console.WriteLine("You win!");
                player.buyIn += 35 * player.currentbet;
                PlayAgain(player,graphics);
               
            }

            else
            {
                Console.WriteLine($"The winning number is {arrayBoard[x, y]}");
                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }
        }//good
  
    public void Split(Player player, Graphics graphics)  //Split
        {
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;
           try
            {
                if (player.direction == 1)
                {
                    for(int i=0; i<arrayBoard.GetLength(0);i++)
                    {
                        for(int j=0; j<arrayBoard.GetLength(1); j++)
                        {
                            if(arrayBoard[i,j].Contains(player.bet))
                            {
                                if(arrayBoard[i,j]==arrayBoard[x,y] || arrayBoard[i-1,j]==arrayBoard[x,y])
                                {
                                        Console.WriteLine($"Your bet was on top split at {arrayBoard[i,j]}");
                                        Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                                        Console.WriteLine("You win!");
                                        player.buyIn += 17 * player.currentbet;
                                    PlayAgain(player, graphics);
                                }
                                else
                                {
                                    Console.WriteLine($"Your bet was on top split at {player.bet}");
                                    Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                                    Console.WriteLine("You lose!");
                                    player.buyIn -= player.currentbet;
                                    PlayAgain(player, graphics);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Your bet was on top split at {player.bet}");
                                Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                                Console.WriteLine("You lose!");
                                player.buyIn -= player.currentbet;
                                PlayAgain(player, graphics);
                            }
                        }
                    }
                   
                   
                }
                else if (player.direction == 2)
                {
                    //below split
                    for (int i = 0; i < arrayBoard.Length; i++)
                    {
                        for (int j = 0; j < arrayBoard.Length; j++)
                        {
                            if (arrayBoard[i, j].Contains(player.bet))
                            {
                                if (arrayBoard[i, j] == arrayBoard[x, y] || arrayBoard[i+1, j] == arrayBoard[x, y])
                                {
                                    Console.WriteLine($"Your bet was on bottom split at {arrayBoard[i, j]}");
                                    Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                                    Console.WriteLine("You win!");
                                    player.buyIn += 17 * player.currentbet;
                                    PlayAgain(player, graphics);
                                }
                                else
                                {
                                    Console.WriteLine($"Your bet was on top split at {player.bet}");
                                    Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                                    Console.WriteLine("You lose!");
                                    player.buyIn -= player.currentbet;
                                    PlayAgain(player, graphics);
                                }
                            }
                        }
                    }
                }
                else if (player.direction == 3)
                {
                    //Left split
                    for (int i = 0; i < arrayBoard.Length; i++)
                    {
                        for (int j = 0; j < arrayBoard.Length; j++)
                        {
                            if (arrayBoard[i, j].Contains(player.bet))
                            {
                                if (arrayBoard[i, j] == arrayBoard[x, y] || arrayBoard[i, j-1] == arrayBoard[x, y])
                                {
                                    Console.WriteLine($"Your bet was on top split at {arrayBoard[i, j]}");
                                    Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                                    Console.WriteLine("You win!");
                                    player.buyIn += 17 * player.currentbet;
                                    PlayAgain(player, graphics);
                                }
                                else
                                {
                                    Console.WriteLine($"Your bet was on top split at {player.bet}");
                                    Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                                    Console.WriteLine("You lose!");
                                    player.buyIn -= player.currentbet;
                                    PlayAgain(player, graphics);
                                }
                            }
                        }
                    }
                }
                else if (player.direction == 4)
                {
                    //Right split
                    for (int i = 0; i < arrayBoard.Length; i++)
                    {
                        for (int j = 0; j < arrayBoard.Length; j++)
                        {
                            if (arrayBoard[i, j].Contains(player.bet))
                            {
                                if (arrayBoard[i, j] == arrayBoard[x, y] || arrayBoard[i, j+1] == arrayBoard[x, y])
                                {
                                    Console.WriteLine($"Your bet was on top split at {arrayBoard[i, j]}");
                                    Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                                    Console.WriteLine("You win!");
                                    player.buyIn += 17 * player.currentbet;
                                    PlayAgain(player, graphics);
                                }
                                else
                                {
                                    Console.WriteLine($"Your bet was on top split at {arrayBoard[i,j]}");
                                    Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                                    Console.WriteLine("You lose!");
                                    player.buyIn -= player.currentbet;
                                    PlayAgain(player, graphics);
                                }
                            }
                        }
                    }
                }

            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine($"Split you chose does not exist.");
                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }
    }
        //Corner
        public void Corner(Player player, Graphics graphics)
        {
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;
            try
            {
                if (player.direction == 1)
                {
                    //right upper
                    if (arrayBoard[x, y].Contains(player.bet) || arrayBoard[x-1, y+1].Contains(player.bet) || arrayBoard[x-1, y-1].Contains(player.bet) || arrayBoard[x, y-1].Contains(player.bet))
                    {

                        Console.WriteLine($"Your bet was on right top corner at {player.bet}");
                        Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                        Console.WriteLine("You win!");
                        player.buyIn += 8 * player.currentbet;
                        PlayAgain(player, graphics);
                    }
                    else
                    {
                        Console.WriteLine($"Your bet was on right top corner at {player.bet}");
                        Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                        Console.WriteLine("You lose!");
                        player.buyIn -= player.currentbet;
                        PlayAgain(player, graphics);
                    }
                }
                else if (player.direction == 2)
                {
                    //left upper
                    if (arrayBoard[x, y].Contains(player.bet) || arrayBoard[x - 1, y + 1].Contains(player.bet) || arrayBoard[x, y + 1].Contains(player.bet) || arrayBoard[x - 1, y].Contains(player.bet))
                    {
                        Console.WriteLine($"Your bet was onLeft top split at {player.bet}");
                        Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                        Console.WriteLine("You win!");
                        player.buyIn += 8 * player.currentbet;
                        PlayAgain(player, graphics);
                    }

                    else
                    {
                        Console.WriteLine($"Your bet was on Left top split at {player.bet}");
                        Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                        Console.WriteLine("You lose!");
                        player.buyIn -= player.currentbet;
                        PlayAgain(player, graphics);
                    }
                }
                else if (player.direction == 3)
                {
                    //Left bottom
                    if (arrayBoard[x, y].Contains(player.bet) || arrayBoard[x , y+1].Contains(player.bet) || arrayBoard[x+1, y + 1].Contains(player.bet) || arrayBoard[x+1, y].Contains(player.bet))
                    {

                        Console.WriteLine($"Your bet was on Left bottom split at {player.bet}");
                        Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                        Console.WriteLine("You win!");
                        player.buyIn += 8 * player.currentbet;
                        PlayAgain(player, graphics);
                    }

                    else
                    {
                        Console.WriteLine($"Your bet was on Left bottom split  at {player.bet}");
                        Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                        Console.WriteLine("You lose!");
                        player.buyIn -= player.currentbet;
                        PlayAgain(player, graphics);
                    }
                }
                else if (player.direction == 4)
                {
                    //Right split
                    if (arrayBoard[x, y].Contains(player.bet) || arrayBoard[x +1, y].Contains(player.bet) || arrayBoard[x+1, y - 1].Contains(player.bet) || arrayBoard[x, y-1].Contains(player.bet))
                    {
                        Console.WriteLine($"Your bet was on Right bottom split at {player.bet}");
                        Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                        Console.WriteLine("You win!");
                        player.buyIn += 17 * player.currentbet;
                        PlayAgain(player, graphics);
                    }

                    else
                    {
                        Console.WriteLine($"Your bet was on Right bottom split at {player.bet}");
                        Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                        Console.WriteLine("You lose!");
                        player.buyIn -= player.currentbet;
                        PlayAgain(player, graphics);
                    }
                }

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"The winning split was at {arrayBoard[x, y]}");
                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);

            }
        }// need catch pass
        //Street
        public void Street(Player player, Graphics graphics)//need catch pass
        {
            
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;

            if (arrayBoard[x, y].Contains(player.numberValues))
            {

                Console.WriteLine($"Your street contained{player.numberValues}!");
                Console.WriteLine($"The winning number was {arrayBoard[x, y]}");
                Console.WriteLine($"You Win!");
                player.buyIn += player.currentbet;
                PlayAgain(player, graphics);
            }
            else
            {
                Console.WriteLine($"Your street contained {player.bet}");
                Console.WriteLine($"The winning number was {arrayBoard[x, y]}");
                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }

        }
        //DblStreet
        public void DblStreet(Player player, Graphics graphics)//todo
        {
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;

            if (arrayBoard[x, y].Contains(player.numberValues))
            {
                Console.WriteLine($"Your street contained {player.numberValues}");
                Console.WriteLine($"The winning number was {arrayBoard[x, y]}");
                Console.WriteLine("You win!");
                player.buyIn += 11 * player.currentbet;
                PlayAgain(player, graphics);
            }
            else
            {
                Console.WriteLine($"Your street contained {player.bet}");
                Console.WriteLine($"The winning number was {arrayBoard[x, y]}");
                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }
        }
        
        //Columns
        public void Columns(Player player, Graphics graphics)
        {
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;

            if( arrayBoard[x,y].Contains(player.numberValues))
            {
                Console.WriteLine($"Your column contained {player.numberValues}");
                Console.WriteLine($"The winning number was {arrayBoard[x, y]}");
                Console.WriteLine("You win!");
                player.buyIn += 11 * player.currentbet;
                PlayAgain(player, graphics);
            }
            else
            {
                Console.WriteLine($"Your column contained {player.bet}");
                Console.WriteLine($"The winning number was {arrayBoard[x, y]}");
                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }
        }//good
        
        //Dozens
        public void Dozens(Player player, Graphics graphics)//good
        {
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;
            if (arrayBoard[x,y].Contains(player.numberValues))
            {

                Console.WriteLine($"Your dozen contained {player.numberValues}");
                Console.WriteLine($"The winning number was {arrayBoard[x, y]}");
                Console.WriteLine("You win!");
                player.buyIn += 11 * player.currentbet;
                PlayAgain(player, graphics);
            }
            else
            {
                Console.WriteLine($"Your dozen contained {player.bet}");
                Console.WriteLine($"The winning number was {arrayBoard[x, y]}");
                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }
        }

        //High
        public void High(Player player, Graphics graphics)
        {
            player.numberValues = "19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36";
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;

            if (arrayBoard[x, y].Contains(player.numberValues))
            {
               
                Console.WriteLine("Highs win!");
                player.buyIn += player.currentbet;
                PlayAgain(player, graphics);
            }
            else
            {
                
                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }
        }//good
        //Low
        public void Lows(Player player, Graphics graphics)//good
        {
            player.numberValues = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18";
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;
            if (arrayBoard[x, y].Contains(player.numberValues))
            {

                Console.WriteLine("Lows win!");
                player.buyIn += player.currentbet;
                PlayAgain(player, graphics);
            }
            else
            {

                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }
        }
    
        //Red
        public void Red(Player player, Graphics graphics)
        {
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;
            if (arrayBoard[x,y].Contains("Red"))
            {
                Console.WriteLine($"The winner was {arrayBoard[x, y]}");
                Console.WriteLine("You win!");
                player.buyIn += player.currentbet;
                PlayAgain(player, graphics);
            }
            else
            {
                Console.WriteLine($"The winner was {arrayBoard[x,y]}");
                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }

        }

        //Black
        public void Black(Player player, Graphics graphics)
        {
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;
            if (arrayBoard[x, y].Contains("Black"))
            {
                Console.WriteLine($"The winner was {arrayBoard[x, y]}");
                Console.WriteLine("You win!");
                player.buyIn += player.currentbet;
                PlayAgain(player, graphics);
            }
            else
            {
                Console.WriteLine($"The winner was {arrayBoard[x, y]}");
                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }
        }
        //Even
        public void Even(Player player, Graphics graphics)
        {
            player.numberValues = "2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36";
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;
            if (arrayBoard[x, y].Contains(player.numberValues))
            {

                Console.WriteLine("Evens win!");
                player.buyIn += player.currentbet;
                PlayAgain(player, graphics);
            }
            else
            {

                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }
        }
        //Odd
        public void Odd(Player player, Graphics graphics)
        {
            player.numberValues = "1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35";
            int rows = rand.Next(0, 2);
            int cols = rand.Next(0, 12);
            x = rows;
            y = cols;
            if (arrayBoard[x, y].Contains(player.numberValues))
            {

                Console.WriteLine("Odds win!");
                player.buyIn += player.currentbet;
                PlayAgain(player, graphics);
            }
            else
            {

                Console.WriteLine("You lose!");
                player.buyIn -= player.currentbet;
                PlayAgain(player, graphics);
            }
        }
        //zero & Double Zero
        
    }
}
