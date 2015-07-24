using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFileConverter.Entities.ConverterWrappers
{
    public class ImageMagick : AbstractConverterWrapper
    {
        public ImageMagick()
        {
            this.Name = "ImageMagick";
            this.ExePath = new Uri(Environment.CurrentDirectory + "\\Converters\\ImageMagick\\convert.exe");
            this.Version = this.RunCommand("-version", true)[0].Split(' ')[2];
        }

        public override string ParseSettings()
        {
            StringBuilder args = new StringBuilder();

            if (InputFile != null)
            {
                args.AppendFormat(" {0}", InputFile.LocalPath);
            }

            if (OutputFile != null)
            {
                args.AppendFormat(" {0}", OutputFile.LocalPath);
            }

            return args.ToString();
        }

        public override List<string> AvailableSettings
        {
            get { return new List<string> { }; }
        }

        public override List<string> AllowedInputTypes
        {
            get
            {
                return new List<string> { "png", "jpg" };
            }
        }

        public override List<string> AllowedOutputTypes
        {
            get
            {
                return new List<string> { "png", "jpg" };
            }
        }
    }
}
