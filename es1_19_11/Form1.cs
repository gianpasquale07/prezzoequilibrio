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
            double q_eq = -1;
            double prezzo_eq = 0;
            double differenzaMin = double.MaxValue;

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
            domanda.MarkerStyle = MarkerStyle.Circle;   
            domanda.MarkerSize = 7;
            domanda.Color = Color.Red;
            domanda.BorderWidth = 3;

            //liea offerta
            Series offerta = new Series("Offerta");
            offerta.ChartType = SeriesChartType.Line;
            offerta.MarkerStyle = MarkerStyle.Circle;   
            offerta.MarkerSize = 7;
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

                double diff = Math.Abs(d - o);

                if (diff < differenzaMin)
                {
                    differenzaMin = diff;
                    q_eq = q;
                    prezzo_eq = (d + o) / 2;
                }
            }

            lbl_qe.Text = q_eq.ToString();
            lbl_pe.Text = prezzo_eq.ToString("0.000");

            //tabella
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("q", "Quantità");
            dataGridView1.Columns.Add("d", "Domanda");
            dataGridView1.Columns.Add("o", "Offerta");

            //calcolo valori
            for (int q = 0; q <= 20; q++)
            {
                // domanda
                double d = a - (b * q);
                // offerta
                double o = c + (Math.Pow(q, g) / f);     

                dataGridView1.Rows.Add(q, d.ToString("0.00"), o.ToString("0.00"));
            }
        }
    }
}
