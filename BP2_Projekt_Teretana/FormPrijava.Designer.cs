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
            ((System.ComponentModel.ISupportInitialize)dgvPrijave).BeginInit();
            SuspendLayout();
            // 
            // dgvPrijave
            // 
            dgvPrijave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrijave.Location = new Point(86, 37);
            dgvPrijave.Name = "dgvPrijave";
            dgvPrijave.Size = new Size(564, 205);
            dgvPrijave.TabIndex = 0;
            // 
            // txtClanId
            // 
            txtClanId.Location = new Point(197, 276);
            txtClanId.Name = "txtClanId";
            txtClanId.Size = new Size(100, 23);
            txtClanId.TabIndex = 1;
            // 
            // lblClanId
            // 
            lblClanId.AutoSize = true;
            lblClanId.Location = new Point(144, 279);
            lblClanId.Name = "lblClanId";
            lblClanId.Size = new Size(47, 15);
            lblClanId.TabIndex = 2;
            lblClanId.Text = "Član id:";
            // 
            // txtTerminId
            // 
            txtTerminId.Location = new Point(197, 337);
            txtTerminId.Name = "txtTerminId";
            txtTerminId.Size = new Size(100, 23);
            txtTerminId.TabIndex = 3;
            // 
            // lblTerminId
            // 
            lblTerminId.AutoSize = true;
            lblTerminId.Location = new Point(131, 340);
            lblTerminId.Name = "lblTerminId";
            lblTerminId.Size = new Size(60, 15);
            lblTerminId.TabIndex = 4;
            lblTerminId.Text = "Termin id:";
            // 
            // btnPrijavi
            // 
            btnPrijavi.Location = new Point(144, 388);
            btnPrijavi.Name = "btnPrijavi";
            btnPrijavi.Size = new Size(75, 23);
            btnPrijavi.TabIndex = 5;
            btnPrijavi.Text = "Unesi";
            btnPrijavi.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(318, 388);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(75, 23);
            btnOtkazi.TabIndex = 6;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(494, 388);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(75, 23);
            btnObrisi.TabIndex = 7;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            // 
            // lblPoruka
            // 
            lblPoruka.AutoSize = true;
            lblPoruka.Location = new Point(503, 279);
            lblPoruka.Name = "lblPoruka";
            lblPoruka.Size = new Size(44, 15);
            lblPoruka.TabIndex = 8;
            lblPoruka.Text = "Poruka";
            // 
            // FormPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 450);
            Controls.Add(lblPoruka);
            Controls.Add(btnObrisi);
            Controls.Add(btnOtkazi);
            Controls.Add(btnPrijavi);
            Controls.Add(lblTerminId);
            Controls.Add(txtTerminId);
            Controls.Add(lblClanId);
            Controls.Add(txtClanId);
            Controls.Add(dgvPrijave);
            Name = "FormPrijava";
            Text = "Prijava";
            Load += FormPrijava_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrijave).EndInit();
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
    }
}