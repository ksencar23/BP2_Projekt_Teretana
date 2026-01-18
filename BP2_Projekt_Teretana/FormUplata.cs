using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace BP2_Projekt_Teretana
{
    public partial class FormUplata : Form
    {
        public FormUplata()
        {
            InitializeComponent();

            // Malo bolje ponašanje grida
            dgvUplata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUplata.MultiSelect = false;
            dgvUplata.ReadOnly = true; // mi radimo INSERT/DELETE preko gumbi
            dgvUplata.AllowUserToAddRows = false;

            // Ako ti nije spojeno u Designeru, ovo osigurava da se Load pozove
            Load += FormUplata_Load;
        }

        private void FormUplata_Load(object? sender, EventArgs e)
        {
            Osvjezi();
        }

        private void SetPoruka(string poruka)
        {
            txtPoruka.Text = poruka ?? "";
            txtPoruka.SelectionStart = txtPoruka.Text.Length;
            txtPoruka.ScrollToCaret();
        }

        private void Osvjezi()
        {
            try
            {
                DataTable dt = Db.Query(
                    "select uplata_id, clanarina_id, datum_uplate, iznos " +
                    "from uplata " +
                    "order by uplata_id desc " +
                    "limit 50"
                );

                dgvUplata.DataSource = dt;

                // ✅ Sigurno postavljanje HeaderText (bez CS8602)
                if (dgvUplata.Columns != null)
                {
                    if (dgvUplata.Columns.Contains("uplata_id"))
                        dgvUplata.Columns["uplata_id"].HeaderText = "ID uplate";

                    if (dgvUplata.Columns.Contains("clanarina_id"))
                        dgvUplata.Columns["clanarina_id"].HeaderText = "Članarina ID";

                    if (dgvUplata.Columns.Contains("datum_uplate"))
                        dgvUplata.Columns["datum_uplate"].HeaderText = "Datum uplate";

                    if (dgvUplata.Columns.Contains("iznos"))
                        dgvUplata.Columns["iznos"].HeaderText = "Iznos (€)";
                }

                SetPoruka("");
            }
            catch (Exception ex)
            {
                SetPoruka("Greška kod učitavanja: " + ex.Message);
            }
        }

        private void btnDodaj_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtClanarinaId.Text.Trim(), out int clanarinaId))
                {
                    SetPoruka("Unesi ispravan clanarina_id (broj).");
                    return;
                }

                if (!decimal.TryParse(txtIznos.Text.Trim(), out decimal iznos))
                {
                    SetPoruka("Unesi ispravan iznos (npr. 20.00).");
                    return;
                }

                DateTime datum = dtpDatum.Value.Date;

                Db.Exec(
                    "insert into uplata (clanarina_id, datum_uplate, iznos) values (@c, @d, @i)",
                    new NpgsqlParameter("@c", clanarinaId),
                    new NpgsqlParameter("@d", datum),
                    new NpgsqlParameter("@i", iznos)
                );

                SetPoruka("Uplata je uspješno spremljena.");
                Osvjezi();
            }
            catch (Exception ex)
            {
                // Ovdje će doći i poruke iz triggera i FK greške
                SetPoruka(ex.Message);
            }
        }

        private void btnObrisi_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvUplata.CurrentRow == null)
                {
                    SetPoruka("Odaberi red koji želiš obrisati.");
                    return;
                }

                object? v = dgvUplata.CurrentRow.Cells["uplata_id"]?.Value;

                if (v == null)
                {
                    SetPoruka("Ne mogu pročitati uplata_id iz odabranog reda.");
                    return;
                }

                int uplataId = Convert.ToInt32(v);

                Db.Exec(
                    "delete from uplata where uplata_id = @id",
                    new NpgsqlParameter("@id", uplataId)
                );

                SetPoruka("Uplata je obrisana.");
                Osvjezi();
            }
            catch (Exception ex)
            {
                SetPoruka(ex.Message);
            }
        }

        private void dgvUplata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
