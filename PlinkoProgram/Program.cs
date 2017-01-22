using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PLINKO is a device for statistic experiments(and also an amusing game!)
//It consists of an upright board with evenly spaced pegs in triangular form.
//Balls are dropped from the opening at the top of the board. Every time a ball
//hits a peg, it has a 50% chance of falling to the left or the right. Piles of
//balls are accumulated in slots at the bottom of the board.

//Write a program that simulates the playing of the game.  Your program should:
//1.	Prompt the user for the number of balls to play
//2.	Prompt the user for the number of slots (hint:  this should be an array
//    that keeps a running total of the number of balls in each slot)
//3.	Display the path of each ball dropped by displaying a sequence of left(L)
//    or right(R) moves the ball makes as well as the slot number it falls into
//    (hint: the number of LR moves will always be one less than the number of slots
//    on the board. Also, the slot can be determined by counting the number of right
//    moves the ball makes.)
//4.	After all balls have been dropped and paths reported, display a histogram of
//    the contents of each slot


namespace PlinkoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many balls would you like to play? ");
            int numBalls = int.Parse(Console.ReadLine());
            Console.Write("\nHow many slots in the Plinko board? ");
            int numSlots = int.Parse(Console.ReadLine());

            int[] boardLayout = new int[numSlots];

            for(int i = 0; i < boardLayout.Length; i++)
                boardLayout[i] = 0;


            for(int i = 0; i <= numBalls; i++)
            {
                String dropResult = dropBall(numSlots);
                int slotResult = calcSlot(dropResult);
                Console.WriteLine(dropResult + "   " + slotResult);
                boardLayout[slotResult]++;
            }

        }

        public static String dropBall(int numSlots)
        {
            String dropResult = null;
            Random rand = new Random();

            for(int i = 0; i < numSlots; i++)
            {
                if (rand.Next(0, 2) == 0)
                    dropResult = dropResult + "L";
                else
                    dropResult = dropResult + "R";
            }
            return dropResult;
        }

        public static int calcSlot(String record)
        {
            int slot = record.Split('R').Length - 1;
            return slot;
        }
    }
}
