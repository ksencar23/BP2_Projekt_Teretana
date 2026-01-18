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

        private void SetPoruka(string poruka)
        {
            // helper da sve poruke idu na isto mjesto
            txtPoruka.Text = poruka ?? "";

            // skrol na kraj (korisno ako je poruka dugačka)
            txtPoruka.SelectionStart = txtPoruka.Text.Length;
            txtPoruka.ScrollToCaret();
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

                if (dgvPrijave.Columns != null)
                {
                    if (dgvPrijave.Columns.Contains("prijava_id"))
                        dgvPrijave.Columns["prijava_id"].HeaderText = "ID prijave";

                    if (dgvPrijave.Columns.Contains("clan_id"))
                        dgvPrijave.Columns["clan_id"].HeaderText = "ID člana";

                    if (dgvPrijave.Columns.Contains("termin_treninga_id"))
                        dgvPrijave.Columns["termin_treninga_id"].HeaderText = "Termin treninga";

                    if (dgvPrijave.Columns.Contains("datum_prijave"))
                        dgvPrijave.Columns["datum_prijave"].HeaderText = "Datum prijave";

                    if (dgvPrijave.Columns.Contains("status"))
                        dgvPrijave.Columns["status"].HeaderText = "Status";
                }

                SetPoruka("");
            }
            catch (Exception ex)
            {
                SetPoruka("Greška kod učitavanja: " + ex.Message);
            }
        }

        private void btnPrijavi_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtClanId.Text.Trim(), out int clanId))
                {
                    SetPoruka("Unesi ispravan clan_id (broj).");
                    return;
                }

                if (!int.TryParse(txtTerminId.Text.Trim(), out int terminId))
                {
                    SetPoruka("Unesi ispravan termin_treninga_id (broj).");
                    return;
                }

                Db.Exec(
                    "insert into prijava (clan_id, termin_treninga_id, datum_prijave, status) " +
                    "values (@c, @t, now(), 'aktivna')",
                    new NpgsqlParameter("@c", clanId),
                    new NpgsqlParameter("@t", terminId)
                );

                SetPoruka("Prijava je uspješno spremljena.");
                Osvjezi();
            }
            catch (Exception ex)
            {
                // Ovdje ćeš dobiti poruku iz triggera (npr. nema članarinu / termin pun / prošao termin)
                SetPoruka(ex.Message);
            }
        }

        private void btnOtkazi_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvPrijave.CurrentRow == null)
                {
                    SetPoruka("Odaberi prijavu koju želiš otkazati.");
                    return;
                }

                object? v = dgvPrijave.CurrentRow.Cells["prijava_id"]?.Value;
                if (v == null)
                {
                    SetPoruka("Ne mogu pročitati prijava_id iz odabranog reda.");
                    return;
                }

                int prijavaId = Convert.ToInt32(v);

                Db.Exec(
                    "update prijava set status = 'otkazana' where prijava_id = @id",
                    new NpgsqlParameter("@id", prijavaId)
                );

                SetPoruka("Prijava je otkazana (status = otkazana).");
                Osvjezi();
            }
            catch (Exception ex)
            {
                SetPoruka(ex.Message);
            }
        }

        private void btnObrisi_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvPrijave.CurrentRow == null)
                {
                    SetPoruka("Odaberi prijavu koju želiš obrisati.");
                    return;
                }

                object? v = dgvPrijave.CurrentRow.Cells["prijava_id"]?.Value;
                if (v == null)
                {
                    SetPoruka("Ne mogu pročitati prijava_id iz odabranog reda.");
                    return;
                }

                int prijavaId = Convert.ToInt32(v);

                Db.Exec(
                    "delete from prijava where prijava_id = @id",
                    new NpgsqlParameter("@id", prijavaId)
                );

                SetPoruka("Prijava je obrisana.");
                Osvjezi();
            }
            catch (Exception ex)
            {
                SetPoruka(ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
