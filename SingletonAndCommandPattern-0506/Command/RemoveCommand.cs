using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAndCommandPattern_0506.Command
{
    public class RemoveCommand : ICommand
    {
        public string CommandName => "Remove (R)";

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
