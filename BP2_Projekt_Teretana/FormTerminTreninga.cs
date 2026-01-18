using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace BP2_Projekt_Teretana
{
    public partial class FormTerminTreninga : Form
    {
        private bool _ucitavanje = false;

        public FormTerminTreninga()
        {
            InitializeComponent();

            dgvTermini.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTermini.MultiSelect = false;
            dgvTermini.ReadOnly = true;
            dgvTermini.AllowUserToAddRows = false;

            cbTrening.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrener.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDvorana.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpPocetak.Format = DateTimePickerFormat.Custom;
            dtpPocetak.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpPocetak.ShowUpDown = true;

            nudTrajanjeMin.Minimum = 1;
            nudTrajanjeMin.Maximum = 600;

            nudKapacitet.Minimum = 1;
            nudKapacitet.Maximum = 200;

            Load += FormTerminTreninga_Load;
            btnDodaj.Click += btnDodaj_Click;
            btnAzuriraj.Click += btnAzuriraj_Click;
            btnObrisi.Click += btnObrisi_Click;

            dgvTermini.SelectionChanged += dgvTermini_SelectionChanged;
        }

        private void FormTerminTreninga_Load(object? sender, EventArgs e)
        {
            _ucitavanje = true;

            UcitajListe();
            ReloadAll(null, keepSelection: false);

            _ucitavanje = false;
        }

        private void SetPoruka(string poruka)
        {
            txtPoruka.Text = poruka ?? "";
            txtPoruka.SelectionStart = txtPoruka.Text.Length;
            txtPoruka.ScrollToCaret();
        }

        // ---------------------------
        // Generic ComboBox load
        // ---------------------------
        private void UcitajListe()
        {
            try
            {
                Ui.FillCombo(cbTrening, "select trening_id, naziv from trening order by naziv", "naziv", "trening_id");
                Ui.FillCombo(cbTrener, "select trener_id, (ime || ' ' || prezime) as naziv from trener order by naziv", "naziv", "trener_id");
                Ui.FillCombo(cbDvorana, "select dvorana_id, naziv from dvorana order by naziv", "naziv", "dvorana_id");

                SetPoruka("");
            }
            catch (Exception ex)
            {
                SetPoruka("Greška kod učitavanja lista: " + ex.Message);
            }
        }

        // ---------------------------
        // Reload pattern (jedno mjesto)
        // ---------------------------
        private void ReloadAll(string? poruka, bool keepSelection = true)
        {
            int? selectedId = keepSelection ? DohvatiOdabraniTerminId() : null;

            OsvjeziTermine();

            if (selectedId != null)
                SelectRowById(dgvTermini, "termin_treninga_id", selectedId.Value);

            if (!string.IsNullOrWhiteSpace(poruka))
                SetPoruka(poruka!);
        }

        private void RunAction(string okMsg, Action dbAction)
        {
            Db.Run(() =>
            {
                dbAction();
                ReloadAll(okMsg, keepSelection: true);
            }, SetPoruka);
        }

        // ---------------------------
        // Grid load
        // ---------------------------
        private void OsvjeziTermine()
        {
            DataTable dt = Db.Query(
                "select " +
                "  tt.termin_treninga_id, " +
                "  tt.trening_id, tr.naziv as trening, " +
                "  tt.trener_id, (te.ime || ' ' || te.prezime) as trener, " +
                "  tt.dvorana_id, d.naziv as dvorana, " +
                "  tt.pocetak, tt.trajanje_min, tt.kapacitet, " +
                "  count(p.prijava_id) as broj_prijava, " +
                "  (tt.kapacitet - count(p.prijava_id)) as slobodno_mjesta " +
                "from termin_treninga tt " +
                "join trening tr on tr.trening_id = tt.trening_id " +
                "join trener te on te.trener_id = tt.trener_id " +
                "join dvorana d on d.dvorana_id = tt.dvorana_id " +
                "left join prijava p on p.termin_treninga_id = tt.termin_treninga_id and p.status = 'aktivna' " +
                "group by tt.termin_treninga_id, tt.trening_id, tr.naziv, tt.trener_id, te.ime, te.prezime, tt.dvorana_id, d.naziv, tt.pocetak, tt.trajanje_min, tt.kapacitet " +
                "order by tt.pocetak desc " +
                "limit 200"
            );

            dgvTermini.DataSource = dt;

            if (dgvTermini.Columns == null) return;

            if (dgvTermini.Columns.Contains("termin_treninga_id"))
                dgvTermini.Columns["termin_treninga_id"].HeaderText = "ID termina";

            if (dgvTermini.Columns.Contains("trening"))
                dgvTermini.Columns["trening"].HeaderText = "Trening";

            if (dgvTermini.Columns.Contains("trener"))
                dgvTermini.Columns["trener"].HeaderText = "Trener";

            if (dgvTermini.Columns.Contains("dvorana"))
                dgvTermini.Columns["dvorana"].HeaderText = "Dvorana";

            if (dgvTermini.Columns.Contains("pocetak"))
            {
                dgvTermini.Columns["pocetak"].HeaderText = "Početak";
                dgvTermini.Columns["pocetak"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }

            if (dgvTermini.Columns.Contains("trajanje_min"))
                dgvTermini.Columns["trajanje_min"].HeaderText = "Trajanje (min)";

            if (dgvTermini.Columns.Contains("kapacitet"))
                dgvTermini.Columns["kapacitet"].HeaderText = "Kapacitet";

            if (dgvTermini.Columns.Contains("broj_prijava"))
                dgvTermini.Columns["broj_prijava"].HeaderText = "Aktivnih prijava";

            if (dgvTermini.Columns.Contains("slobodno_mjesta"))
                dgvTermini.Columns["slobodno_mjesta"].HeaderText = "Slobodno";

            if (dgvTermini.Columns.Contains("trening_id"))
                dgvTermini.Columns["trening_id"].Visible = false;

            if (dgvTermini.Columns.Contains("trener_id"))
                dgvTermini.Columns["trener_id"].Visible = false;

            if (dgvTermini.Columns.Contains("dvorana_id"))
                dgvTermini.Columns["dvorana_id"].Visible = false;
        }

        private int? DohvatiOdabraniTerminId()
        {
            if (dgvTermini.CurrentRow == null) return null;
            object? v = dgvTermini.CurrentRow.Cells["termin_treninga_id"]?.Value;
            if (v == null) return null;
            return Convert.ToInt32(v);
        }

        private static void SelectRowById(DataGridView dgv, string idColumn, int id)
        {
            if (dgv.Rows == null || dgv.Rows.Count == 0) return;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var cellVal = row.Cells[idColumn]?.Value;
                if (cellVal == null) continue;

                if (Convert.ToInt32(cellVal) == id)
                {
                    row.Selected = true;
                    dgv.CurrentCell = row.Cells[0];
                    return;
                }
            }
        }

        // ---------------------------
        // Read inputs
        // ---------------------------
        private bool ProcitajUnos(out int treningId, out int trenerId, out int dvoranaId,
                                 out DateTime pocetak, out int trajanjeMin, out int kapacitet)
        {
            treningId = trenerId = dvoranaId = trajanjeMin = kapacitet = 0;
            pocetak = dtpPocetak.Value;

            if (cbTrening.SelectedValue == null || cbTrener.SelectedValue == null || cbDvorana.SelectedValue == null)
            {
                SetPoruka("Odaberi trening, trenera i dvoranu.");
                return false;
            }

            treningId = Convert.ToInt32(cbTrening.SelectedValue);
            trenerId = Convert.ToInt32(cbTrener.SelectedValue);
            dvoranaId = Convert.ToInt32(cbDvorana.SelectedValue);

            pocetak = dtpPocetak.Value;
            trajanjeMin = Convert.ToInt32(nudTrajanjeMin.Value);
            kapacitet = Convert.ToInt32(nudKapacitet.Value);

            return true;
        }

        // ---------------------------
        // Actions
        // ---------------------------
        private void btnDodaj_Click(object? sender, EventArgs e)
        {
            if (!ProcitajUnos(out int treningId, out int trenerId, out int dvoranaId,
                             out DateTime pocetak, out int trajanjeMin, out int kapacitet))
                return;

            RunAction("Termin je uspješno dodan.", () =>
                Db.Exec(
                    "insert into termin_treninga (trening_id, trener_id, dvorana_id, pocetak, trajanje_min, kapacitet) " +
                    "values (@tg, @tr, @dv, @p, @tm, @k)",
                    new NpgsqlParameter("@tg", treningId),
                    new NpgsqlParameter("@tr", trenerId),
                    new NpgsqlParameter("@dv", dvoranaId),
                    new NpgsqlParameter("@p", pocetak),
                    new NpgsqlParameter("@tm", trajanjeMin),
                    new NpgsqlParameter("@k", kapacitet)
                )
            );
        }

        private void btnAzuriraj_Click(object? sender, EventArgs e)
        {
            int? terminId = DohvatiOdabraniTerminId();
            if (terminId == null)
            {
                SetPoruka("Odaberi termin koji želiš ažurirati.");
                return;
            }

            if (!ProcitajUnos(out int treningId, out int trenerId, out int dvoranaId,
                             out DateTime pocetak, out int trajanjeMin, out int kapacitet))
                return;

            RunAction("Termin je ažuriran.", () =>
                Db.Exec(
                    "update termin_treninga " +
                    "set trening_id=@tg, trener_id=@tr, dvorana_id=@dv, pocetak=@p, trajanje_min=@tm, kapacitet=@k " +
                    "where termin_treninga_id=@id",
                    new NpgsqlParameter("@tg", treningId),
                    new NpgsqlParameter("@tr", trenerId),
                    new NpgsqlParameter("@dv", dvoranaId),
                    new NpgsqlParameter("@p", pocetak),
                    new NpgsqlParameter("@tm", trajanjeMin),
                    new NpgsqlParameter("@k", kapacitet),
                    new NpgsqlParameter("@id", terminId.Value)
                )
            );
        }

        private void btnObrisi_Click(object? sender, EventArgs e)
        {
            int? terminId = DohvatiOdabraniTerminId();
            if (terminId == null)
            {
                SetPoruka("Odaberi termin koji želiš obrisati.");
                return;
            }

            var r = MessageBox.Show(
                "Brisanjem termina obrisat će se i prijave na taj termin (ako postoje). Nastaviti?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (r != DialogResult.Yes) return;

            RunAction("Termin je obrisan.", () =>
                Db.Exec("delete from termin_treninga where termin_treninga_id=@id",
                    new NpgsqlParameter("@id", terminId.Value))
            );
        }

        // ---------------------------
        // Selection -> controls
        // ---------------------------
        private void dgvTermini_SelectionChanged(object? sender, EventArgs e)
        {
            if (_ucitavanje) return;
            if (dgvTermini.CurrentRow == null) return;

            try
            {
                object? vt = dgvTermini.CurrentRow.Cells["trening_id"]?.Value;
                object? vtr = dgvTermini.CurrentRow.Cells["trener_id"]?.Value;
                object? vd = dgvTermini.CurrentRow.Cells["dvorana_id"]?.Value;

                _ucitavanje = true;

                if (vt != null) cbTrening.SelectedValue = Convert.ToInt32(vt);
                if (vtr != null) cbTrener.SelectedValue = Convert.ToInt32(vtr);
                if (vd != null) cbDvorana.SelectedValue = Convert.ToInt32(vd);

                object? vp = dgvTermini.CurrentRow.Cells["pocetak"]?.Value;
                if (vp != null) dtpPocetak.Value = Convert.ToDateTime(vp);

                object? vtm = dgvTermini.CurrentRow.Cells["trajanje_min"]?.Value;
                if (vtm != null)
                {
                    int x = Convert.ToInt32(vtm);
                    nudTrajanjeMin.Value = Math.Min(nudTrajanjeMin.Maximum, Math.Max(nudTrajanjeMin.Minimum, x));
                }

                object? vk = dgvTermini.CurrentRow.Cells["kapacitet"]?.Value;
                if (vk != null)
                {
                    int x = Convert.ToInt32(vk);
                    nudKapacitet.Value = Math.Min(nudKapacitet.Maximum, Math.Max(nudKapacitet.Minimum, x));
                }
            }
            catch
            {
                // ignore
            }
            finally
            {
                _ucitavanje = false;
            }
        }
    }
}
