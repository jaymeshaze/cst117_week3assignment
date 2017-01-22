using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Write a C# program that reads strings from a file and outputs the following statistics

//The first and last word alphabetically
//The number of words that start with a vowel
//The longest word
//The total number of words

//Challenge – not required
//Write a method that removes leading or trailing non-alphabetic characters from the strings before locating longest, shortest, etc…
//Output the results in a GUI.

namespace StringStatisticProgram
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
