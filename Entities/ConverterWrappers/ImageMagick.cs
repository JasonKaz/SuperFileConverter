using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFileConverter.Entities.Settings;

namespace SuperFileConverter.Entities.ConverterWrappers
{
    public class ImageMagick : AbstractConverterWrapper, IScale, IDistinctColors
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

            if (Scale != null)
            {
                args.AppendFormat(" -resize {0}", Utils.DecimalToPercent(Scale));
            }

            if (DistinctColors != null)
            {
                args.AppendFormat(" -colors {0}", DistinctColors);
            }

            if (OutputFile != null)
            {
                args.AppendFormat(" {0}", OutputFile.LocalPath);
            }

            return args.ToString();
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

        public double? Scale { get; set; }

        public int? DistinctColors { get; set; }
    }
}
