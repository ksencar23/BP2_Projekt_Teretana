namespace BP2_Projekt_Teretana
{
    partial class FormPrijava
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
            dgvPrijave = new DataGridView();
            lblClanId = new Label();
            lblTerminId = new Label();
            btnPrijavi = new Button();
            btnOtkazi = new Button();
            btnObrisi = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPoruka1 = new Label();
            txtPoruka = new TextBox();
            cbClan = new ComboBox();
            cbTermin = new ComboBox();
            dgvClanarina = new DataGridView();
            lblClanarinaZaClana = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrijave).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClanarina).BeginInit();
            SuspendLayout();
            // 
            // dgvPrijave
            // 
            dgvPrijave.AllowUserToAddRows = false;
            dgvPrijave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrijave.BackgroundColor = Color.White;
            dgvPrijave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrijave.Dock = DockStyle.Fill;
            dgvPrijave.Location = new Point(4, 4);
            dgvPrijave.Margin = new Padding(4);
            dgvPrijave.MultiSelect = false;
            dgvPrijave.Name = "dgvPrijave";
            dgvPrijave.ReadOnly = true;
            dgvPrijave.RowHeadersVisible = false;
            dgvPrijave.RowHeadersWidth = 51;
            dgvPrijave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrijave.Size = new Size(1355, 318);
            dgvPrijave.TabIndex = 0;
            dgvPrijave.TabStop = false;
            // 
            // lblClanId
            // 
            lblClanId.AutoSize = true;
            lblClanId.Location = new Point(4, 476);
            lblClanId.Margin = new Padding(4, 0, 4, 0);
            lblClanId.Name = "lblClanId";
            lblClanId.Size = new Size(54, 28);
            lblClanId.TabIndex = 2;
            lblClanId.Text = "Član:";
            // 
            // lblTerminId
            // 
            lblTerminId.AutoSize = true;
            lblTerminId.Location = new Point(4, 573);
            lblTerminId.Margin = new Padding(4, 0, 4, 0);
            lblTerminId.Name = "lblTerminId";
            lblTerminId.Size = new Size(80, 28);
            lblTerminId.TabIndex = 4;
            lblTerminId.Text = "Trening:";
            // 
            // btnPrijavi
            // 
            btnPrijavi.BackColor = Color.Aqua;
            btnPrijavi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrijavi.Location = new Point(13, 672);
            btnPrijavi.Margin = new Padding(4);
            btnPrijavi.Name = "btnPrijavi";
            btnPrijavi.Size = new Size(200, 70);
            btnPrijavi.TabIndex = 3;
            btnPrijavi.Text = "UNESI PRIJAVU \r\nNA TRENING";
            btnPrijavi.UseVisualStyleBackColor = false;
            // 
            // btnOtkazi
            // 
            btnOtkazi.BackColor = Color.Turquoise;
            btnOtkazi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOtkazi.Location = new Point(581, 672);
            btnOtkazi.Margin = new Padding(4);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(200, 70);
            btnOtkazi.TabIndex = 4;
            btnOtkazi.Text = "OTKAŽI PRIJAVU\r\nNA TRENING";
            btnOtkazi.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.Red;
            btnObrisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnObrisi.Location = new Point(1150, 672);
            btnObrisi.Margin = new Padding(4);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(200, 70);
            btnObrisi.TabIndex = 5;
            btnObrisi.Text = "OBRIŠI PRIJAVU\r\nNA TRRENING";
            btnObrisi.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.02484F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.9751549F));
            tableLayoutPanel1.Controls.Add(dgvPrijave, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1363, 326);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // lblPoruka1
            // 
            lblPoruka1.AutoSize = true;
            lblPoruka1.Location = new Point(812, 496);
            lblPoruka1.Name = "lblPoruka1";
            lblPoruka1.Size = new Size(76, 28);
            lblPoruka1.TabIndex = 10;
            lblPoruka1.Text = "Poruka:";
            // 
            // txtPoruka
            // 
            txtPoruka.BackColor = Color.White;
            txtPoruka.BorderStyle = BorderStyle.None;
            txtPoruka.Location = new Point(894, 496);
            txtPoruka.Multiline = true;
            txtPoruka.Name = "txtPoruka";
            txtPoruka.ReadOnly = true;
            txtPoruka.Size = new Size(381, 129);
            txtPoruka.TabIndex = 0;
            txtPoruka.TabStop = false;
            // 
            // cbClan
            // 
            cbClan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClan.FormattingEnabled = true;
            cbClan.Location = new Point(4, 507);
            cbClan.Name = "cbClan";
            cbClan.Size = new Size(204, 36);
            cbClan.TabIndex = 1;
            // 
            // cbTermin
            // 
            cbTermin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTermin.FormattingEnabled = true;
            cbTermin.Location = new Point(4, 604);
            cbTermin.Name = "cbTermin";
            cbTermin.Size = new Size(736, 36);
            cbTermin.TabIndex = 2;
            // 
            // dgvClanarina
            // 
            dgvClanarina.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClanarina.BackgroundColor = Color.White;
            dgvClanarina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClanarina.Location = new Point(4, 379);
            dgvClanarina.Name = "dgvClanarina";
            dgvClanarina.RowHeadersWidth = 51;
            dgvClanarina.Size = new Size(1355, 72);
            dgvClanarina.TabIndex = 0;
            dgvClanarina.TabStop = false;
            // 
            // lblClanarinaZaClana
            // 
            lblClanarinaZaClana.AutoSize = true;
            lblClanarinaZaClana.Location = new Point(0, 348);
            lblClanarinaZaClana.Name = "lblClanarinaZaClana";
            lblClanarinaZaClana.Size = new Size(274, 28);
            lblClanarinaZaClana.TabIndex = 0;
            lblClanarinaZaClana.Text = "Članarina za odabranog člana:";
            // 
            // FormPrijava
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1363, 755);
            Controls.Add(lblClanarinaZaClana);
            Controls.Add(dgvClanarina);
            Controls.Add(cbTermin);
            Controls.Add(cbClan);
            Controls.Add(txtPoruka);
            Controls.Add(lblPoruka1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnObrisi);
            Controls.Add(btnOtkazi);
            Controls.Add(btnPrijavi);
            Controls.Add(lblTerminId);
            Controls.Add(lblClanId);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormPrijava";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijava";
            Load += FormPrijava_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrijave).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClanarina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPrijave;
        private Label lblClanId;
        private Label lblTerminId;
        private Button btnPrijavi;
        private Button btnOtkazi;
        private Button btnObrisi;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPoruka1;
        private TextBox txtPoruka;
        private ComboBox cbClan;
        private ComboBox cbTermin;
        private DataGridView dgvClanarina;
        private Label lblClanarinaZaClana;
    }
}