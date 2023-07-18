using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAndCommandPattern_0506.Command
{
    public class ExitCommand : ICommand
    {
        public string CommandName => "Exit (E)";

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
