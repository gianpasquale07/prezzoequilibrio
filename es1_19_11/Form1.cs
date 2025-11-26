using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace es1_19_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcola_Click(object sender, EventArgs e)
        {
            //domanda
            double a = double.Parse(txb_a.Text);
            double b = double.Parse(txb_b.Text);

            //offerta
            double c = double.Parse(txb_c.Text);
            double g = double.Parse(txb_g.Text);
            double f = double.Parse(txb_f.Text);

            //resettaggio grafico
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Quantità";
            chart1.ChartAreas[0].AxisY.Title = "Prezzo";
            chart1.Titles.Clear();
            chart1.Titles.Add("Domanda e Offerta - Prezzo di Equilibrio");

            //linea domanda
            Series domanda = new Series("Domanda");
            domanda.ChartType = SeriesChartType.Line;
            domanda.Color = Color.Red;
            domanda.BorderWidth = 3;

            //liea offerta
            Series offerta = new Series("Offerta");
            offerta.ChartType = SeriesChartType.Line;
            offerta.Color = Color.Blue;
            offerta.BorderWidth = 3;

            //inserimento delle linee nel grafico
            chart1.Series.Add(domanda);
            chart1.Series.Add(offerta);

            // calcoli per q da 0 a 20
            for (int q = 0; q <= 20; q++)
            {
                //domanda
                double d = a - (b * q);

                //offerta
                double o = c + (Math.Pow(q, g) / f);

                domanda.Points.AddXY(q, d);
                offerta.Points.AddXY(q, o);
            }
        }
    }
}
