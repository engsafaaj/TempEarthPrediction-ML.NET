using TempEarthPredition.MLModels.TempModel;

namespace TempEarthPredition
{
    public partial class Form1 : Form
    {
        private MLHelper mLHelper;

       

        public Form1()
        {
            InitializeComponent();
            mLHelper = new MLHelper();
        }

        private void buttonPredict_Click(object sender, EventArgs e)
        {
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Year = (float)Convert.ToDouble(textBoxYear.Text),
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            textBoxResult.Text = result.Score.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void buttonTrain_Click(object sender, EventArgs e)
        {


            // Take Time
            progressBar1.Visible = true;
            await Task.Run(() => mLHelper.TrainAndTest());

            progressBar1.Visible = false;

            MessageBox.Show("RSquared:" + mLHelper.RSquared.ToString());
            MessageBox.Show("MeanSquaredError:"+mLHelper.MeanSquaredError.ToString());
            MessageBox.Show("RootMeanSquaredError:" + mLHelper.RootMeanSquaredError.ToString());
            MessageBox.Show("MeanAbsoluteError:" + mLHelper.MeanAbsoluteError.ToString());

        }

        private void buttonPredictNewModel_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = mLHelper.PredictValue((float)Convert.ToDecimal(textBoxYear.Text)).ToString();
        }
    }
}
