using _123123;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace _123123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ProgramRunning = true;
            bool LogIn = false;

            // kalder klassen, så jeg kan bruge den i main
            Menu menu = new Menu();

            while (ProgramRunning == true)
            {
                while (LogIn == false)
                {
                    
                    menu.LogInMenu();
                }

                while (LogIn == true)
                {
                    Console.Clear();
                    menu.MainMenu();
                }

                




                
            }







            
            
        }
    }
}
