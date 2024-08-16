using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempEarthPredition.MLModels.TempModel
{
    public class TempInput
    {

        [ColumnName("Year")]
        [LoadColumn(0)]
        public float Year { get; set; }

        [ColumnName("TempC")]
        [LoadColumn(1)]
        public float TempC { get; set; }
    }
}
