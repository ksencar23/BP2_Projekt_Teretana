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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUplata).BeginInit();
            SuspendLayout();
            // 
            // dgvUplata
            // 
            dgvUplata.AllowUserToAddRows = false;
            dgvUplata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUplata.BackgroundColor = Color.White;
            dgvUplata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUplata.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvUplata.Location = new Point(50, 42);
            dgvUplata.MultiSelect = false;
            dgvUplata.Name = "dgvUplata";
            dgvUplata.ReadOnly = true;
            dgvUplata.RowHeadersVisible = false;
            dgvUplata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUplata.Size = new Size(502, 207);
            dgvUplata.TabIndex = 0;
            // 
            // txtClanarinaId
            // 
            txtClanarinaId.Location = new Point(129, 317);
            txtClanarinaId.Name = "txtClanarinaId";
            txtClanarinaId.Size = new Size(41, 23);
            txtClanarinaId.TabIndex = 1;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(352, 277);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(200, 23);
            dtpDatum.TabIndex = 2;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(129, 277);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(100, 23);
            txtIznos.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(50, 394);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(100, 27);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "DODAJ";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(452, 394);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(100, 27);
            btnObrisi.TabIndex = 5;
            btnObrisi.Text = "OBRIŠI";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // lblPoruka
            // 
            lblPoruka.AutoSize = true;
            lblPoruka.Location = new Point(264, 320);
            lblPoruka.Name = "lblPoruka";
            lblPoruka.Size = new Size(34, 15);
            lblPoruka.TabIndex = 6;
            lblPoruka.Text = "Opis:";
            // 
            // lblClanarinaId
            // 
            lblClanarinaId.AutoSize = true;
            lblClanarinaId.Location = new Point(50, 320);
            lblClanarinaId.Name = "lblClanarinaId";
            lblClanarinaId.Size = new Size(73, 15);
            lblClanarinaId.TabIndex = 7;
            lblClanarinaId.Text = "Clanarina id:";
            // 
            // lblDatumUplate
            // 
            lblDatumUplate.AutoSize = true;
            lblDatumUplate.Location = new Point(264, 277);
            lblDatumUplate.Name = "lblDatumUplate";
            lblDatumUplate.Size = new Size(82, 15);
            lblDatumUplate.TabIndex = 9;
            lblDatumUplate.Text = "Datum uplate:";
            // 
            // lblIznosUplate
            // 
            lblIznosUplate.AutoSize = true;
            lblIznosUplate.Location = new Point(50, 277);
            lblIznosUplate.Name = "lblIznosUplate";
            lblIznosUplate.Size = new Size(73, 15);
            lblIznosUplate.TabIndex = 10;
            lblIznosUplate.Text = "Iznos uplate:";
            // 
            // Column1
            // 
            Column1.HeaderText = "ID uplate";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Članarina";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Datum";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Iznos";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // FormUplata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 443);
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
            Name = "FormUplata";
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
