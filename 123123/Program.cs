using _123123;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace _123123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kalder klassen, så jeg kan bruge den i main
            Menu menu = new Menu();
            UserService userService = new UserService();

            bool ProgramRunning = true;
            bool LogIn = false;


            

            while (ProgramRunning == true)
            {
                while (menu.LogInMenuBool() == false)
                {

                    Console.Clear();
                    //Vi har en stafet med bool metoder fra main, til loginmenu, til login
                    menu.LogInMenuBool();
                }        
                    Console.Clear();
                    menu.MainMenu();
                
                

                




                
            }







            
            
        }
    }
}
