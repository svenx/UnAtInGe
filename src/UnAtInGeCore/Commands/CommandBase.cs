using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnAtInGeCore.Commands
{
    public class CommandBase
    {

        public string Name { get; set; }
        public bool ShowCommand { get; set; }

        public CommandBase(string name)
        {
            Name = name;
            ShowCommand = true;
        }

        public virtual string Execute()
        {
            if (!ShowCommand) return "@" + Name;
            return Name;
        }

    }
}
