using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A Chicken House consists of N numbered spaces.  Each space can hold at most one Chicken.
//The spaces are indexed starting from 0; the index of the last space is N-1.
//No two Chickens in the barn will have the same name.

//  Chicken
//-name:String
//-monthsOld:int
//+Chicken(n:String, months:int):
//+getName():String
//+getMonths():int
//+setName(n:String):void
//+setMonths(m:int):void
//+toString():String


//4 points:
//Write the ChickenHouse method findChicken.If the ChickenHouse object SunnyDayFarm contains the following Chickens:

//    0        1        2        3        4        5
//  Sister   Beulah          Ms.Sassy           Crispy

//then the call
//    SunnyDayFarm.findChickenSpace(“Ms.Sassy”);
//would return a 3 and, the call
//    SunnyDayFarm.findChickenSpace(“Dolly”); 
//would return a -1.


//6 points:
//Write the ChickenHouse method consolidate.If the ChickenHouse object SunnyDayFarm contains the following Chickens:

//    0        1        2        3        4        5
//  Sister   Beulah          Ms.Sassy           Crispy

//then the call SunnyDayFarm.consolidate() would arrange the Chickens as shown below:

//    0        1        2        3        4        5
//  Sister  Beulah   Ms.Sassy  Crispy




namespace ChickenHouseProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Chicken
        {
            //-name:String
            //-monthsOld:int
            //+Chicken(n:String, months:int):
            //+getName():String
            //+getMonths():int
            //+setName(n:String):void
            //+setMonths(m:int):void
            //+toString():String
            String name;
            int monthsOld;
            
            public Chicken(String n, int months)
            {
                n = this.name;
                months = this.monthsOld;
            }

            public String getName()
            {
                return name;
            }
            public int getMonths()
            {
                return monthsOld;
            }
            public void setName(String n)
            {
                n = this.name;
            }
            public void setMonths(int m)
            {
                m = this.monthsOld;
            }
            public String toString()
            {
                return "Name: " + name + ", Months old: " + monthsOld + ".";
            }

        }


        public class ChickenHouse
        {
            /**
             * the spaces in the chicken house. Each array element holds a reference to
             * the Chicken that is currently occupying the space.  A null reference
             * indicates an empty space.
             */
            private Chicken[] spaces;

            /**
             * returns the index of the space that contains the 
             * Chicken with the specified name.
             * PRECONDITION:  no 2 Chickens have the same name
             * returns -1 if there is no Chicken with the specified name
             */
            public int findChicken(String name)
            {
                //found will hold index of found chicken, or -1 if not found
                int found = -1;
                //loop each index of array to compare name
                for(int i = 0; i < spaces.Length; i++)
                {
                    if (spaces[i].Equals(name))
                        found = i;
                }
                return found;
            }

            /**
             * consolidates the ChickenHouse by moving Chickens so that they
             * are in adjacent spaces, starting at index 0, with no empty space 
             * between any two Chickens.
             * POSTCONDITION:  the order of the Chickens is the same as before
             * the consolidation
             */
            public void consolidate()
            {
                //loop through each space in array
                for (int i = 0; i < spaces.Length; i++)
                {
                    //check to see is array space is blank
                    if(spaces[i] == null)
                    {
                        //check if i is the last space, to prevent OutOfBoundsException
                        if (i + 1 == spaces.Length)
                            break;
                        //if space is blank, look for next value and move to blank space and make previous space null
                        for (int j = i + 1; j < spaces.Length; j++)
                        {
                            if (spaces[j] != null)
                            {
                                spaces[i] = spaces[j];
                                spaces[j] = null;
                            }
                        }
                    }
                }
            }

        }
    }
}
