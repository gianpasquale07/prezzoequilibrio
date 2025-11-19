using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (string.IsNullOrEmpty(txb_q.Text)) throw new Exception("errore");

            int q;
            if (int.TryParse(txb_q.Text, out q) == false) throw new Exception("errore");

            int d = 90 - (4 * q);
            int o = 10 + (q ^ 3 / 100);

            MessageBox.Show($"la domanda è : d = {d} e l'offerta è : o = {o}");
        }
    }
}
