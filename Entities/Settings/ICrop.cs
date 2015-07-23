using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFileConverter.Entities.Settings
{
    interface ICrop
    {
        int? CropX1 { get; set; }

        int? CropY1 { get; set; }

        int? CropX2 { get; set; }

        int? CropY2 { get; set; }

        int? CropMode { get; set; }
    }
}
