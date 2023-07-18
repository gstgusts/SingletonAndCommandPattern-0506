using SingletonAndCommandPattern_0506.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAndCommandPattern_0506
{
    public sealed class MenuService
    {
        private static readonly MenuService _instance = new MenuService();

        static MenuService()
        {
        }

        private MenuService()
        {
            _commands.Add(new ListCommand());
            _commands.Add(new AddCommand());
            _commands.Add(new RemoveCommand());
            _commands.Add(new ExitCommand());
        }

        public static MenuService Instance => _instance;

        public void Execute(ICommand command)
        {
            command.Execute();
        }

        private List<ICommand> _commands = new List<ICommand>();

        public IEnumerable<ICommand> Commands => _commands;
    }
}
