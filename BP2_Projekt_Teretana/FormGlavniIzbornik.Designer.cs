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
            SuspendLayout();
            // 
            // btnUplata
            // 
            btnUplata.Location = new Point(94, 74);
            btnUplata.Name = "btnUplata";
            btnUplata.Size = new Size(75, 23);
            btnUplata.TabIndex = 0;
            btnUplata.Text = "Uplata";
            btnUplata.UseVisualStyleBackColor = true;
            btnUplata.Click += btnUplata_Click;
            // 
            // btnPrijava
            // 
            btnPrijava.Location = new Point(94, 162);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(75, 23);
            btnPrijava.TabIndex = 1;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // FormGlavniIzbornik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 250);
            Controls.Add(btnPrijava);
            Controls.Add(btnUplata);
            Name = "FormGlavniIzbornik";
            Text = "FormGlavniIzbornik";
            Load += FormGlavniIzbornik_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnUplata;
        private Button btnPrijava;
    }
}