using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFileConverter.Entities.Settings
{
    interface IOptimize
    {
        int? OptimizeLevel { get; set; }
    }
}
