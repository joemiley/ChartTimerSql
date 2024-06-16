using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace UpdateChartTimer
{
    public partial class Form1 : Form
    {
        static string serverInstance = @"DEL-LT4\MSSQLSERVER1";
        static string serverName = "worldview";
        static string user = "sa";
        static string password = "D1g1house";
        static string sqlReturnData = "";

        Random rng = new Random();
        static SqlConnection conn;

        static List<string> List_SqlResult = new List<string>();
        private double[] valuesArray = new double[100];

        
        public Form1()
        {
            InitializeComponent();
            updateTimer.Start();
            panel1SeriesChart.ChartAreas["ChartArea1"].AxisX.Title = "Time(s)";
            panel1SeriesChart.ChartAreas["ChartArea1"].AxisY.Title = "Pack No.";
            panel1SeriesChart.ChartAreas[0].AxisY.Maximum = 60;
            conn = new SqlConnection(@"Data Source= " + serverInstance + ";Initial Catalog=" + serverName + ";User ID=" + user + ";Password=" + password + ";");
            // try catch will stop the program crashing and give an error window if connection details are wrong
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database conenction failed to open", ex.Message);
            }
        }


        private void UpdateCpuChart()
        {
            panel1SeriesChart.Series["Packs Machine 1"].Points.Clear();
            panel1SeriesChart.Series["Packs Machine 1"].BorderWidth = 1;


            for (int i = 0; i < valuesArray.Length; i++)
            {
                panel1SeriesChart.Series["Packs Machine 1"].Points.AddY(valuesArray[i]);
            }
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            panel1.Width = Width;
            panel1.Height = Height;
            panel1SeriesChart.Width = Width-50;
            panel1SeriesChart.Height = Height-100;
            panel1pictureBox1Logo.Location = new Point(Width - 177, Height - 97);



            valuesArray[valuesArray.Length - 1] = pullData();
            
            Array.Copy(valuesArray, 1, valuesArray, 0, valuesArray.Length - 1);

            if (panel1SeriesChart.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
            }

        }

        public int pullData()
        {

            string sqlCommand = "select count(*) from PackData Where Date < GETDATE() and DATE > dateadd(second, -60, getdate())";
            SqlCommand cmd = new SqlCommand(sqlCommand, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sqlReturnData = reader.GetValue(0).ToString();
            }

            reader.Close();

            List_SqlResult.Add(sqlReturnData);
            if (List_SqlResult.Count >= 3)
            {
                List_SqlResult.RemoveAt(0);
            }

            Int32.TryParse(List_SqlResult[0], out int SqlResultInt);

            return SqlResultInt;
        }


    }
}
