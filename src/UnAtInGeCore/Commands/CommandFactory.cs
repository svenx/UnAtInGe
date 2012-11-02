using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnAtInGeCore.Commands
{
    public class CommandFactory
    {

        public static CommandBase CommandPause()
        {
            return new CommandBase("pause");
        }

    }
}
