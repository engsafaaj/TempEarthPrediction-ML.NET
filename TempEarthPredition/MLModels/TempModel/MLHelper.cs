using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempEarthPredition.MLModels.TempModel
{
    public class MLHelper
    {
        private readonly MLContext mLContext;
        ITransformer _trainModel;

        public double RSquared { get; set; }
        public double MeanAbsoluteError { get; set; }
        public double MeanSquaredError { get; set; }
        public double RootMeanSquaredError { get; set; }

        public MLHelper()
        {
            mLContext = new MLContext();
        }

        // Train & Test Model
        public void TrainAndTest()
        {
            // Get and Set Data
            var dataPath = "Average Temperature 1900-2023- New.csv";

            IDataView dataView = mLContext.Data.LoadFromTextFile<TempInput>(dataPath, separatorChar: ',', hasHeader: true);

            var data = mLContext.Data.TrainTestSplit(dataView, testFraction: 0.2);

            var dataTrain = data.TrainSet;
            var dataTest = data.TestSet;

            // Build Model

            var pipeLine = mLContext.Transforms.Concatenate("Features", "Year")
                .Append(mLContext.Regression.Trainers.Sdca(labelColumnName: "TempC", maximumNumberOfIterations: 50));

            // Train Model

            _trainModel = pipeLine.Fit(dataTrain);

            // Test

            var prediction = _trainModel.Transform(dataTest);
            var metrics = mLContext.Regression.Evaluate(prediction,labelColumnName:"TempC");
            RSquared = metrics.RSquared;
            MeanAbsoluteError = metrics.MeanAbsoluteError;
            MeanSquaredError = metrics.MeanSquaredError;
            RootMeanSquaredError = metrics.RootMeanSquaredError;

            // Save Model
            mLContext.Model.Save(_trainModel, data.TrainSet.Schema, "TempModel.zip");

        }


        public float PredictValue(float year)
        {
            MLContext _molContext = new MLContext();
            var input = new TempInput() { Year = year }; // Set Input

            ITransformer preTrainModel = _molContext.Model.Load("TempModel.zip", out var inputSchema); // Load Model

            var predictFun = _molContext.Model.CreatePredictionEngine<TempInput, TempOutput>(preTrainModel); // Create Function

            return predictFun.Predict(input).Score; // Get Result
        }
    }
}
