namespace UpdateChartTimer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1SeriesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1pictureBox1Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panel1SeriesChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1pictureBox1Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1SeriesChart
            // 
            this.panel1SeriesChart.BackColor = System.Drawing.Color.Transparent;
            this.panel1SeriesChart.BackImageTransparentColor = System.Drawing.Color.White;
            this.panel1SeriesChart.BackSecondaryColor = System.Drawing.Color.White;
            this.panel1SeriesChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.Title = "Time (S)";
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.IsReversed = true;
            chartArea1.AxisY.Title = "No. Of Packs";
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.panel1SeriesChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.Name = "Legend1";
            this.panel1SeriesChart.Legends.Add(legend1);
            this.panel1SeriesChart.Location = new System.Drawing.Point(0, 0);
            this.panel1SeriesChart.Name = "panel1SeriesChart";
            this.panel1SeriesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Green;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 5;
            series1.Name = "Packs Machine 1";
            this.panel1SeriesChart.Series.Add(series1);
            this.panel1SeriesChart.Size = new System.Drawing.Size(796, 389);
            this.panel1SeriesChart.TabIndex = 0;
            title1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            title1.Text = "Machine 1";
            title2.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title2.Name = "Title2";
            this.panel1SeriesChart.Titles.Add(title1);
            this.panel1SeriesChart.Titles.Add(title2);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 200;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel1pictureBox1Logo);
            this.panel1.Controls.Add(this.panel1SeriesChart);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 400);
            this.panel1.TabIndex = 1;
            // 
            // panel1pictureBox1Logo
            // 
            this.panel1pictureBox1Logo.BackColor = System.Drawing.Color.Transparent;
            this.panel1pictureBox1Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1pictureBox1Logo.BackgroundImage")));
            this.panel1pictureBox1Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1pictureBox1Logo.Location = new System.Drawing.Point(639, 345);
            this.panel1pictureBox1Logo.Name = "panel1pictureBox1Logo";
            this.panel1pictureBox1Logo.Size = new System.Drawing.Size(160, 56);
            this.panel1pictureBox1Logo.TabIndex = 1;
            this.panel1pictureBox1Logo.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Digi Display";
            ((System.ComponentModel.ISupportInitialize)(this.panel1SeriesChart)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel1pictureBox1Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart panel1SeriesChart;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox panel1pictureBox1Logo;
    }
}

