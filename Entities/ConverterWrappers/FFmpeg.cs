using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFileConverter.Entities.ConverterWrappers
{
    public class FFmpeg:AbstractConverterWrapper
    {
        public FFmpeg()
        {
            this.Name = "FFmpeg";
            this.ExePath = new Uri(Environment.CurrentDirectory + "\\Converters\\FFmpeg\\ffmpeg.exe");
            this.Version = this.RunCommand("-version", true)[0].Split(' ').Last();
        }

        public override string ParseSettings()
        {
            StringBuilder args = new StringBuilder();

            if (InputFile!= null && OutputFile!=null)
            {
                args.AppendFormat(" -i {0}", InputFile.LocalPath);

                args.AppendFormat(" -r {0}", 20);

                args.AppendFormat(" {0}", OutputFile.LocalPath);
            }

            return args.ToString();
        }

        public override List<string> AllowedInputTypes
        {
            get
            {
                return new List<string> { "webm" };
            }
        }

        public override List<string> AllowedOutputTypes
        {
            get
            {
                return new List<string> { "gif" };
            }
        }
    }
}
