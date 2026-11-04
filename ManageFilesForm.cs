using System;
using System.Collections.Generic; // Necesar pentru List
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;                  // Necesar pentru StreamWriter
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;   // Necesar pentru XML

namespace ProiectEAV_Muzee
{
    public partial class ManageFilesForm : Form
    {
        public ManageFilesForm()
        {
            InitializeComponent();
            AplicaDesignEstetic();
        }

        private void AplicaDesignEstetic()
        {
            this.BackColor = Color.GhostWhite;
            if (btnAdd != null) btnAdd.BackColor = Color.MediumSeaGreen;
            if (btnDelete != null) btnDelete.BackColor = Color.IndianRed;
            if (btnSort != null) btnSort.BackColor = Color.CornflowerBlue;
            if (lvDate != null) lvDate.BackColor = Color.AliceBlue;
        }

        private async void ManageFilesForm_Load(object sender, EventArgs e)
        {
            await IncarcaUtilizatori();
            await IncarcaDate();
        }

        // --- PASUL A: Metoda Smart de conversie ---
        // Aceasta rezolvă problema tag-urilor goale din XML
        private List<Muzeu> ConvertesteTabelInLista(DataTable dt)
        {
            List<Muzeu> lista = new List<Muzeu>();
            foreach (DataRow r in dt.Rows)
            {
                string nume = r["FileName"].ToString();
                string localitate = r["Localitate"].ToString();
                string pret = r["PretBilet"].ToString();
                int ratingValue = r["Rating"] != DBNull.Value ? Convert.ToInt32(r["Rating"]) : 0;

                // Logica de completare automată pentru datele care lipsesc în DB
                if (string.IsNullOrEmpty(localitate) || localitate == "Nesetat")
                {
                    if (nume.Contains("Craiova")) localitate = "Craiova";
                    else if (nume.Contains("Targu Jiu") || nume.Contains("Brancusi")) localitate = "Târgu Jiu";
                    else if (nume.Contains("Olt")) localitate = "Slatina";
                    else if (nume.Contains("Valcea")) localitate = "Râmnicu Vâlcea";
                    else if (nume.Contains("Portilor de Fier")) localitate = "Drobeta-Turnu Severin";
                    else localitate = "Oltenia";
                }

                if (string.IsNullOrEmpty(pret) || pret == "0")
                {
                    if (nume.Contains("Arta")) pret = "20";
                    else if (nume.Contains("Judetean")) pret = "15";
                    else pret = "10";
                }

                if (ratingValue == 0) ratingValue = 5;

                lista.Add(new Muzeu
                {
                    Id = Convert.ToInt32(r["Id"]),
                    Nume = nume,
                    Program = r["Program"].ToString(),
                    Localitate = localitate,
                    Pret = pret,
                    Rating = ratingValue,
                    Username = r["Username"].ToString()
                });
            }
            return lista;
        }

        // --- PASUL B: Evenimentul butonului de Export XML ---
        private async void btnExportXML_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Preluăm datele prin DBHelper
                string sql = "SELECT f.Id, f.FileName, f.Program, f.Localitate, f.PretBilet, f.Rating, u.Username " +
                             "FROM UserFiles f JOIN Users u ON f.UserId = u.Id";
                DataTable dt = await DBHelper.GetDataAsync(sql);

                // 2. Convertim tabelul în lista de obiecte folosind metoda "Smart"
                List<Muzeu> dateDeSalvat = ConvertesteTabelInLista(dt);

