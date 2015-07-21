using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFileConverter.ConverterWrappers
{
    interface IConverterWrapper
    {
        string Name { get; }

        string Version { get; }

        Uri ExePath { get; }

        Uri InputFile { get; set; }

        Uri OutputFile { get; set; }

        List<string> RunCommand(string args, bool redirect);
    }
}
