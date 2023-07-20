using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAndCommandPattern_0506
{
    public sealed class MenuUiService
    {
        private static readonly MenuUiService _instance = new MenuUiService();

        private MenuService _menuService;

        static MenuUiService()
        {
        }

        private MenuUiService()
        {
            _menuService = MenuService.Instance;

        }

        public static MenuUiService Instance => _instance;

        public void PrintMenu()
        {
            do
            {
                PrintMenuItems();

                Console.Write("Select a command: ");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case MenuConstants.MenuActionCommands.Add:
                        break;
                    case MenuConstants.MenuActionCommands.List:
                        break;
                    case MenuConstants.MenuActionCommands.Remove:
                        break;
                    case MenuConstants.MenuActionCommands.Exit:
                        break;
                    default:
                        Console.WriteLine("This option is not available");
                        continue;
                }

            } while (true);
        }

        private void PrintMenuItems()
        {
            var commands = _menuService.Commands;

            foreach (var command in commands)
            {
                Console.WriteLine(command.CommandName);
            }
        }
    }
}
