using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFileConverter.Entities.Settings;

namespace SuperFileConverter.Entities.ConverterWrappers
{
    public class Gifsicle : AbstractConverterWrapper, IScale, IDistinctColors, IOptimize, ICrop
    {
        public Gifsicle()
        {
            this.Name = "Gifsicle";
            this.ExePath = new Uri(Environment.CurrentDirectory + "\\Converters\\Gifsicle\\gifsicle.exe");
            this.Version = this.RunCommand("--version", true)[0].Split(' ').Last();
        }

        public override string ParseSettings()
        {
            StringBuilder args = new StringBuilder();

            if (CropX1 != null && CropY1 != null)
            {
                if (CropX2 != null && CropY2 != null)
                {
                    if (CropMode == 1)
                    {
                        args.AppendFormat(" --crop {0},{1}-{2},{3}", CropX1, CropY1, CropX2, CropY2);
                    }
                    else
                    {
                        args.AppendFormat(" --crop {0},{1}+{2}x{3}", CropX1, CropY1, CropX2, CropY2);
                    }
                }
                else
                {
                    args.AppendFormat(" --crop {0}x{1}", CropX1, CropY1);
                }
            }

            if (InputFile != null)
            {
                args.AppendFormat(" {0}", InputFile.LocalPath);
            }

            if (Scale != null)
            {
                args.AppendFormat(" --scale {0}", Scale);
            }

            if (DistinctColors != null)
            {
                args.AppendFormat(" --colors {0}", DistinctColors);
            }

            if (OptimizeLevel != null)
            {
                string val;

                switch (OptimizeLevel)
                {
                    case 1:
                        val = "-O1";
                        break;

                    case 2:
                        val = "-O2";
                        break;

                    case 3:
                    default:
                        val = "-O3";
                        break;
                }

                args.AppendFormat(" {0}", val);
            }

            if (OutputFile != null)
            {
                args.AppendFormat(" --output {0}", OutputFile.LocalPath);
            }

            return args.ToString();
        }

        public double? Scale { get; set; }

        public int? DistinctColors { get; set; }

        public int? OptimizeLevel { get; set; }

        public int? CropX1 { get; set; }

        public int? CropY1 { get; set; }

        public int? CropX2 { get; set; }

        public int? CropY2 { get; set; }

        public int? CropMode { get; set; }

        public override List<string> AvailableSettings
        {
            get {
                return new List<string> { "Scale", "DistinctColors", "Optimize", "Crop" };
            }
        }
    }
}
