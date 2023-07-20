using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAndCommandPattern_0506.Command
{
    public class ListCommand : BaseCommand
    {
        public override string CommandName => "List (L)";

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
