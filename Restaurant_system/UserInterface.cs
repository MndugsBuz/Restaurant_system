using Restaurant_system.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_system
{
    internal class UserInterface
    {
        public void Menu()
        {
            Console.WriteLine("Menu [1]: Waiter [1] Waiters Table List [2]");
            Console.WriteLine("Menu [2]: Visitor [1] Visitor Order [2]");
            Console.WriteLine("Menu [3]: Order [1] Report orders List [2]");
            Console.WriteLine("Menu [4]: Tables [1] Rport table List [2]");
            Console.WriteLine("Menu [5]: Product [1] Product List [2]");
            Console.WriteLine("Menu [6]: Quit the Program");

        }

        public void MenuOption()
        {
              
            Console.WriteLine("Choose your action");
            int menuOption = int.Parse(Console.ReadLine());
            bool exit = true;
            TablesRepository tablesRepository = new TablesRepository();

            while (exit)
            {

                switch (menuOption)
                {

                    case 1:
                        {
                            Console.WriteLine("Menu [1]: Waiter [1] Waiters Table List [2]");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Menu [2]: Visitor [1] Visitor Order [2]");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Menu [3]: Order [1] Report orders List [2]");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Menu [4]: Table [1] Rport table List [2]");
                            
                            //tablesRepository.GenerateTablesDataToJson();
                            tablesRepository.ReadFromJson();
                            tablesRepository.PrintTables();
                           
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Menu [5]: Product [1] Product List [2]");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Menu [6]: Quit the Program");
                            tablesRepository.WriteToJson();
                            exit = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Menu [6]: Quit the Program");
                            exit = false;
                            break;
                        }

                }
                if (menuOption == 1 || menuOption == 2 || menuOption == 3 || menuOption == 4 || menuOption == 5)
                {
                    Menu();
                    menuOption = int.Parse(Console.ReadLine());
                }
            }


        }

    }


}
