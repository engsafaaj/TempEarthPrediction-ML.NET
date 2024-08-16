namespace TempEarthPredition
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxYear = new TextBox();
            buttonPredict = new Button();
            label2 = new Label();
            textBoxResult = new TextBox();
            buttonTrain = new Button();
            progressBar1 = new ProgressBar();
            buttonPredictNewModel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 50);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter Year:";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(40, 85);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(309, 34);
            textBoxYear.TabIndex = 1;
            // 
            // buttonPredict
            // 
            buttonPredict.Location = new Point(38, 165);
            buttonPredict.Name = "buttonPredict";
            buttonPredict.Size = new Size(311, 46);
            buttonPredict.TabIndex = 2;
            buttonPredict.Text = "Predict";
            buttonPredict.UseVisualStyleBackColor = true;
            buttonPredict.Click += buttonPredict_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 242);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 0;
            label2.Text = "Temp - C";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(40, 277);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(309, 34);
            textBoxResult.TabIndex = 1;
            // 
            // buttonTrain
            // 
            buttonTrain.Location = new Point(366, 78);
            buttonTrain.Name = "buttonTrain";
            buttonTrain.Size = new Size(292, 49);
            buttonTrain.TabIndex = 2;
            buttonTrain.Text = "Train";
            buttonTrain.UseVisualStyleBackColor = true;
            buttonTrain.Click += buttonTrain_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(49, 371);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(597, 44);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 3;
            progressBar1.Visible = false;
            // 
            // buttonPredictNewModel
            // 
            buttonPredictNewModel.Location = new Point(366, 165);
            buttonPredictNewModel.Name = "buttonPredictNewModel";
            buttonPredictNewModel.Size = new Size(292, 46);
            buttonPredictNewModel.TabIndex = 2;
            buttonPredictNewModel.Text = "Predict";
            buttonPredictNewModel.UseVisualStyleBackColor = true;
            buttonPredictNewModel.Click += buttonPredictNewModel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 427);
            Controls.Add(progressBar1);
            Controls.Add(buttonTrain);
            Controls.Add(buttonPredictNewModel);
            Controls.Add(buttonPredict);
            Controls.Add(textBoxResult);
            Controls.Add(label2);
            Controls.Add(textBoxYear);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "TempPredictor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxYear;
        private Button buttonPredict;
        private Label label2;
        private TextBox textBoxResult;
        private Button buttonTrain;
        private ProgressBar progressBar1;
        private Button buttonPredictNewModel;
    }
}
