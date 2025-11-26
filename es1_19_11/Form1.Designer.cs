namespace es1_19_11
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_a = new System.Windows.Forms.TextBox();
            this.txb_b = new System.Windows.Forms.TextBox();
            this.btn_calcola = new System.Windows.Forms.Button();
            this.txb_g = new System.Windows.Forms.TextBox();
            this.txb_c = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_f = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_qe = new System.Windows.Forms.Label();
            this.lbl_pe = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "d = a - b * q";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "b";
            // 
            // txb_a
            // 
            this.txb_a.Location = new System.Drawing.Point(82, 77);
            this.txb_a.Name = "txb_a";
            this.txb_a.Size = new System.Drawing.Size(134, 20);
            this.txb_a.TabIndex = 3;
            // 
            // txb_b
            // 
            this.txb_b.Location = new System.Drawing.Point(82, 112);
            this.txb_b.Name = "txb_b";
            this.txb_b.Size = new System.Drawing.Size(134, 20);
            this.txb_b.TabIndex = 4;
            // 
            // btn_calcola
            // 
            this.btn_calcola.Location = new System.Drawing.Point(57, 368);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(159, 56);
            this.btn_calcola.TabIndex = 5;
            this.btn_calcola.Text = "calcola";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.btn_calcola_Click);
            // 
            // txb_g
            // 
            this.txb_g.Location = new System.Drawing.Point(82, 227);
            this.txb_g.Name = "txb_g";
            this.txb_g.Size = new System.Drawing.Size(134, 20);
            this.txb_g.TabIndex = 10;
            // 
            // txb_c
            // 
            this.txb_c.Location = new System.Drawing.Point(82, 192);
            this.txb_c.Name = "txb_c";
            this.txb_c.Size = new System.Drawing.Size(134, 20);
            this.txb_c.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "g";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "c";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "o = c + q ^ g  / f";
            // 
            // txb_f
            // 
            this.txb_f.Location = new System.Drawing.Point(82, 267);
            this.txb_f.Name = "txb_f";
            this.txb_f.Size = new System.Drawing.Size(134, 20);
            this.txb_f.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "f";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(254, 24);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(463, 400);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(739, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(323, 400);
            this.dataGridView1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "quantità di equilibrio =";
            // 
            // lbl_qe
            // 
            this.lbl_qe.AutoSize = true;
            this.lbl_qe.Location = new System.Drawing.Point(169, 315);
            this.lbl_qe.Name = "lbl_qe";
            this.lbl_qe.Size = new System.Drawing.Size(25, 13);
            this.lbl_qe.TabIndex = 16;
            this.lbl_qe.Text = "???";
            // 
            // lbl_pe
            // 
            this.lbl_pe.AutoSize = true;
            this.lbl_pe.Location = new System.Drawing.Point(162, 342);
            this.lbl_pe.Name = "lbl_pe";
            this.lbl_pe.Size = new System.Drawing.Size(25, 13);
            this.lbl_pe.TabIndex = 18;
            this.lbl_pe.Text = "???";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "prezzo di equilibrio =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.lbl_pe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_qe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txb_f);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_g);
            this.Controls.Add(this.txb_c);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_calcola);
            this.Controls.Add(this.txb_b);
            this.Controls.Add(this.txb_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_a;
        private System.Windows.Forms.TextBox txb_b;
        private System.Windows.Forms.Button btn_calcola;
        private System.Windows.Forms.TextBox txb_g;
        private System.Windows.Forms.TextBox txb_c;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_f;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_qe;
        private System.Windows.Forms.Label lbl_pe;
        private System.Windows.Forms.Label label10;
    }
}