                // 3. Afișăm dialogul de salvare
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Fișier XML (*.xml)|*.xml";
                    sfd.FileName = "Muzee_Oltenia.xml";
                    sfd.Title = "Salvează datele muzeelor în format XML";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // 4. Serializăm lista în fișierul ales
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Muzeu>));
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            serializer.Serialize(sw, dateDeSalvat);
                        }

                        MessageBox.Show("Exportul XML a fost realizat cu succes și datele au fost completate!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la export: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Restul metodelor tale originale ---
        private async Task IncarcaUtilizatori()
        {
            try
            {
                DataTable dt = await DBHelper.GetDataAsync("SELECT Id, Username FROM Users");
                if (cmbUsers != null)
                {
                    cmbUsers.DataSource = dt;
                    cmbUsers.DisplayMember = "Username";
                    cmbUsers.ValueMember = "Id";
                }
            }
            catch { }
        }

        private async Task IncarcaDate(string filtru = "")
        {
            if (lvDate == null) return;
            lvDate.Items.Clear();

            string sql = "SELECT f.Id, f.FileName, f.Program, f.Localitate, f.PretBilet, f.Rating, u.Username " +
                         "FROM UserFiles f JOIN Users u ON f.UserId = u.Id";
            DataTable dt = await DBHelper.GetDataAsync(sql);

            foreach (DataRow r in dt.Rows)
            {
                string nume = r["FileName"].ToString();
                if (nume.ToLower().Contains(filtru.ToLower()))
                {
                    string localitate = r["Localitate"].ToString();
                    string pret = r["PretBilet"].ToString();
                    int ratingValue = r["Rating"] != DBNull.Value ? Convert.ToInt32(r["Rating"]) : 0;

                    if (string.IsNullOrEmpty(localitate) || localitate == "Nesetat")
                    {
                        if (nume.Contains("Craiova")) localitate = "Craiova";
                        else if (nume.Contains("Targu Jiu") || nume.Contains("Brancusi")) localitate = "Târgu Jiu";
                        else if (nume.Contains("Olt")) localitate = "Slatina";
                        else if (nume.Contains("Valcea")) localitate = "Râmnicu Vâlcea";
                        else if (nume.Contains("Portilor de Fier")) localitate = "Drobeta-Turnu Severin";
                        else localitate = "Oltenia";
                    }

                    if (string.IsNullOrEmpty(pret) || pret == "0")
                    {
                        if (nume.Contains("Arta")) pret = "20";
                        else if (nume.Contains("Judetean")) pret = "15";
                        else pret = "10";
                    }

                    if (ratingValue == 0) ratingValue = 5;

                    ListViewItem it = new ListViewItem(nume);
                    it.SubItems.Add(r["Program"].ToString());
                    it.SubItems.Add(localitate);
                    it.SubItems.Add(pret + " Lei");
                    it.SubItems.Add(new string('★', ratingValue));
                    it.SubItems.Add(r["Username"].ToString());

                    it.Tag = r["Id"];
                    lvDate.Items.Add(it);
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text) ||
                string.IsNullOrWhiteSpace(txtLocalitate.Text) ||
                string.IsNullOrWhiteSpace(txtPret.Text))
            {
                MessageBox.Show("Te rog să completezi Numele, Localitatea și Prețul!");
                return;
            }

            string query = "INSERT INTO UserFiles (FileName, Program, Localitate, PretBilet, Rating, UserId) " +
                           "VALUES (@n, @p, @loc, @pret, @rat, @u)";

            SqlParameter[] p = {
                new SqlParameter("@n", txtFileName.Text),
                new SqlParameter("@p", "09:00 - 17:00"),
                new SqlParameter("@loc", txtLocalitate.Text),
                new SqlParameter("@pret", txtPret.Text),
                new SqlParameter("@rat", (int)txtRating.Value),
                new SqlParameter("@u", cmbUsers.SelectedValue)
            };

            await DBHelper.ExecuteQueryAsync(query, p);
            txtFileName.Clear();
            txtLocalitate.Clear();
            txtPret.Clear();
            txtRating.Value = 5;
            await IncarcaDate();
            MessageBox.Show("Muzeu adăugat cu succes!");
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            await IncarcaDate(txtSearch.Text);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lvDate.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvDate.Sort();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvDate.SelectedItems.Count > 0)
            {
                var id = lvDate.SelectedItems[0].Tag;
                if (MessageBox.Show("Ștergi acest muzeu?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await DBHelper.ExecuteQueryAsync("DELETE FROM UserFiles WHERE Id=@id", new SqlParameter[] { new SqlParameter("@id", id) });
                    await IncarcaDate();
                }
            }
        }
    }
}