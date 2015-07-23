using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFileConverter.Entities.ConverterWrappers
{
    public class ImageMagick : AbstractConverterWrapper
    {
        public override string ParseSettings()
        {
            throw new NotImplementedException();
        }

        public override List<string> AvailableSettings
        {
            get { return new List<string> { }; }
        }
    }
}
