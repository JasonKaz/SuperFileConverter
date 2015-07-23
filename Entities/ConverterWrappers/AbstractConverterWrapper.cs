using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace SuperFileConverter.Entities.ConverterWrappers
{
    public abstract class AbstractConverterWrapper:IConverterWrapper
    {
        public string Name { get; protected set; }

        public string Version { get; protected set; }

        public Uri ExePath { get; protected set; }

        public Uri InputFile { get; set; }

        public Uri OutputFile { get; set; }

        abstract public string ParseSettings();

        abstract public List<string> AvailableSettings { get; }

        public string GetCommandFromSettings()
        {
            return string.Format("{0} {1}", this.ExePath.LocalPath, this.ParseSettings());
        }

        public List<string> RunCommandFromSettings(bool redirect = false)
        {
            return this.RunCommand(this.ParseSettings(), redirect);
        }

        public List<string> RunCommand(string args, bool redirect = false)
        {
            var ret = new List<string>();

            var startInfo = new ProcessStartInfo
            {
                FileName = this.ExePath.LocalPath,
                Arguments = args,
                UseShellExecute = false,
                RedirectStandardOutput = redirect,
                RedirectStandardError = true,
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

            while (!proc.StandardError.EndOfStream)
            {
                System.Diagnostics.Debug.WriteLine(proc.StandardError.ReadLine());
            }

            return ret;
        }
    }
}
