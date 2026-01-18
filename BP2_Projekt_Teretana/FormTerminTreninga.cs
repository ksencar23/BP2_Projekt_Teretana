using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace BP2_Projekt_Teretana
{
    public partial class FormTerminTreninga : Form
    {
        public FormTerminTreninga()
        {
            InitializeComponent();

            // Grid (isto kao tvoje forme)
            dgvTermini.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTermini.MultiSelect = false;
            dgvTermini.ReadOnly = true;
            dgvTermini.AllowUserToAddRows = false;

            // ComboBox - da se ne upisuje tekst ručno
            cbTrening.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrener.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDvorana.DropDownStyle = ComboBoxStyle.DropDownList;

            // DateTimePicker za datum + vrijeme
            dtpPocetak.Format = DateTimePickerFormat.Custom;
            dtpPocetak.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpPocetak.ShowUpDown = true;

            // NumericUpDown defaulti (možeš promijeniti u Designeru)
            nudTrajanjeMin.Minimum = 1;
            nudTrajanjeMin.Maximum = 600;

            nudKapacitet.Minimum = 1;
            nudKapacitet.Maximum = 200;

            // Hook događaja (radi i ako nisi spojio u Designeru)
            Load += FormTerminTreninga_Load;
            btnDodaj.Click += btnDodaj_Click;
            btnAzuriraj.Click += btnAzuriraj_Click;
            btnObrisi.Click += btnObrisi_Click;
            btnOcisti.Click += btnOcisti_Click;

            dgvTermini.SelectionChanged += dgvTermini_SelectionChanged;
        }

        private void FormTerminTreninga_Load(object? sender, EventArgs e)
        {
            UcitajListe();
            Osvjezi();
        }

        private void SetPoruka(string poruka)
        {
            txtPoruka.Text = poruka ?? "";
            txtPoruka.SelectionStart = txtPoruka.Text.Length;
            txtPoruka.ScrollToCaret();
        }

        private void UcitajListe()
        {
            try
            {
                // trening
                var dtTrening = Db.Query("select trening_id, naziv from trening order by naziv");
                cbTrening.DisplayMember = "naziv";
                cbTrening.ValueMember = "trening_id";
                cbTrening.DataSource = dtTrening;

                // trener (ime + prezime kao prikaz)
                var dtTrener = Db.Query("select trener_id, (ime || ' ' || prezime) as naziv from trener order by naziv");
                cbTrener.DisplayMember = "naziv";
                cbTrener.ValueMember = "trener_id";
                cbTrener.DataSource = dtTrener;

                // dvorana
                var dtDvorana = Db.Query("select dvorana_id, naziv from dvorana order by naziv");
                cbDvorana.DisplayMember = "naziv";
                cbDvorana.ValueMember = "dvorana_id";
                cbDvorana.DataSource = dtDvorana;

                SetPoruka("");
            }
            catch (Exception ex)
            {
                SetPoruka("Greška kod učitavanja lista: " + ex.Message);
            }
        }

        private void Osvjezi()
        {
            try
            {
                // Raspored termina + popunjenost (broj aktivnih prijava i slobodna mjesta)
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
                    "join trener  te on te.trener_id = tt.trener_id " +
                    "join dvorana d  on d.dvorana_id = tt.dvorana_id " +
                    "left join prijava p on p.termin_treninga_id = tt.termin_treninga_id and p.status = 'aktivna' " +
                    "group by tt.termin_treninga_id, tt.trening_id, tr.naziv, tt.trener_id, te.ime, te.prezime, tt.dvorana_id, d.naziv, tt.pocetak, tt.trajanje_min, tt.kapacitet " +
                    "order by tt.pocetak desc " +
                    "limit 200"
                );

                dgvTermini.DataSource = dt;

                if (dgvTermini.Columns != null)
                {
                    // Headeri
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

                    // Sakrij “ID” stupce da grid bude uredniji (ali ostaju dostupni za SelectionChanged)
                    if (dgvTermini.Columns.Contains("trening_id"))
                        dgvTermini.Columns["trening_id"].Visible = false;

                    if (dgvTermini.Columns.Contains("trener_id"))
                        dgvTermini.Columns["trener_id"].Visible = false;

                    if (dgvTermini.Columns.Contains("dvorana_id"))
                        dgvTermini.Columns["dvorana_id"].Visible = false;
                }

                SetPoruka("");
            }
            catch (Exception ex)
            {
                SetPoruka("Greška kod učitavanja termina: " + ex.Message);
            }
        }

        private int? DohvatiOdabraniTerminId()
        {
            if (dgvTermini.CurrentRow == null) return null;

            object? v = dgvTermini.CurrentRow.Cells["termin_treninga_id"]?.Value;
            if (v == null) return null;

            return Convert.ToInt32(v);
        }

        private bool ProcitajUnos(out int treningId, out int trenerId, out int dvoranaId, out DateTime pocetak, out int trajanjeMin, out int kapacitet)
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

        private void btnDodaj_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!ProcitajUnos(out int treningId, out int trenerId, out int dvoranaId, out DateTime pocetak, out int trajanjeMin, out int kapacitet))
                    return;

                Db.Exec(
                    "insert into termin_treninga (trening_id, trener_id, dvorana_id, pocetak, trajanje_min, kapacitet) " +
                    "values (@tg, @tr, @dv, @p, @tm, @k)",
                    new NpgsqlParameter("@tg", treningId),
                    new NpgsqlParameter("@tr", trenerId),
                    new NpgsqlParameter("@dv", dvoranaId),
                    new NpgsqlParameter("@p", pocetak),
                    new NpgsqlParameter("@tm", trajanjeMin),
                    new NpgsqlParameter("@k", kapacitet)
                );

                SetPoruka("Termin je uspješno dodan.");
                Osvjezi();
            }
            catch (Exception ex)
            {
                // Ovdje ćeš dobiti i poruke iz triggera za preklapanje trenera/dvorane
                SetPoruka(ex.Message);
            }
        }

        private void btnAzuriraj_Click(object? sender, EventArgs e)
        {
            try
            {
                int? terminId = DohvatiOdabraniTerminId();
                if (terminId == null)
                {
                    SetPoruka("Odaberi termin koji želiš ažurirati.");
                    return;
                }

                if (!ProcitajUnos(out int treningId, out int trenerId, out int dvoranaId, out DateTime pocetak, out int trajanjeMin, out int kapacitet))
                    return;

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
                );

                SetPoruka("Termin je ažuriran.");
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

                if (r != DialogResult.Yes)
                    return;

                Db.Exec(
                    "delete from termin_treninga where termin_treninga_id = @id",
                    new NpgsqlParameter("@id", terminId.Value)
                );

                SetPoruka("Termin je obrisan.");
                Osvjezi();
            }
            catch (Exception ex)
            {
                SetPoruka(ex.Message);
            }
        }

        private void btnOcisti_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cbTrening.Items.Count > 0) cbTrening.SelectedIndex = 0;
                if (cbTrener.Items.Count > 0) cbTrener.SelectedIndex = 0;
                if (cbDvorana.Items.Count > 0) cbDvorana.SelectedIndex = 0;

                dtpPocetak.Value = DateTime.Now;
                nudTrajanjeMin.Value = Math.Max(nudTrajanjeMin.Minimum, 60);
                nudKapacitet.Value = Math.Max(nudKapacitet.Minimum, 10);

                SetPoruka("");
            }
            catch
            {
                // ignore
            }
        }

        private void dgvTermini_SelectionChanged(object? sender, EventArgs e)
        {
            try
            {
                if (dgvTermini.CurrentRow == null) return;

                // ID-evi (skriveni u gridu) -> postavi ComboBox SelectedValue
                object? vt = dgvTermini.CurrentRow.Cells["trening_id"]?.Value;
                object? vtr = dgvTermini.CurrentRow.Cells["trener_id"]?.Value;
                object? vd = dgvTermini.CurrentRow.Cells["dvorana_id"]?.Value;

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
        }

        private void dgvTermini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}