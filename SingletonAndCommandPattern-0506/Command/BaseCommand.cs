using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAndCommandPattern_0506.Command
{
    public delegate void CommandFinishedEventHandler(params object[] obj);
    public abstract class BaseCommand : ICommand
    {
        public virtual string CommandName => "";

        public event CommandFinishedEventHandler? OnCommandFinished;

        protected object[]? CommandArguments { get; set; }

        public virtual void Execute()
        {
            if (OnCommandFinished != null)
            {
                if(CommandArguments != null)
                {
                    OnCommandFinished(CommandArguments);
                }

                OnCommandFinished();
            }
        }
    }
}
