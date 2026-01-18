using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BP2_Projekt_Teretana
{
    public partial class FormGlavniIzbornik : Form
    {
        public FormGlavniIzbornik()
        {
            InitializeComponent();
        }

        private void FormGlavniIzbornik_Load(object sender, EventArgs e)
        {

        }
        private void btnUplata_Click(object sender, EventArgs e)
        {
            new FormUplata().ShowDialog();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            new FormPrijava().ShowDialog();
        }

        private void btnTerminTreninga_Click(object sender, EventArgs e)
        {
            new FormTerminTreninga().ShowDialog();       
        }
    }
}
