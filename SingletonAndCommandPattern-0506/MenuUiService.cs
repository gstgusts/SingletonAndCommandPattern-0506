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
            _menuService.RegisterFinishEvent(MenuConstants.MenuActionCommands.Exit, HandleExitCommand);
            _menuService.RegisterFinishEvent(MenuConstants.MenuActionCommands.Add, HandleAddCommand);
        }

        public static MenuUiService Instance => _instance;

        public void PrintMenu()
        {
            do
            {
                PrintMenuItems();

                Console.Write("Select a command: ");

                var userInput = Console.ReadLine();

                switch (userInput.ToUpper())
                {
                    case MenuConstants.MenuActionCommands.Add:
                    case MenuConstants.MenuActionCommands.List:
                    case MenuConstants.MenuActionCommands.Remove:
                    case MenuConstants.MenuActionCommands.Exit:
                        _menuService.Execute(userInput.ToUpper());
                        return;
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
                Console.WriteLine(command.Value.CommandName);
            }
        }

        private void HandleExitCommand(params object[] obj)
        {
            var returnValue = (bool)obj[0];

            if(!returnValue)
            {
                PrintMenu();
                return;
            }

            Console.WriteLine("Goodbye");
        }

        private void HandleAddCommand(params object[] obj)
        {
            Console.WriteLine("Record was added");
            PrintMenu();
        }
    }
}
