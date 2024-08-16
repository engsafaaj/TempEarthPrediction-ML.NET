using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempEarthPredition.MLModels.TempModel
{
    public class TempOutput
    {
        [ColumnName("Score")]
        public float Score { get; set; }
    }
}
