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
            _commands.Add(MenuConstants.MenuActionCommands.List, new ListCommand());
            _commands.Add(MenuConstants.MenuActionCommands.Add, new AddCommand());
            _commands.Add(MenuConstants.MenuActionCommands.Remove,new RemoveCommand());
            _commands.Add(MenuConstants.MenuActionCommands.Exit, new ExitCommand());
        }

        public static MenuService Instance => _instance;

        public void Execute(ICommand command)
        {
            command.Execute();
        }

        public void Execute(string key)
        {
            var command = _commands[key];
            command.Execute();
        }

        private Dictionary<string, BaseCommand> _commands = new Dictionary<string, BaseCommand>();

        public IDictionary<string, BaseCommand> Commands => _commands;

        public void RegisterFinishEvent(string key, CommandFinishedEventHandler action)
        {
            var command = _commands[key];
            command.OnCommandFinished += action;
        }
    }
}
