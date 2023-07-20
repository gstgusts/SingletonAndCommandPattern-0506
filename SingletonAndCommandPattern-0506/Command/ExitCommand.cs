using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAndCommandPattern_0506.Command
{
    public class ExitCommand : BaseCommand
    {
        public override string CommandName => "Exit (E)";

        public override void Execute()
        {
            Console.Write("Do you realy want to quit? (Y/N):");

            var userInput = Console.ReadLine();

            var result = userInput?.ToLower() == "y";

            CommandArguments = new object[] { result };

            base.Execute();
        }
    }
}
