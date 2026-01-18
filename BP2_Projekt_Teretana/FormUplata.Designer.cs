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
            lblClanarinaId = new Label();
            lblDatumUplate = new Label();
            lblIznosUplate = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPoruka2 = new Label();
            txtPoruka = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUplata).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUplata
            // 
            dgvUplata.AllowUserToAddRows = false;
            dgvUplata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUplata.BackgroundColor = Color.White;
            dgvUplata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUplata.Dock = DockStyle.Fill;
            dgvUplata.Location = new Point(4, 4);
            dgvUplata.Margin = new Padding(4);
            dgvUplata.MultiSelect = false;
            dgvUplata.Name = "dgvUplata";
            dgvUplata.ReadOnly = true;
            dgvUplata.RowHeadersVisible = false;
            dgvUplata.RowHeadersWidth = 51;
            dgvUplata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUplata.Size = new Size(890, 330);
            dgvUplata.TabIndex = 0;
            dgvUplata.CellContentClick += dgvUplata_CellContentClick;
            // 
            // txtClanarinaId
            // 
            txtClanarinaId.Location = new Point(140, 425);
            txtClanarinaId.Margin = new Padding(4);
            txtClanarinaId.Name = "txtClanarinaId";
            txtClanarinaId.Size = new Size(52, 34);
            txtClanarinaId.TabIndex = 2;
            // 
            // dtpDatum
            // 
            dtpDatum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDatum.Location = new Point(578, 365);
            dtpDatum.Margin = new Padding(4);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(256, 34);
            dtpDatum.TabIndex = 3;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(142, 365);
            txtIznos.Margin = new Padding(4);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(127, 34);
            txtIznos.TabIndex = 1;
            // 
            // btnDodaj
            // 
            btnDodaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDodaj.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDodaj.Location = new Point(161, 550);
            btnDodaj.Margin = new Padding(4);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(130, 40);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "DODAJ";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnObrisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnObrisi.Location = new Point(599, 550);
            btnObrisi.Margin = new Padding(4);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(130, 40);
            btnObrisi.TabIndex = 5;
            btnObrisi.Text = "OBRIŠI";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // lblClanarinaId
            // 
            lblClanarinaId.AutoSize = true;
            lblClanarinaId.Location = new Point(13, 428);
            lblClanarinaId.Margin = new Padding(4, 0, 4, 0);
            lblClanarinaId.Name = "lblClanarinaId";
            lblClanarinaId.Size = new Size(119, 28);
            lblClanarinaId.TabIndex = 7;
            lblClanarinaId.Text = "Clanarina id:";
            // 
            // lblDatumUplate
            // 
            lblDatumUplate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDatumUplate.AutoSize = true;
            lblDatumUplate.Location = new Point(435, 365);
            lblDatumUplate.Margin = new Padding(4, 0, 4, 0);
            lblDatumUplate.Name = "lblDatumUplate";
            lblDatumUplate.Size = new Size(135, 28);
            lblDatumUplate.TabIndex = 9;
            lblDatumUplate.Text = "Datum uplate:";
            // 
            // lblIznosUplate
            // 
            lblIznosUplate.AutoSize = true;
            lblIznosUplate.Location = new Point(13, 365);
            lblIznosUplate.Margin = new Padding(4, 0, 4, 0);
            lblIznosUplate.Name = "lblIznosUplate";
            lblIznosUplate.Size = new Size(121, 28);
            lblIznosUplate.TabIndex = 10;
            lblIznosUplate.Text = "Iznos uplate:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvUplata, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(898, 338);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // lblPoruka2
            // 
            lblPoruka2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPoruka2.AutoSize = true;
            lblPoruka2.Location = new Point(435, 431);
            lblPoruka2.Name = "lblPoruka2";
            lblPoruka2.Size = new Size(76, 28);
            lblPoruka2.TabIndex = 12;
            lblPoruka2.Text = "Poruka:";
            // 
            // txtPoruka
            // 
            txtPoruka.BackColor = Color.White;
            txtPoruka.BorderStyle = BorderStyle.FixedSingle;
            txtPoruka.Location = new Point(578, 425);
            txtPoruka.Multiline = true;
            txtPoruka.Name = "txtPoruka";
            txtPoruka.ReadOnly = true;
            txtPoruka.ScrollBars = ScrollBars.Vertical;
            txtPoruka.Size = new Size(295, 107);
            txtPoruka.TabIndex = 13;
            // 
            // FormUplata
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(898, 620);
            Controls.Add(txtPoruka);
            Controls.Add(lblPoruka2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblIznosUplate);
            Controls.Add(lblDatumUplate);
            Controls.Add(lblClanarinaId);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Controls.Add(txtIznos);
            Controls.Add(dtpDatum);
            Controls.Add(txtClanarinaId);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormUplata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uplata";
            Load += FormUplata_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUplata).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
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
        private Label lblClanarinaId;
        private Label lblDatumUplate;
        private Label lblIznosUplate;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPoruka2;
        private TextBox txtPoruka;
    }
}
