using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFileConverter.ConverterWrappers
{
    class Gifsicle:AbstractConverterWrapper
    {
        public Gifsicle()
        {
            this.Name = "Gifsicle";
            this.ExePath = new Uri(Environment.CurrentDirectory + "\\Converters\\Gifsicle\\gifsicle.exe");
            this.Version = this.RunCommand("--version", true)[0].Split(' ').Last();
        }
    }
}
