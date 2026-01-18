namespace BP2_Projekt_Teretana
{
    partial class FormGlavniIzbornik
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
            btnUplata = new Button();
            btnPrijava = new Button();
            btnTerminTreninga = new Button();
            SuspendLayout();
            // 
            // btnUplata
            // 
            btnUplata.Anchor = AnchorStyles.None;
            btnUplata.Location = new Point(122, 66);
            btnUplata.Margin = new Padding(4);
            btnUplata.Name = "btnUplata";
            btnUplata.Size = new Size(180, 45);
            btnUplata.TabIndex = 0;
            btnUplata.Text = "Uplata";
            btnUplata.UseVisualStyleBackColor = true;
            btnUplata.Click += btnUplata_Click;
            // 
            // btnPrijava
            // 
            btnPrijava.Anchor = AnchorStyles.None;
            btnPrijava.Location = new Point(122, 149);
            btnPrijava.Margin = new Padding(4);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(180, 45);
            btnPrijava.TabIndex = 1;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // btnTerminTreninga
            // 
            btnTerminTreninga.Anchor = AnchorStyles.None;
            btnTerminTreninga.Location = new Point(122, 235);
            btnTerminTreninga.Margin = new Padding(4);
            btnTerminTreninga.Name = "btnTerminTreninga";
            btnTerminTreninga.Size = new Size(180, 45);
            btnTerminTreninga.TabIndex = 2;
            btnTerminTreninga.Text = "Termin treninga";
            btnTerminTreninga.UseVisualStyleBackColor = true;
            btnTerminTreninga.Click += btnTerminTreninga_Click;
            // 
            // FormGlavniIzbornik
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(423, 345);
            Controls.Add(btnTerminTreninga);
            Controls.Add(btnPrijava);
            Controls.Add(btnUplata);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "FormGlavniIzbornik";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Glavni izbornik";
            Load += FormGlavniIzbornik_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnUplata;
        private Button btnPrijava;
        private Button btnTerminTreninga;
    }
}