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

            //jeg kalder på klassen ellers kan jeg ikke få adgang til den i main.  userService i blåt er den lokale variabel jeg kan bruge i main.
            UserService userService = new UserService();

            while (ProgramRunning == true)
            {


                Console.WriteLine("===============================================");
                Console.WriteLine("               BOOK ET MØDELOKALE              ");
                Console.WriteLine("===============================================");
                Console.WriteLine("");
                Console.WriteLine("1)  Register bruger");
                Console.WriteLine("2)  Vis regisretet brugere");
                Console.WriteLine("3)  Information på Lokaler");
                Console.WriteLine("4)  Status på lokaler");
                Console.WriteLine("5)  Book et lokale");
                Console.WriteLine("6)  Sluk programmet");

                string input = Console.ReadLine().ToLower();


                switch (input)
                {
                    case "1":
                        Console.Clear();
                        userService.RegisterBruger();
                        break;

                    case "2":
                        Console.Clear();
                        userService.ShowUserList();
                        break;

                    case "3":
                        Console.Clear();

                        break;
                    case "4":
                        Console.Clear();
                       
                        break;

                    case "5":
                        Console.Clear();
                       
                        break;

                    case "6":
                        Console.Clear();

                        break;







                }







            
            }
        }
    }
}
