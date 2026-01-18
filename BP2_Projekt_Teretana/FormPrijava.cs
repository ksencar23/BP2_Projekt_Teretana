using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace BP2_Projekt_Teretana
{
    public partial class FormPrijava : Form
    {
        private bool _ucitavanje = false;

        public FormPrijava()
        {
            InitializeComponent();

            dgvPrijave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrijave.MultiSelect = false;
            dgvPrijave.ReadOnly = true;
            dgvPrijave.AllowUserToAddRows = false;

            dgvClanarina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClanarina.MultiSelect = false;
            dgvClanarina.ReadOnly = true;
            dgvClanarina.AllowUserToAddRows = false;

            cbClan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTermin.DropDownStyle = ComboBoxStyle.DropDownList;

            Load += FormPrijava_Load;

            btnPrijavi.Click += btnPrijavi_Click;
            btnOtkazi.Click += btnOtkazi_Click;
            btnObrisi.Click += btnObrisi_Click;

            cbClan.SelectedIndexChanged += cbClan_SelectedIndexChanged;
            dgvPrijave.SelectionChanged += dgvPrijave_SelectionChanged;
        }

        private void FormPrijava_Load(object? sender, EventArgs e)
        {
            _ucitavanje = true;

            UcitajClanove();
            UcitajTermine();
            OsvjeziPrijave();

            _ucitavanje = false;

            OsvjeziClanarinuZaOdabranogClana();
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
        private void UcitajClanove(object? keepSelected = null)
        {
            Ui.FillCombo(
                cbClan,
                "select clan_id, (ime || ' ' || prezime) as naziv from clan order by naziv",
                "naziv",
                "clan_id",
                keepSelected
            );
        }

        private void UcitajTermine(object? keepSelected = null)
        {
            Ui.FillCombo(
                cbTermin,
                "select " +
                "  tt.termin_treninga_id, " +
                "  (to_char(tt.pocetak, 'DD.MM.YYYY HH24:MI') || ' - ' || tr.naziv || ' - ' || " +
                "   (te.ime || ' ' || te.prezime) || ' - ' || d.naziv || " +
                "   ' (slobodno: ' || (tt.kapacitet - count(p.prijava_id)) || ')' || " +
                "   case when tt.pocetak < now() then ' [PROŠAO]' else '' end" +
                "  ) as naziv " +
                "from termin_treninga tt " +
                "join trening tr on tr.trening_id = tt.trening_id " +
                "join trener te on te.trener_id = tt.trener_id " +
                "join dvorana d on d.dvorana_id = tt.dvorana_id " +
                "left join prijava p on p.termin_treninga_id = tt.termin_treninga_id and p.status = 'aktivna' " +
                "group by tt.termin_treninga_id, tt.pocetak, tr.naziv, te.ime, te.prezime, d.naziv, tt.kapacitet " +
                "order by tt.pocetak desc",
                "naziv",
                "termin_treninga_id",
                keepSelected
            );
        }

        // ---------------------------
        // Reload pattern (jedno mjesto)
        // ---------------------------
        private void ReloadAll(string? poruka)
        {
            object? keepClan = cbClan.SelectedValue;
            object? keepTermin = cbTermin.SelectedValue;

            OsvjeziPrijave();

            _ucitavanje = true;
            UcitajClanove(keepClan);
            UcitajTermine(keepTermin);
            _ucitavanje = false;

            OsvjeziClanarinuZaOdabranogClana();

            if (!string.IsNullOrWhiteSpace(poruka))
                SetPoruka(poruka!);
        }

        private void RunAction(string okMsg, Action dbAction)
        {
            Db.Run(() =>
            {
                dbAction();
                ReloadAll(okMsg);
            }, SetPoruka);
        }

        // ---------------------------
        // Grid: prijave
        // ---------------------------
        private void OsvjeziPrijave()
        {
            DataTable dt = Db.Query(
                "select " +
                "  p.prijava_id, " +
                "  p.clan_id, (c.ime || ' ' || c.prezime) as clan, " +
                "  p.termin_treninga_id, " +
                "  tr.naziv as trening, " +
                "  (te.ime || ' ' || te.prezime) as trener, " +
                "  d.naziv as dvorana, " +
                "  tt.pocetak, " +
                "  p.datum_prijave, " +
                "  p.status " +
                "from prijava p " +
                "join clan c on c.clan_id = p.clan_id " +
                "join termin_treninga tt on tt.termin_treninga_id = p.termin_treninga_id " +
                "join trening tr on tr.trening_id = tt.trening_id " +
                "join trener te on te.trener_id = tt.trener_id " +
                "join dvorana d on d.dvorana_id = tt.dvorana_id " +
                "order by p.prijava_id desc " +
                "limit 150"
            );

            dgvPrijave.DataSource = dt;

            if (dgvPrijave.Columns == null) return;

            if (dgvPrijave.Columns.Contains("prijava_id"))
                dgvPrijave.Columns["prijava_id"].HeaderText = "ID prijave";

            if (dgvPrijave.Columns.Contains("clan"))
                dgvPrijave.Columns["clan"].HeaderText = "Član";

            if (dgvPrijave.Columns.Contains("trening"))
                dgvPrijave.Columns["trening"].HeaderText = "Trening";

            if (dgvPrijave.Columns.Contains("trener"))
                dgvPrijave.Columns["trener"].HeaderText = "Trener";

            if (dgvPrijave.Columns.Contains("dvorana"))
                dgvPrijave.Columns["dvorana"].HeaderText = "Dvorana";

            if (dgvPrijave.Columns.Contains("pocetak"))
            {
                dgvPrijave.Columns["pocetak"].HeaderText = "Početak termina";
                dgvPrijave.Columns["pocetak"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }

            if (dgvPrijave.Columns.Contains("datum_prijave"))
            {
                dgvPrijave.Columns["datum_prijave"].HeaderText = "Datum prijave";
                dgvPrijave.Columns["datum_prijave"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }

            if (dgvPrijave.Columns.Contains("status"))
                dgvPrijave.Columns["status"].HeaderText = "Status";

            if (dgvPrijave.Columns.Contains("clan_id"))
                dgvPrijave.Columns["clan_id"].Visible = false;

            if (dgvPrijave.Columns.Contains("termin_treninga_id"))
                dgvPrijave.Columns["termin_treninga_id"].Visible = false;
        }

        // ---------------------------
        // Grid: članarina odabranog člana (parametrizirano!)
        // ---------------------------
        private void OsvjeziClanarinuZaOdabranogClana()
        {
            try
            {
                if (cbClan.SelectedValue == null)
                {
                    dgvClanarina.DataSource = null;
                    return;
                }

                int clanId = Convert.ToInt32(cbClan.SelectedValue);

                DataTable dt = Db.Query(
                    "select cl.clanarina_id, p.naziv as paket, p.omogucuje_termine, cl.datum_pocetka, cl.datum_isteka, cl.status " +
                    "from clanarina cl " +
                    "join paket p on p.paket_id = cl.paket_id " +
                    "where cl.clan_id = @id " +
                    "order by (cl.status = 'aktivna') desc, cl.datum_isteka desc " +
                    "limit 5",
                    new NpgsqlParameter("@id", clanId)
                );

                dgvClanarina.DataSource = dt;

                if (dgvClanarina.Columns == null) return;

                if (dgvClanarina.Columns.Contains("clanarina_id"))
                    dgvClanarina.Columns["clanarina_id"].HeaderText = "Članarina ID";

                if (dgvClanarina.Columns.Contains("paket"))
                    dgvClanarina.Columns["paket"].HeaderText = "Paket";

                if (dgvClanarina.Columns.Contains("omogucuje_termine"))
                    dgvClanarina.Columns["omogucuje_termine"].HeaderText = "Omog. termine";

                if (dgvClanarina.Columns.Contains("datum_pocetka"))
                {
                    dgvClanarina.Columns["datum_pocetka"].HeaderText = "Početak";
                    dgvClanarina.Columns["datum_pocetka"].DefaultCellStyle.Format = "dd.MM.yyyy";
                }

                if (dgvClanarina.Columns.Contains("datum_isteka"))
                {
                    dgvClanarina.Columns["datum_isteka"].HeaderText = "Istek";
                    dgvClanarina.Columns["datum_isteka"].DefaultCellStyle.Format = "dd.MM.yyyy";
                }

                if (dgvClanarina.Columns.Contains("status"))
                    dgvClanarina.Columns["status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                SetPoruka("Greška kod učitavanja članarine: " + ex.Message);
            }
        }

        // ---------------------------
        // Helpers
        // ---------------------------
        private bool ProcitajUnos(out int clanId, out int terminId)
        {
            clanId = 0;
            terminId = 0;

            if (cbClan.SelectedValue == null)
            {
                SetPoruka("Odaberi člana.");
                return false;
            }

            if (cbTermin.SelectedValue == null)
            {
                SetPoruka("Odaberi termin.");
                return false;
            }

            clanId = Convert.ToInt32(cbClan.SelectedValue);
            terminId = Convert.ToInt32(cbTermin.SelectedValue);
            return true;
        }

        private int? DohvatiOdabranuPrijavuId()
        {
            if (dgvPrijave.CurrentRow == null) return null;
            object? v = dgvPrijave.CurrentRow.Cells["prijava_id"]?.Value;
            if (v == null) return null;
            return Convert.ToInt32(v);
        }

        // ---------------------------
        // Actions
        // ---------------------------
        private void btnPrijavi_Click(object? sender, EventArgs e)
        {
            if (!ProcitajUnos(out int clanId, out int terminId)) return;

            RunAction("Prijava je uspješno spremljena.", () =>
                Db.Exec(
                    "insert into prijava (clan_id, termin_treninga_id, status) values (@c, @t, 'aktivna')",
                    new NpgsqlParameter("@c", clanId),
                    new NpgsqlParameter("@t", terminId)
                )
            );
        }

        private void btnOtkazi_Click(object? sender, EventArgs e)
        {
            int? prijavaId = DohvatiOdabranuPrijavuId();
            if (prijavaId == null)
            {
                SetPoruka("Odaberi prijavu koju želiš otkazati.");
                return;
            }

            RunAction("Prijava je otkazana.", () =>
                Db.Exec(
                    "update prijava set status = 'otkazana' where prijava_id = @id",
                    new NpgsqlParameter("@id", prijavaId.Value)
                )
            );
        }

        private void btnObrisi_Click(object? sender, EventArgs e)
        {
            int? prijavaId = DohvatiOdabranuPrijavuId();
            if (prijavaId == null)
            {
                SetPoruka("Odaberi prijavu koju želiš obrisati.");
                return;
            }

            RunAction("Prijava je obrisana.", () =>
                Db.Exec(
                    "delete from prijava where prijava_id = @id",
                    new NpgsqlParameter("@id", prijavaId.Value)
                )
            );
        }

        // ---------------------------
        // Events
        // ---------------------------
        private void cbClan_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_ucitavanje) return;
            OsvjeziClanarinuZaOdabranogClana();
        }

        private void dgvPrijave_SelectionChanged(object? sender, EventArgs e)
        {
            if (_ucitavanje) return;
            if (dgvPrijave.CurrentRow == null) return;

            try
            {
                object? vc = dgvPrijave.CurrentRow.Cells["clan_id"]?.Value;
                object? vt = dgvPrijave.CurrentRow.Cells["termin_treninga_id"]?.Value;

                _ucitavanje = true;

                if (vc != null) cbClan.SelectedValue = Convert.ToInt32(vc);
                if (vt != null) cbTermin.SelectedValue = Convert.ToInt32(vt);

                _ucitavanje = false;

                OsvjeziClanarinuZaOdabranogClana();
            }
            catch
            {
                _ucitavanje = false;
            }
        }
    }
}