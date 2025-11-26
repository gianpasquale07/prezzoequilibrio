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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_q = new System.Windows.Forms.TextBox();
            this.btn_calcola = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_o = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "q";
            // 
            // txb_q
            // 
            this.txb_q.Location = new System.Drawing.Point(112, 76);
            this.txb_q.Name = "txb_q";
            this.txb_q.Size = new System.Drawing.Size(190, 20);
            this.txb_q.TabIndex = 1;
            // 
            // btn_calcola
            // 
            this.btn_calcola.Location = new System.Drawing.Point(96, 121);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(206, 54);
            this.btn_calcola.TabIndex = 2;
            this.btn_calcola.Text = "calcola";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.btn_calcola_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "offerta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "domanda";
            // 
            // lbl_o
            // 
            this.lbl_o.AutoSize = true;
            this.lbl_o.Location = new System.Drawing.Point(454, 121);
            this.lbl_o.Name = "lbl_o";
            this.lbl_o.Size = new System.Drawing.Size(25, 13);
            this.lbl_o.TabIndex = 5;
            this.lbl_o.Text = "???";
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Location = new System.Drawing.Point(454, 79);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(25, 13);
            this.lbl_d.TabIndex = 6;
            this.lbl_d.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_d);
            this.Controls.Add(this.lbl_o);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_calcola);
            this.Controls.Add(this.txb_q);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_q;
        private System.Windows.Forms.Button btn_calcola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_o;
        private System.Windows.Forms.Label lbl_d;
    }
}

