using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAndCommandPattern_0506.Command
{
    public interface ICommand
    {
        string CommandName { get; }
        void Execute();
    }
}
