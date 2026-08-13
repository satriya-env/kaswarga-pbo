using System.Data;

namespace kaswarga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Stat.Datasets.Add(Spline);
            UpdateChart();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateChart()
        {
            Spline.DataPoints.Clear();
            Spline.DataPoints.Add("Sen", 50);
            Spline.DataPoints.Add("Sel", 35);
            Spline.DataPoints.Add("Rab", 25);
            Spline.DataPoints.Add("Kam", 30);
            Spline.DataPoints.Add("Jum", 15);
            Spline.DataPoints.Add("Sab", 45);
            Spline.DataPoints.Add("Ahd", 30);

            Stat.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
