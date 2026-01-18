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
            cbTrening = new ComboBox();
            cbTrener = new ComboBox();
            cbDvorana = new ComboBox();
            nudTrajanjeMin = new NumericUpDown();
            nudKapacitet = new NumericUpDown();
            lblNazivTreninga = new Label();
            lblTrener = new Label();
            lblNazivDvorane = new Label();
            lblTrajanje = new Label();
            lblKapacitet = new Label();
            lblDatumIVrijeme = new Label();
            lblPoruka = new Label();
            tlpMain = new TableLayoutPanel();
            btnDodaj = new Button();
            btnAzuriraj = new Button();
            btnObrisi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTermini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTrajanjeMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKapacitet).BeginInit();
            tlpMain.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTermini
            // 
            dgvTermini.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTermini.BackgroundColor = Color.White;
            dgvTermini.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTermini.Dock = DockStyle.Fill;
            dgvTermini.Location = new Point(4, 4);
            dgvTermini.Margin = new Padding(4);
            dgvTermini.Name = "dgvTermini";
            dgvTermini.RowHeadersWidth = 51;
            dgvTermini.Size = new Size(1485, 380);
            dgvTermini.TabIndex = 0;
            dgvTermini.TabStop = false;
            // 
            // txtPoruka
            // 
            txtPoruka.BackColor = Color.White;
            txtPoruka.BorderStyle = BorderStyle.None;
            txtPoruka.Location = new Point(1072, 555);
            txtPoruka.Margin = new Padding(4);
            txtPoruka.Multiline = true;
            txtPoruka.Name = "txtPoruka";
            txtPoruka.ReadOnly = true;
            txtPoruka.Size = new Size(342, 133);
            txtPoruka.TabIndex = 0;
            txtPoruka.TabStop = false;
            // 
            // dtpPocetak
            // 
            dtpPocetak.Format = DateTimePickerFormat.Custom;
            dtpPocetak.Location = new Point(1072, 449);
            dtpPocetak.Margin = new Padding(4);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.ShowUpDown = true;
            dtpPocetak.Size = new Size(342, 34);
            dtpPocetak.TabIndex = 6;
            // 
            // cbTrening
            // 
            cbTrening.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTrening.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTrening.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrening.FormattingEnabled = true;
            cbTrening.Location = new Point(274, 414);
            cbTrening.Margin = new Padding(4);
            cbTrening.Name = "cbTrening";
            cbTrening.Size = new Size(206, 36);
            cbTrening.TabIndex = 1;
            // 
            // cbTrener
            // 
            cbTrener.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTrener.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTrener.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrener.FormattingEnabled = true;
            cbTrener.Location = new Point(274, 476);
            cbTrener.Margin = new Padding(4);
            cbTrener.Name = "cbTrener";
            cbTrener.Size = new Size(206, 36);
            cbTrener.TabIndex = 2;
            // 
            // cbDvorana
            // 
            cbDvorana.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDvorana.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbDvorana.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDvorana.FormattingEnabled = true;
            cbDvorana.Location = new Point(274, 542);
            cbDvorana.Margin = new Padding(4);
            cbDvorana.Name = "cbDvorana";
            cbDvorana.Size = new Size(206, 36);
            cbDvorana.TabIndex = 3;
            // 
            // nudTrajanjeMin
            // 
            nudTrajanjeMin.Location = new Point(274, 620);
            nudTrajanjeMin.Margin = new Padding(4);
            nudTrajanjeMin.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nudTrajanjeMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTrajanjeMin.Name = "nudTrajanjeMin";
            nudTrajanjeMin.Size = new Size(206, 34);
            nudTrajanjeMin.TabIndex = 4;
            nudTrajanjeMin.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // nudKapacitet
            // 
            nudKapacitet.Location = new Point(274, 685);
            nudKapacitet.Margin = new Padding(4);
            nudKapacitet.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudKapacitet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudKapacitet.Name = "nudKapacitet";
            nudKapacitet.Size = new Size(206, 34);
            nudKapacitet.TabIndex = 5;
            nudKapacitet.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblNazivTreninga
            // 
            lblNazivTreninga.AutoSize = true;
            lblNazivTreninga.Location = new Point(70, 417);
            lblNazivTreninga.Margin = new Padding(4, 0, 4, 0);
            lblNazivTreninga.Name = "lblNazivTreninga";
            lblNazivTreninga.Size = new Size(143, 28);
            lblNazivTreninga.TabIndex = 17;
            lblNazivTreninga.Text = "Naziv treninga:";
            // 
            // lblTrener
            // 
            lblTrener.AutoSize = true;
            lblTrener.Location = new Point(70, 479);
            lblTrener.Margin = new Padding(4, 0, 4, 0);
            lblTrener.Name = "lblTrener";
            lblTrener.Size = new Size(69, 28);
            lblTrener.TabIndex = 17;
            lblTrener.Text = "Trener:";
            // 
            // lblNazivDvorane
            // 
            lblNazivDvorane.AutoSize = true;
            lblNazivDvorane.Location = new Point(70, 545);
            lblNazivDvorane.Margin = new Padding(4, 0, 4, 0);
            lblNazivDvorane.Name = "lblNazivDvorane";
            lblNazivDvorane.Size = new Size(142, 28);
            lblNazivDvorane.TabIndex = 17;
            lblNazivDvorane.Text = "Naziv dvorane:";
            // 
            // lblTrajanje
            // 
            lblTrajanje.AutoSize = true;
            lblTrajanje.Location = new Point(70, 622);
            lblTrajanje.Margin = new Padding(4, 0, 4, 0);
            lblTrajanje.Name = "lblTrajanje";
            lblTrajanje.Size = new Size(132, 28);
            lblTrajanje.TabIndex = 17;
            lblTrajanje.Text = "Trajanje (min):";
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Location = new Point(70, 687);
            lblKapacitet.Margin = new Padding(4, 0, 4, 0);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(98, 28);
            lblKapacitet.TabIndex = 17;
            lblKapacitet.Text = "Kapacitet:";
            // 
            // lblDatumIVrijeme
            // 
            lblDatumIVrijeme.AutoSize = true;
            lblDatumIVrijeme.Location = new Point(1072, 417);
            lblDatumIVrijeme.Margin = new Padding(4, 0, 4, 0);
            lblDatumIVrijeme.Name = "lblDatumIVrijeme";
            lblDatumIVrijeme.Size = new Size(229, 28);
            lblDatumIVrijeme.TabIndex = 18;
            lblDatumIVrijeme.Text = "Datum i vrijeme početka:";
            // 
            // lblPoruka
            // 
            lblPoruka.AutoSize = true;
            lblPoruka.Location = new Point(1072, 523);
            lblPoruka.Margin = new Padding(4, 0, 4, 0);
            lblPoruka.Name = "lblPoruka";
            lblPoruka.Size = new Size(76, 28);
            lblPoruka.TabIndex = 17;
            lblPoruka.Text = "Poruka:";
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(dgvTermini, 0, 0);
            tlpMain.Dock = DockStyle.Top;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(4);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.Size = new Size(1493, 388);
            tlpMain.TabIndex = 19;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.Aqua;
            btnDodaj.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodaj.Location = new Point(13, 760);
            btnDodaj.Margin = new Padding(4);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(200, 70);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "UNESI\r\nTERMIN";
            btnDodaj.UseVisualStyleBackColor = false;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.BackColor = Color.Turquoise;
            btnAzuriraj.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAzuriraj.Location = new Point(643, 760);
            btnAzuriraj.Margin = new Padding(4);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new Size(200, 70);
            btnAzuriraj.TabIndex = 8;
            btnAzuriraj.Text = "AŽURIRAJ\r\nTERMIN";
            btnAzuriraj.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.Red;
            btnObrisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnObrisi.Location = new Point(1280, 760);
            btnObrisi.Margin = new Padding(4);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(200, 70);
            btnObrisi.TabIndex = 9;
            btnObrisi.Text = "OBRIŠI\r\nTERMIN";
            btnObrisi.UseVisualStyleBackColor = false;
            // 
            // FormTerminTreninga
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1493, 843);
            Controls.Add(btnObrisi);
            Controls.Add(btnAzuriraj);
            Controls.Add(btnDodaj);
            Controls.Add(tlpMain);
            Controls.Add(lblDatumIVrijeme);
            Controls.Add(lblTrener);
            Controls.Add(lblTrajanje);
            Controls.Add(lblPoruka);
            Controls.Add(lblKapacitet);
            Controls.Add(lblNazivDvorane);
            Controls.Add(lblNazivTreninga);
            Controls.Add(nudKapacitet);
            Controls.Add(nudTrajanjeMin);
            Controls.Add(cbDvorana);
            Controls.Add(cbTrener);
            Controls.Add(cbTrening);
            Controls.Add(dtpPocetak);
            Controls.Add(txtPoruka);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormTerminTreninga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Termin treninga";
            Load += FormTerminTreninga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTermini).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTrajanjeMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKapacitet).EndInit();
            tlpMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTermini;
        private TextBox txtPoruka;
        private DateTimePicker dtpPocetak;
        private ComboBox cbTrening;
        private ComboBox cbTrener;
        private ComboBox cbDvorana;
        private NumericUpDown nudTrajanjeMin;
        private NumericUpDown nudKapacitet;
        private Label lblNazivTreninga;
        private Label lblTrener;
        private Label lblNazivDvorane;
        private Label lblTrajanje;
        private Label lblKapacitet;
        private Label lblDatumIVrijeme;
        private Label lblPoruka;
        private TableLayoutPanel tlpMain;
        private Button btnDodaj;
        private Button btnAzuriraj;
        private Button btnObrisi;
    }
}