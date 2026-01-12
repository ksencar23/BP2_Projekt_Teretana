namespace BP2_Projekt_Teretana
{
    partial class FormUplata
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUplata = new DataGridView();
            txtClanarinaId = new TextBox();
            dtpDatum = new DateTimePicker();
            txtIznos = new TextBox();
            btnDodaj = new Button();
            btnObrisi = new Button();
            lblPoruka = new Label();
            lblClanarinaId = new Label();
            lblDatumUplate = new Label();
            lblIznosUplate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUplata).BeginInit();
            SuspendLayout();
            // 
            // dgvUplata
            // 
            dgvUplata.AllowUserToAddRows = false;
            dgvUplata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUplata.BackgroundColor = Color.White;
            dgvUplata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUplata.Dock = DockStyle.Top;
            dgvUplata.Location = new Point(0, 0);
            dgvUplata.Margin = new Padding(4);
            dgvUplata.MultiSelect = false;
            dgvUplata.Name = "dgvUplata";
            dgvUplata.ReadOnly = true;
            dgvUplata.RowHeadersVisible = false;
            dgvUplata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUplata.Size = new Size(850, 340);
            dgvUplata.TabIndex = 0;
            // 
            // txtClanarinaId
            // 
            txtClanarinaId.Location = new Point(117, 425);
            txtClanarinaId.Margin = new Padding(4);
            txtClanarinaId.Name = "txtClanarinaId";
            txtClanarinaId.Size = new Size(52, 29);
            txtClanarinaId.TabIndex = 1;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(576, 365);
            dtpDatum.Margin = new Padding(4);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(256, 29);
            dtpDatum.TabIndex = 2;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(117, 365);
            txtIznos.Margin = new Padding(4);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(127, 29);
            txtIznos.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(161, 550);
            btnDodaj.Margin = new Padding(4);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(129, 38);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "DODAJ";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(551, 550);
            btnObrisi.Margin = new Padding(4);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(129, 38);
            btnObrisi.TabIndex = 5;
            btnObrisi.Text = "OBRIŠI";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // lblPoruka
            // 
            lblPoruka.AutoSize = true;
            lblPoruka.Location = new Point(461, 433);
            lblPoruka.Margin = new Padding(4, 0, 4, 0);
            lblPoruka.Name = "lblPoruka";
            lblPoruka.Size = new Size(45, 21);
            lblPoruka.TabIndex = 6;
            lblPoruka.Text = "Opis:";
            // 
            // lblClanarinaId
            // 
            lblClanarinaId.AutoSize = true;
            lblClanarinaId.Location = new Point(13, 428);
            lblClanarinaId.Margin = new Padding(4, 0, 4, 0);
            lblClanarinaId.Name = "lblClanarinaId";
            lblClanarinaId.Size = new Size(96, 21);
            lblClanarinaId.TabIndex = 7;
            lblClanarinaId.Text = "Clanarina id:";
            // 
            // lblDatumUplate
            // 
            lblDatumUplate.AutoSize = true;
            lblDatumUplate.Location = new Point(461, 365);
            lblDatumUplate.Margin = new Padding(4, 0, 4, 0);
            lblDatumUplate.Name = "lblDatumUplate";
            lblDatumUplate.Size = new Size(107, 21);
            lblDatumUplate.TabIndex = 9;
            lblDatumUplate.Text = "Datum uplate:";
            // 
            // lblIznosUplate
            // 
            lblIznosUplate.AutoSize = true;
            lblIznosUplate.Location = new Point(13, 365);
            lblIznosUplate.Margin = new Padding(4, 0, 4, 0);
            lblIznosUplate.Name = "lblIznosUplate";
            lblIznosUplate.Size = new Size(96, 21);
            lblIznosUplate.TabIndex = 10;
            lblIznosUplate.Text = "Iznos uplate:";
            // 
            // FormUplata
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(850, 620);
            Controls.Add(lblIznosUplate);
            Controls.Add(lblDatumUplate);
            Controls.Add(lblClanarinaId);
            Controls.Add(lblPoruka);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Controls.Add(txtIznos);
            Controls.Add(dtpDatum);
            Controls.Add(txtClanarinaId);
            Controls.Add(dgvUplata);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormUplata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uplata";
            Load += FormUplata_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUplata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUplata;
        private TextBox txtClanarinaId;
        private DateTimePicker dtpDatum;
        private TextBox txtIznos;
        private Button btnDodaj;
        private Button btnObrisi;
        private Label lblPoruka;
        private Label lblClanarinaId;
        private Label lblDatumUplate;
        private Label lblIznosUplate;
    }
}
