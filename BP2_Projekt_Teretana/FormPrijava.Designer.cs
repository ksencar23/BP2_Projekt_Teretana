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
            txtClanId = new TextBox();
            lblClanId = new Label();
            txtTerminId = new TextBox();
            lblTerminId = new Label();
            btnPrijavi = new Button();
            btnOtkazi = new Button();
            btnObrisi = new Button();
            lblPoruka = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPoruka1 = new Label();
            txtPoruka = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPrijave).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            dgvPrijave.Size = new Size(960, 318);
            dgvPrijave.TabIndex = 0;
            // 
            // txtClanId
            // 
            txtClanId.Location = new Point(117, 338);
            txtClanId.Margin = new Padding(4);
            txtClanId.Name = "txtClanId";
            txtClanId.Size = new Size(127, 34);
            txtClanId.TabIndex = 1;
            // 
            // lblClanId
            // 
            lblClanId.AutoSize = true;
            lblClanId.Location = new Point(13, 341);
            lblClanId.Margin = new Padding(4, 0, 4, 0);
            lblClanId.Name = "lblClanId";
            lblClanId.Size = new Size(76, 28);
            lblClanId.TabIndex = 2;
            lblClanId.Text = "Član id:";
            // 
            // txtTerminId
            // 
            txtTerminId.Location = new Point(117, 387);
            txtTerminId.Margin = new Padding(4);
            txtTerminId.Name = "txtTerminId";
            txtTerminId.Size = new Size(127, 34);
            txtTerminId.TabIndex = 2;
            // 
            // lblTerminId
            // 
            lblTerminId.AutoSize = true;
            lblTerminId.Location = new Point(13, 390);
            lblTerminId.Margin = new Padding(4, 0, 4, 0);
            lblTerminId.Name = "lblTerminId";
            lblTerminId.Size = new Size(96, 28);
            lblTerminId.TabIndex = 4;
            lblTerminId.Text = "Termin id:";
            // 
            // btnPrijavi
            // 
            btnPrijavi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrijavi.Location = new Point(13, 501);
            btnPrijavi.Margin = new Padding(4);
            btnPrijavi.Name = "btnPrijavi";
            btnPrijavi.Size = new Size(130, 40);
            btnPrijavi.TabIndex = 3;
            btnPrijavi.Text = "UNESI";
            btnPrijavi.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOtkazi.Location = new Point(422, 501);
            btnOtkazi.Margin = new Padding(4);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(130, 40);
            btnOtkazi.TabIndex = 4;
            btnOtkazi.Text = "OTKAŽI";
            btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnObrisi.Location = new Point(825, 501);
            btnObrisi.Margin = new Padding(4);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(130, 40);
            btnObrisi.TabIndex = 5;
            btnObrisi.Text = "OBRIŠI";
            btnObrisi.UseVisualStyleBackColor = true;
      
            // 
            // lblPoruka
            // 
            lblPoruka.AutoSize = true;
            lblPoruka.Location = new Point(343, 393);
            lblPoruka.Margin = new Padding(4, 0, 4, 0);
            lblPoruka.Name = "lblPoruka";
            lblPoruka.Size = new Size(72, 28);
            lblPoruka.TabIndex = 8;
            lblPoruka.Text = "Poruka";
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
            tableLayoutPanel1.Size = new Size(968, 326);
            tableLayoutPanel1.TabIndex = 9;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblPoruka1
            // 
            lblPoruka1.AutoSize = true;
            lblPoruka1.Location = new Point(444, 341);
            lblPoruka1.Name = "lblPoruka1";
            lblPoruka1.Size = new Size(76, 28);
            lblPoruka1.TabIndex = 10;
            lblPoruka1.Text = "Poruka:";
            // 
            // txtPoruka
            // 
            txtPoruka.BackColor = Color.White;
            txtPoruka.BorderStyle = BorderStyle.FixedSingle;
            txtPoruka.Location = new Point(526, 348);
            txtPoruka.Multiline = true;
            txtPoruka.Name = "txtPoruka";
            txtPoruka.ReadOnly = true;
            txtPoruka.ScrollBars = ScrollBars.Vertical;
            txtPoruka.Size = new Size(381, 129);
            txtPoruka.TabIndex = 11;
            // 
            // FormPrijava
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(968, 576);
            Controls.Add(txtPoruka);
            Controls.Add(lblPoruka1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblPoruka);
            Controls.Add(btnObrisi);
            Controls.Add(btnOtkazi);
            Controls.Add(btnPrijavi);
            Controls.Add(lblTerminId);
            Controls.Add(txtTerminId);
            Controls.Add(lblClanId);
            Controls.Add(txtClanId);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPrijave;
        private TextBox txtClanId;
        private Label lblClanId;
        private TextBox txtTerminId;
        private Label lblTerminId;
        private Button btnPrijavi;
        private Button btnOtkazi;
        private Button btnObrisi;
        private Label lblPoruka;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPoruka1;
        private TextBox txtPoruka;
    }
}