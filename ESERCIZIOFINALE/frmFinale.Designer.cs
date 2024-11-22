namespace ESERCIZIOFINALE
{
    partial class frmFinale
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
            this.dgvListaBici = new System.Windows.Forms.DataGridView();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelaio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.nudPotenza = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbModello = new System.Windows.Forms.ComboBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.txtCodiceBici = new System.Windows.Forms.TextBox();
            this.btnCercaBiciDictionary = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotenza)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaBici
            // 
            this.dgvListaBici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaBici.Location = new System.Drawing.Point(393, 12);
            this.dgvListaBici.Name = "dgvListaBici";
            this.dgvListaBici.RowHeadersWidth = 51;
            this.dgvListaBici.RowTemplate.Height = 24;
            this.dgvListaBici.Size = new System.Drawing.Size(805, 426);
            this.dgvListaBici.TabIndex = 0;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(137, 12);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(250, 22);
            this.txtPeso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "PESO";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "PREZZO";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(137, 44);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(250, 22);
            this.txtPrezzo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "TIPO CAMBIO";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(137, 111);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(250, 22);
            this.txtCambio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "TIPO TELAIO";
            // 
            // txtTelaio
            // 
            this.txtTelaio.Location = new System.Drawing.Point(137, 79);
            this.txtTelaio.Name = "txtTelaio";
            this.txtTelaio.Size = new System.Drawing.Size(250, 22);
            this.txtTelaio.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "COLORE";
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(137, 146);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(250, 22);
            this.txtColore.TabIndex = 11;
            // 
            // nudPotenza
            // 
            this.nudPotenza.Location = new System.Drawing.Point(137, 177);
            this.nudPotenza.Maximum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.nudPotenza.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudPotenza.Name = "nudPotenza";
            this.nudPotenza.Size = new System.Drawing.Size(163, 22);
            this.nudPotenza.TabIndex = 13;
            this.nudPotenza.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "POTENZA";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(137, 219);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(163, 24);
            this.cmbMarca.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "MARCA";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "MODELLO";
            // 
            // cmbModello
            // 
            this.cmbModello.FormattingEnabled = true;
            this.cmbModello.Location = new System.Drawing.Point(137, 256);
            this.cmbModello.Name = "cmbModello";
            this.cmbModello.Size = new System.Drawing.Size(163, 24);
            this.cmbModello.TabIndex = 17;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(265, 398);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(122, 40);
            this.btnAggiungi.TabIndex = 19;
            this.btnAggiungi.Text = "AGGIUNGI";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // txtCodiceBici
            // 
            this.txtCodiceBici.Location = new System.Drawing.Point(137, 322);
            this.txtCodiceBici.Name = "txtCodiceBici";
            this.txtCodiceBici.Size = new System.Drawing.Size(250, 22);
            this.txtCodiceBici.TabIndex = 20;
            // 
            // btnCercaBiciDictionary
            // 
            this.btnCercaBiciDictionary.Location = new System.Drawing.Point(137, 350);
            this.btnCercaBiciDictionary.Name = "btnCercaBiciDictionary";
            this.btnCercaBiciDictionary.Size = new System.Drawing.Size(87, 22);
            this.btnCercaBiciDictionary.TabIndex = 21;
            this.btnCercaBiciDictionary.Text = "CERCA";
            this.btnCercaBiciDictionary.UseVisualStyleBackColor = true;
            this.btnCercaBiciDictionary.Click += new System.EventHandler(this.btnCercaBiciDictionary_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "CODICE BICI";
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(300, 350);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(87, 22);
            this.btnElimina.TabIndex = 23;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // frmFinale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 450);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCercaBiciDictionary);
            this.Controls.Add(this.txtCodiceBici);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbModello);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudPotenza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelaio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.dgvListaBici);
            this.Name = "frmFinale";
            this.Text = "BICICLETTE ELETTRICHE";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotenza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaBici;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelaio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.NumericUpDown nudPotenza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbModello;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.TextBox txtCodiceBici;
        private System.Windows.Forms.Button btnCercaBiciDictionary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnElimina;
    }
}

