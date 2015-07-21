using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace SuperFileConverter.ConverterWrappers
{
    abstract class AbstractConverterWrapper:IConverterWrapper
    {
        public string Name { get; protected set; }

        public string Version { get; protected set; }

        public Uri ExePath { get; protected set; }

        public Uri InputFile { get; set; }

        public Uri OutputFile { get; set; }

        public List<string> RunCommand(string args, bool redirect = false)
        {
            var ret = new List<string>();

            var startInfo = new ProcessStartInfo
            {
                FileName = this.ExePath.LocalPath,
                Arguments = args,
                UseShellExecute = false,
                RedirectStandardOutput = redirect,
                CreateNoWindow = false
            };

            var proc = new Process { StartInfo = startInfo };

            proc.Start();

            if (redirect)
            {
                while (!proc.StandardOutput.EndOfStream)
                {
                    ret.Add(proc.StandardOutput.ReadLine());
                }
            }

            return ret;
        }
    }
}
