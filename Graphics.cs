using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    //provides visuals for game play
   public class Graphics
    {
        // displays full board and rules
        //displays board by bet options, highlighting choices
        //Displays winner or loser

        public void GameBoard(Player player)
        {
            Console.WriteLine($@"
+----------+-------+--------+--------+--------+--------+--------+--------+--------+-----------+-- -------+-----------+----------+------------+-------------------+
|          |  36   |  33    |  30    |  27    |  24    |   21   |  18    |  15    |  12       |   9      |   6       |   3      |            |                   |
| COLUMN 1 |  RED  |  BLACK |  RED   |  RED   |  BLACK |   RED  |  RED   |  BLACK |  RED      |   RED    |   BLACK   |   RED    |            |   SELECTIONS      |
|          |       |        |        |        |        |        |        |        |           |          |           |          |            | N: STRAIGHT UP    |
+-------------------------------------------------------------------------------------------------------------------------------+   0        | S: SPLIT          |
|          |       |        |        |        |        |        |        |        |           |          |           |          |   GREEN    | C: CORNER         |
|          | 35    |  32    | 29     | 26     |  23    |  20    |  17    |  14    |   11      |  8       |   5       |   2      |            | T: STREET         |
| COLUMN 2 | BLACK |  RED   | BLACK  | BLACK  |  RED   |  BLACK |  BLACK |  RED   |   BLACK   |  BLACK   |   RED     |   BLACK  |            | D: DBL STREET     |
|          |       |        |        |        |        |        |        |        |           |          |           |          |            | I:COLUMNS         |
|          |       |        |        |        |        |        |        |        |           |          |           |          |            | H: HIGH           |
+-------------------------------------------------------------------------------------------------------------------------------+            | L:LOW             |
|          |  34   |  31    |  28    |   25   |  22    |  19    |  16    |  13    |   10      |   7      |   4       |   1      +------------+ R:RED             |
|          |  RED  |  BLACK |  BLACK |   RED  |  BLACK |  RED   |  RED   |  BLACK |   BLACK   |   RED    |   BLACK   |   RED    |            | B:BLACK           |
| COLUMN 3 |       |        |        |        |        |        |        |        |           |          |           |          |            | E:EVEN            |
|          |       |        |        |        |        |        |        |        |           |          |           |          |   00       | G:DOZEN           |
|          |       |        |        |        |        |        |        |        |           |          |           |          |   GREEN    | O:ODDS            |
+------------------+--------+--------+-----------------+--------+--------+--------------------+----------+-----------+----------+            | Q: QUIT           |
           |                                  |                                   |                                             |            |                   |
           |        1ST DOZEN                 |          2ND DOZEN                |               3RD DOZEN                     |            +-------------------+
           |                                  |                                   |                                             |            |
           +-------------+----------------------------------------+---------------+-----+-------------------------+-------------+------------+
           |             |                    |                   |                     |                         |                          |   PLAYERS CASH
           |             |                    |     BLACK         |      RED            |       EVEN              |          1-18            |  {player.buyIn}
           |   19-36     |     ODD            |                   |                     |                         |                          |
           |             |                    |                   |                     |                         |                          |
           +-------------+--------------------+-------------------+---------------------+-------------------------+--------------------------+
");
        }
    }
}
