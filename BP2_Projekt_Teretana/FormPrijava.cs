using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace BP2_Projekt_Teretana
{
    public partial class FormPrijava : Form
    {
        public FormPrijava()
        {
            InitializeComponent();

            Load += FormPrijava_Load;
            btnPrijavi.Click += btnPrijavi_Click;
            btnOtkazi.Click += btnOtkazi_Click;
            btnObrisi.Click += btnObrisi_Click;

            dgvPrijave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrijave.MultiSelect = false;
            dgvPrijave.ReadOnly = true;
            dgvPrijave.AllowUserToAddRows = false;
        }

        private void FormPrijava_Load(object? sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            try
            {
                DataTable dt = Db.Query(
                    "select prijava_id, clan_id, termin_treninga_id, datum_prijave, status " +
                    "from prijava " +
                    "order by prijava_id desc " +
                    "limit 50"
                );

                dgvPrijave.DataSource = dt;

                dgvPrijave.Columns["prijava_id"].HeaderText = "ID prijave";
                dgvPrijave.Columns["clan_id"].HeaderText = "ID člana";
                dgvPrijave.Columns["termin_treninga_id"].HeaderText = "Termin treninga";
                dgvPrijave.Columns["datum_prijave"].HeaderText = "Datum prijave";
                dgvPrijave.Columns["status"].HeaderText = "Status";
                lblPoruka.Text = "";
            }
            catch (Exception ex)
            {
                lblPoruka.Text = "Greška kod učitavanja: " + ex.Message;
            }
        }

        private void btnPrijavi_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtClanId.Text.Trim(), out int clanId))
                {
                    lblPoruka.Text = "Unesi ispravan clan_id (broj).";
                    return;
                }

                if (!int.TryParse(txtTerminId.Text.Trim(), out int terminId))
                {
                    lblPoruka.Text = "Unesi ispravan termin_treninga_id (broj).";
                    return;
                }

                Db.Exec(
                    "insert into prijava (clan_id, termin_treninga_id, datum_prijave, status) " +
                    "values (@c, @t, now(), 'aktivna')",
                    new NpgsqlParameter("@c", clanId),
                    new NpgsqlParameter("@t", terminId)
                );

                lblPoruka.Text = "Prijava je uspješno spremljena.";
                Osvjezi();
            }
            catch (Exception ex)
            {
                // Ovdje ćeš dobiti poruku iz triggera (npr. nema članarinu / termin pun / prošao termin)
                lblPoruka.Text = ex.Message;
            }
        }

        private void btnOtkazi_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvPrijave.CurrentRow == null)
                {
                    lblPoruka.Text = "Odaberi prijavu koju želiš otkazati.";
                    return;
                }

                object? v = dgvPrijave.CurrentRow.Cells["prijava_id"]?.Value;
                if (v == null)
                {
                    lblPoruka.Text = "Ne mogu pročitati prijava_id iz odabranog reda.";
                    return;
                }

                int prijavaId = Convert.ToInt32(v);

                Db.Exec(
                    "update prijava set status = 'otkazana' where prijava_id = @id",
                    new NpgsqlParameter("@id", prijavaId)
                );

                lblPoruka.Text = "Prijava je otkazana (status = otkazana).";
                Osvjezi();
            }
            catch (Exception ex)
            {
                lblPoruka.Text = ex.Message;
            }
        }

        private void btnObrisi_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvPrijave.CurrentRow == null)
                {
                    lblPoruka.Text = "Odaberi prijavu koju želiš obrisati.";
                    return;
                }

                object? v = dgvPrijave.CurrentRow.Cells["prijava_id"]?.Value;
                if (v == null)
                {
                    lblPoruka.Text = "Ne mogu pročitati prijava_id iz odabranog reda.";
                    return;
                }

                int prijavaId = Convert.ToInt32(v);

                Db.Exec(
                    "delete from prijava where prijava_id = @id",
                    new NpgsqlParameter("@id", prijavaId)
                );

                lblPoruka.Text = "Prijava je obrisana.";
                Osvjezi();
            }
            catch (Exception ex)
            {
                lblPoruka.Text = ex.Message;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
