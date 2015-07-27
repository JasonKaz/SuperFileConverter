using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFileConverter.Entities.Settings;

namespace SuperFileConverter.Entities.ConverterWrappers
{
    public class ImageMagick : AbstractConverterWrapper, IScale, IDistinctColors, ICrop
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

            if (CropX1 != null && CropY1 != null)
            {
                if (CropX2 != null && CropY2 != null)
                {
                    if (CropMode == 1)
                    {
                        args.AppendFormat(" -crop {0}x{1}+{2}+{3} +repage", CropX1, CropY1, CropX2, CropY2);
                    }
                    else
                    {
                        int? _cropX2 = CropX1 + CropX2;
                        int? _cropY2 = CropY1 + CropY2;

                        args.AppendFormat(" -crop {0},{1}+{2}x{3} +repage", CropX1, CropY1, _cropX2, _cropY2);
                    }
                }
                else
                {
                    args.AppendFormat(" -crop {0}x{1}+0+0", CropX1, CropY1);
                }
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
                return new List<string> { "png", "jpg", "gif" };
            }
        }

        public override List<string> AllowedOutputTypes
        {
            get
            {
                return new List<string> { "png", "jpg", "gif" };
            }
        }

        public double? Scale { get; set; }

        public int? DistinctColors { get; set; }

        public int? CropX1 { get; set; }

        public int? CropY1 { get; set; }

        public int? CropX2 { get; set; }

        public int? CropY2 { get; set; }

        public int? CropMode { get; set; }
    }
}
