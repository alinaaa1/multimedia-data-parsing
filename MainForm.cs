using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProiectEAV_Muzee
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;

        public MainForm()
        {
            InitializeComponent();
            ConfigurareDashboard();
        }

        private void ConfigurareDashboard()
        {
            this.Text = "Sistem Gestiune Muzee - Oltenia";
            this.StartPosition = FormStartPosition.CenterScreen;

            // am setat ca fereastra să se deschidă direct pe tot ecranul 
            this.WindowState = FormWindowState.Maximized;

            StilizeazaButonMeniu(btnManage);
            StilizeazaButonMeniu(btnLogout);
        }

        private void StilizeazaButonMeniu(Button btn)
        {
            //  am configurat butoanele din meniu
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.Cursor = Cursors.Hand; 
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(15, 0, 0, 0); 
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill; 

            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront(); 
            childForm.Show(); 
        }

        //  am configurat butonul de Gestionare: când dau click, se deschide pagina cu tabelul de muzee
        private void btnManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageFilesForm());
        }

        // am configurat butonul de Deconectare
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); 
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "LoginForm")
                {
                    f.Show();
                    break;
                }
            }
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}