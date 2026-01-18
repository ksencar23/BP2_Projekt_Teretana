namespace BP2_Projekt_Teretana
{
    partial class FormTerminTreninga
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
            dgvTermini = new DataGridView();
            txtPoruka = new TextBox();
            dtpPocetak = new DateTimePicker();
            btnDodaj = new Button();
            btnAzuriraj = new Button();
            btnObrisi = new Button();
            cbTrening = new ComboBox();
            cbTrener = new ComboBox();
            cbDvorana = new ComboBox();
            nudTrajanjeMin = new NumericUpDown();
            nudKapacitet = new NumericUpDown();
            btnOcisti = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTermini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTrajanjeMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKapacitet).BeginInit();
            SuspendLayout();
            // 
            // dgvTermini
            // 
            dgvTermini.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTermini.Location = new Point(165, 12);
            dgvTermini.Name = "dgvTermini";
            dgvTermini.RowHeadersWidth = 51;
            dgvTermini.Size = new Size(480, 114);
            dgvTermini.TabIndex = 0;
            // 
            // txtPoruka
            // 
            txtPoruka.Location = new Point(474, 165);
            txtPoruka.Name = "txtPoruka";
            txtPoruka.Size = new Size(125, 27);
            txtPoruka.TabIndex = 1;
            // 
            // dtpPocetak
            // 
            dtpPocetak.Format = DateTimePickerFormat.Custom;
            dtpPocetak.Location = new Point(474, 230);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.ShowUpDown = true;
            dtpPocetak.Size = new Size(250, 27);
            dtpPocetak.TabIndex = 7;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(46, 395);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 8;
            btnDodaj.Text = "DODAJ";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(259, 395);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(94, 29);
            btnAzuriraj.TabIndex = 9;
            btnAzuriraj.Text = "AZURIRAJ";
            btnAzuriraj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(429, 395);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(94, 29);
            btnObrisi.TabIndex = 10;
            btnObrisi.Text = "OBRISI";
            btnObrisi.UseVisualStyleBackColor = true;
            // 
            // cbTrening
            // 
            cbTrening.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTrening.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTrening.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrening.FormattingEnabled = true;
            cbTrening.Location = new Point(95, 143);
            cbTrening.Name = "cbTrening";
            cbTrening.Size = new Size(151, 28);
            cbTrening.TabIndex = 11;
            // 
            // cbTrener
            // 
            cbTrener.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTrener.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTrener.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrener.FormattingEnabled = true;
            cbTrener.Location = new Point(95, 186);
            cbTrener.Name = "cbTrener";
            cbTrener.Size = new Size(151, 28);
            cbTrener.TabIndex = 12;
            // 
            // cbDvorana
            // 
            cbDvorana.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDvorana.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbDvorana.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDvorana.FormattingEnabled = true;
            cbDvorana.Location = new Point(95, 229);
            cbDvorana.Name = "cbDvorana";
            cbDvorana.Size = new Size(151, 28);
            cbDvorana.TabIndex = 13;
            // 
            // nudTrajanjeMin
            // 
            nudTrajanjeMin.Location = new Point(96, 283);
            nudTrajanjeMin.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nudTrajanjeMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTrajanjeMin.Name = "nudTrajanjeMin";
            nudTrajanjeMin.Size = new Size(150, 27);
            nudTrajanjeMin.TabIndex = 14;
            nudTrajanjeMin.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // nudKapacitet
            // 
            nudKapacitet.Location = new Point(96, 335);
            nudKapacitet.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudKapacitet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudKapacitet.Name = "nudKapacitet";
            nudKapacitet.Size = new Size(150, 27);
            nudKapacitet.TabIndex = 15;
            nudKapacitet.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnOcisti
            // 
            btnOcisti.Location = new Point(620, 395);
            btnOcisti.Name = "btnOcisti";
            btnOcisti.Size = new Size(94, 29);
            btnOcisti.TabIndex = 16;
            btnOcisti.Text = "OCISTI";
            btnOcisti.UseVisualStyleBackColor = true;
            // 
            // FormTerminTreninga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOcisti);
            Controls.Add(nudKapacitet);
            Controls.Add(nudTrajanjeMin);
            Controls.Add(cbDvorana);
            Controls.Add(cbTrener);
            Controls.Add(cbTrening);
            Controls.Add(btnObrisi);
            Controls.Add(btnAzuriraj);
            Controls.Add(btnDodaj);
            Controls.Add(dtpPocetak);
            Controls.Add(txtPoruka);
            Controls.Add(dgvTermini);
            Name = "FormTerminTreninga";
            Text = "Termin treninga";
            Load += FormTerminTreninga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTermini).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTrajanjeMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKapacitet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTermini;
        private TextBox txtPoruka;
        private DateTimePicker dtpPocetak;
        private Button btnDodaj;
        private Button btnAzuriraj;
        private Button btnObrisi;
        private ComboBox cbTrening;
        private ComboBox cbTrener;
        private ComboBox cbDvorana;
        private NumericUpDown nudTrajanjeMin;
        private NumericUpDown nudKapacitet;
        private Button btnOcisti;
    }
}