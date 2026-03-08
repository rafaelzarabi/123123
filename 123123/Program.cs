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
                while (LogIn == false)
                {
                    Console.Clear();
                    LogIn = menu.LogInMenuBool();   // Vi har en return stafet med bool fra loginBool()-->loginMenuBool-->Main
                }        
                   
               Console.Clear();   
               LogIn = menu.MainMenuBool();      // Vi har en return stafet med bool fra  LogOut()-->mainMenu()-->Main()    
            }

           





            
            
        }
    }
}
