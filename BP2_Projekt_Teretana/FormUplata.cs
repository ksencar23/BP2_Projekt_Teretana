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
        }

        private void FormUplata_Load(object? sender, EventArgs e)
        {
            Osvjezi();
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

                dgvUplata.Columns["uplata_id"].HeaderText = "ID uplate";
                dgvUplata.Columns["clanarina_id"].HeaderText = "Članarina ID";
                dgvUplata.Columns["datum_uplate"].HeaderText = "Datum uplate";
                dgvUplata.Columns["iznos"].HeaderText = "Iznos (€)";

                lblPoruka.Text = "";
            }
            catch (Exception ex)
            {
                lblPoruka.Text = "Greška kod učitavanja: " + ex.Message;
            }
        }

        private void btnDodaj_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtClanarinaId.Text.Trim(), out int clanarinaId))
                {
                    lblPoruka.Text = "Unesi ispravan clanarina_id (broj).";
                    return;
                }

                if (!decimal.TryParse(txtIznos.Text.Trim(), out decimal iznos))
                {
                    lblPoruka.Text = "Unesi ispravan iznos (npr. 20.00).";
                    return;
                }

                DateTime datum = dtpDatum.Value.Date;

                Db.Exec(
                    "insert into uplata (clanarina_id, datum_uplate, iznos) values (@c, @d, @i)",
                    new NpgsqlParameter("@c", clanarinaId),
                    new NpgsqlParameter("@d", datum),
                    new NpgsqlParameter("@i", iznos)
                );

                lblPoruka.Text = "Uplata je uspješno spremljena.";
                Osvjezi();
            }
            catch (Exception ex)
            {
                // Ovdje će doći i poruke iz triggera i FK greške
                lblPoruka.Text = ex.Message;
            }
        }

        private void btnObrisi_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvUplata.CurrentRow == null)
                {
                    lblPoruka.Text = "Odaberi red koji želiš obrisati.";
                    return;
                }

                object? v = dgvUplata.CurrentRow.Cells["uplata_id"]?.Value;

                if (v == null)
                {
                    lblPoruka.Text = "Ne mogu pročitati uplata_id iz odabranog reda.";
                    return;
                }

                int uplataId = Convert.ToInt32(v);

                Db.Exec(
                    "delete from uplata where uplata_id = @id",
                    new NpgsqlParameter("@id", uplataId)
                );

                lblPoruka.Text = "Uplata je obrisana.";
                Osvjezi();
            }
            catch (Exception ex)
            {
                lblPoruka.Text = ex.Message;
            }
        }
    }
}
