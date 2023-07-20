using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAndCommandPattern_0506.Command
{
    public class RemoveCommand : BaseCommand
    {
        public override string CommandName => "Remove (R)";

        public override void Execute()
        {
            MenuUiService.Instance.PrintMenu();
        }
    }
}
