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
            lblNazivTreninga = new Label();
            lblTrener = new Label();
            lblNazivDvorane = new Label();
            lblTrajanje = new Label();
            lblKapacitet = new Label();
            lblDatumIVrijeme = new Label();
            lblPoruka = new Label();
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
            dgvTermini.Size = new Size(746, 263);
            dgvTermini.TabIndex = 0;
            // 
            // txtPoruka
            // 
            txtPoruka.BackColor = Color.White;
            txtPoruka.Location = new Point(574, 416);
            txtPoruka.Multiline = true;
            txtPoruka.Name = "txtPoruka";
            txtPoruka.ReadOnly = true;
            txtPoruka.ScrollBars = ScrollBars.Vertical;
            txtPoruka.Size = new Size(250, 96);
            txtPoruka.TabIndex = 1;
            // 
            // dtpPocetak
            // 
            dtpPocetak.Format = DateTimePickerFormat.Custom;
            dtpPocetak.Location = new Point(574, 324);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.ShowUpDown = true;
            dtpPocetak.Size = new Size(250, 27);
            dtpPocetak.TabIndex = 7;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(108, 550);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 8;
            btnDodaj.Text = "DODAJ";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new Point(330, 550);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(94, 29);
            btnAzuriraj.TabIndex = 9;
            btnAzuriraj.Text = "AZURIRAJ";
            btnAzuriraj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(500, 550);
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
            cbTrening.Location = new Point(197, 298);
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
            cbTrener.Location = new Point(197, 342);
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
            cbDvorana.Location = new Point(197, 387);
            cbDvorana.Name = "cbDvorana";
            cbDvorana.Size = new Size(151, 28);
            cbDvorana.TabIndex = 13;
            // 
            // nudTrajanjeMin
            // 
            nudTrajanjeMin.Location = new Point(197, 443);
            nudTrajanjeMin.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nudTrajanjeMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTrajanjeMin.Name = "nudTrajanjeMin";
            nudTrajanjeMin.Size = new Size(150, 27);
            nudTrajanjeMin.TabIndex = 14;
            nudTrajanjeMin.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // nudKapacitet
            // 
            nudKapacitet.Location = new Point(197, 490);
            nudKapacitet.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudKapacitet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudKapacitet.Name = "nudKapacitet";
            nudKapacitet.Size = new Size(150, 27);
            nudKapacitet.TabIndex = 15;
            nudKapacitet.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnOcisti
            // 
            btnOcisti.Location = new Point(691, 550);
            btnOcisti.Name = "btnOcisti";
            btnOcisti.Size = new Size(94, 29);
            btnOcisti.TabIndex = 16;
            btnOcisti.Text = "OCISTI";
            btnOcisti.UseVisualStyleBackColor = true;
            // 
            // lblNazivTreninga
            // 
            lblNazivTreninga.AutoSize = true;
            lblNazivTreninga.Location = new Point(83, 301);
            lblNazivTreninga.Name = "lblNazivTreninga";
            lblNazivTreninga.Size = new Size(108, 20);
            lblNazivTreninga.TabIndex = 17;
            lblNazivTreninga.Text = "Naziv treninga:";
            // 
            // lblTrener
            // 
            lblTrener.AutoSize = true;
            lblTrener.Location = new Point(83, 345);
            lblTrener.Name = "lblTrener";
            lblTrener.Size = new Size(53, 20);
            lblTrener.TabIndex = 17;
            lblTrener.Text = "Trener:";
            // 
            // lblNazivDvorane
            // 
            lblNazivDvorane.AutoSize = true;
            lblNazivDvorane.Location = new Point(83, 390);
            lblNazivDvorane.Name = "lblNazivDvorane";
            lblNazivDvorane.Size = new Size(107, 20);
            lblNazivDvorane.TabIndex = 17;
            lblNazivDvorane.Text = "Naziv dvorane:";
            // 
            // lblTrajanje
            // 
            lblTrajanje.AutoSize = true;
            lblTrajanje.Location = new Point(83, 445);
            lblTrajanje.Name = "lblTrajanje";
            lblTrajanje.Size = new Size(103, 20);
            lblTrajanje.TabIndex = 17;
            lblTrajanje.Text = "Trajanje (min):";
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Location = new Point(83, 492);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(75, 20);
            lblKapacitet.TabIndex = 17;
            lblKapacitet.Text = "Kapacitet:";
            // 
            // lblDatumIVrijeme
            // 
            lblDatumIVrijeme.AutoSize = true;
            lblDatumIVrijeme.Location = new Point(574, 301);
            lblDatumIVrijeme.Name = "lblDatumIVrijeme";
            lblDatumIVrijeme.Size = new Size(175, 20);
            lblDatumIVrijeme.TabIndex = 18;
            lblDatumIVrijeme.Text = "Datum i vrijeme početka:";
            // 
            // lblPoruka
            // 
            lblPoruka.AutoSize = true;
            lblPoruka.Location = new Point(574, 387);
            lblPoruka.Name = "lblPoruka";
            lblPoruka.Size = new Size(56, 20);
            lblPoruka.TabIndex = 17;
            lblPoruka.Text = "Poruka:";
            // 
            // FormTerminTreninga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 602);
            Controls.Add(lblDatumIVrijeme);
            Controls.Add(lblTrener);
            Controls.Add(lblTrajanje);
            Controls.Add(lblPoruka);
            Controls.Add(lblKapacitet);
            Controls.Add(lblNazivDvorane);
            Controls.Add(lblNazivTreninga);
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
        private Label lblNazivTreninga;
        private Label lblTrener;
        private Label lblNazivDvorane;
        private Label lblTrajanje;
        private Label lblKapacitet;
        private Label lblDatumIVrijeme;
        private Label lblPoruka;
    }
}