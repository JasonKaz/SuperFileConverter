using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFileConverter.Entities.ConverterWrappers
{
    public class FFmpeg:AbstractConverterWrapper
    {
        public override string ParseSettings()
        {
            throw new NotImplementedException();
        }

        public override List<string> AllowedInputTypes
        {
            get { throw new NotImplementedException(); }
        }

        public override List<string> AllowedOutputTypes
        {
            get { throw new NotImplementedException(); }
        }
    }
}
