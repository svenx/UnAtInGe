using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnAtInGeCore.Commands
{
    public class CommandParameterBase:CommandBase
    {

        public string Parameter { get; set; }

        public CommandParameterBase(string name) : base(name)
        {
        }

        public string Execute(string parameter)
        {
            Parameter = parameter;
            return this.Execute();
        }


        public override string Execute()
        {
            return base.Execute() + " " + Parameter;
        }

    }
}
