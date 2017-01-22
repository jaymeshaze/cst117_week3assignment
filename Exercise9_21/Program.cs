using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Develop a GUI that reverses an array.Allow the user to choose random input or to input
//the array manually.Display the array in a bar chart on the left of a form.Provide a button,
//and when the user presses the button do one more interchange of elements, displaying
//the partially reversed array on the right of the form.When the reversal is
//complete, disable the button.

namespace Exercise9_21
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
