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

            // Grid ponašanje
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

            UcitajListe();
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
        // Učitavanje lista (članovi + termini)
        // ---------------------------
        private void UcitajListe()
        {
            try
            {
                // Članovi
                DataTable dtClan = Db.Query(
                    "select clan_id, (ime || ' ' || prezime) as naziv " +
                    "from clan " +
                    "order by naziv"
                );

                cbClan.DisplayMember = "naziv";
                cbClan.ValueMember = "clan_id";
                cbClan.DataSource = dtClan;

                // Termini (prikaz s treningom/trenerom/dvoranom + slobodno mjesta)
                DataTable dtTermin = Db.Query(
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
                    "order by tt.pocetak desc"
                );

                cbTermin.DisplayMember = "naziv";
                cbTermin.ValueMember = "termin_treninga_id";
                cbTermin.DataSource = dtTermin;

                SetPoruka("");
            }
            catch (Exception ex)
            {
                SetPoruka("Greška kod učitavanja lista: " + ex.Message);
            }
        }

        private void UcitajTermineSamo()
        {
            // Osvježi slobodna mjesta u nazivu termina (nakon prijave/otkazivanja/brisanja)
            try
            {
                object? trenutni = cbTermin.SelectedValue;

                DataTable dtTermin = Db.Query(
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
                    "order by tt.pocetak desc"
                );

                _ucitavanje = true;
                cbTermin.DataSource = dtTermin;
                _ucitavanje = false;

                if (trenutni != null)
                    cbTermin.SelectedValue = trenutni;
            }
            catch
            {
                // ignore
            }
        }

        // ---------------------------
        // Glavni grid: sve prijave
        // ---------------------------
        private void OsvjeziPrijave()
        {
            try
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

                if (dgvPrijave.Columns != null)
                {
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

                    // sakrij ID stupce
                    if (dgvPrijave.Columns.Contains("clan_id"))
                        dgvPrijave.Columns["clan_id"].Visible = false;

                    if (dgvPrijave.Columns.Contains("termin_treninga_id"))
                        dgvPrijave.Columns["termin_treninga_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                SetPoruka("Greška kod učitavanja prijava: " + ex.Message);
            }
        }

        // ---------------------------
        // Dodatni grid: članarina odabranog člana
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
                    "select " +
                    "  cl.clanarina_id, " +
                    "  p.naziv as paket, " +
                    "  p.omogucuje_termine, " +
                    "  cl.datum_pocetka, " +
                    "  cl.datum_isteka, " +
                    "  cl.status " +
                    "from clanarina cl " +
                    "join paket p on p.paket_id = cl.paket_id " +
                    "where cl.clan_id = " + clanId + " " +
                    "order by (cl.status = 'aktivna') desc, cl.datum_isteka desc " +
                    "limit 5"
                );

                dgvClanarina.DataSource = dt;

                if (dgvClanarina.Columns != null)
                {
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
            }
            catch (Exception ex)
            {
                SetPoruka("Greška kod učitavanja članarine: " + ex.Message);
            }
        }

        // ---------------------------
        // Akcije
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

        private void btnPrijavi_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!ProcitajUnos(out int clanId, out int terminId))
                    return;

                Db.Exec(
                    "insert into prijava (clan_id, termin_treninga_id, status) values (@c, @t, 'aktivna')",
                    new NpgsqlParameter("@c", clanId),
                    new NpgsqlParameter("@t", terminId)
                );

                SetPoruka("Prijava je uspješno spremljena.");

                OsvjeziPrijave();
                UcitajTermineSamo();
                OsvjeziClanarinuZaOdabranogClana();
            }
            catch (Exception ex)
            {
                SetPoruka(ex.Message);
            }
        }

        private int? DohvatiOdabranuPrijavuId()
        {
            if (dgvPrijave.CurrentRow == null) return null;
            object? v = dgvPrijave.CurrentRow.Cells["prijava_id"]?.Value;
            if (v == null) return null;
            return Convert.ToInt32(v);
        }

        private void btnOtkazi_Click(object? sender, EventArgs e)
        {
            try
            {
                int? prijavaId = DohvatiOdabranuPrijavuId();
                if (prijavaId == null)
                {
                    SetPoruka("Odaberi prijavu koju želiš otkazati.");
                    return;
                }

                Db.Exec(
                    "update prijava set status = 'otkazana' where prijava_id = @id",
                    new NpgsqlParameter("@id", prijavaId.Value)
                );

                SetPoruka("Prijava je otkazana.");

                OsvjeziPrijave();
                UcitajTermineSamo();
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
                int? prijavaId = DohvatiOdabranuPrijavuId();
                if (prijavaId == null)
                {
                    SetPoruka("Odaberi prijavu koju želiš obrisati.");
                    return;
                }

                Db.Exec(
                    "delete from prijava where prijava_id = @id",
                    new NpgsqlParameter("@id", prijavaId.Value)
                );

                SetPoruka("Prijava je obrisana.");

                OsvjeziPrijave();
                UcitajTermineSamo();
            }
            catch (Exception ex)
            {
                SetPoruka(ex.Message);
            }
        }

        // ---------------------------
        // Eventovi
        // ---------------------------
        private void cbClan_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_ucitavanje) return;
            OsvjeziClanarinuZaOdabranogClana();
        }

        private void dgvPrijave_SelectionChanged(object? sender, EventArgs e)
        {
            try
            {
                if (dgvPrijave.CurrentRow == null) return;

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
