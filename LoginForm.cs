using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProiectEAV_Muzee
{
    public partial class LoginForm : Form
    {
        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        public LoginForm()
        {
            InitializeComponent();
            AplicaDesignModern();
        }

        private void AplicaDesignModern()
        {
            //  am setat culorile ferestrei 
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(800, 500); //  am setat mărimea ferestrei
            this.StartPosition = FormStartPosition.CenterScreen; // am făcut ca fereastra să se deschidă direct pe mijlocul ecranului

            StilizeazaButon(btnLogin, Color.FromArgb(0, 122, 204));
            StilizeazaButon(btnRegister, Color.FromArgb(28, 151, 108));

            //  am configurat butonul X 
            if (btnClose != null)
            {
                btnClose.FlatStyle = FlatStyle.Flat;
                btnClose.FlatAppearance.BorderSize = 0;
                btnClose.ForeColor = Color.White;
                btnClose.Text = "X";
                btnClose.Cursor = Cursors.Hand;
            }
        }

        private void StilizeazaButon(Button btn, Color culoare)
        {

            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = culoare;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        // BUTONUL DE LOGIN 
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Verific daca utilizatorul a lasat casutele goale
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Te rog completează ambele câmpuri!");
                return;
            }

            // Caut în baza de date daca există utilizatorul cu aceasta parola
            string query = "SELECT * FROM Users WHERE Username = @user AND Password = @pass";
            SqlParameter[] p = {
                new SqlParameter("@user", txtUser.Text),
                new SqlParameter("@pass", txtPass.Text)
            };

            DataTable dt = await DBHelper.GetDataAsync(query, p);

            if (dt.Rows.Count > 0)
            {
                this.Hide(); 
                MainForm main = new MainForm();
                main.Show(); 
            }
            else
            {
                MessageBox.Show("Utilizator sau parolă incorectă!");
            }
        }

        // BUTONUL DE ÎNREGISTRARE 
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Introdu un nume de utilizator și o parolă!");
                return;
            }
            try
            {
                //  verific dacă numele de utilizator nu este deja luat
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @user";
                DataTable dt = await DBHelper.GetDataAsync(checkQuery, new SqlParameter[] { new SqlParameter("@user", txtUser.Text) });

                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Acest nume de utilizator este deja luat!");
                    return;
                }

                // Daca numele e liber il introduc în baza de date
                string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@user, @pass)";
                SqlParameter[] p = {
                    new SqlParameter("@user", txtUser.Text),
                    new SqlParameter("@pass", txtPass.Text)
                };

                await DBHelper.ExecuteQueryAsync(insertQuery, p);
                MessageBox.Show("Cont creat cu succes! Te poți loga acum.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la înregistrare: " + ex.Message);
            }
        }

        // butonul X inchide aplicatia
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.MouseDown += LoginForm_MouseDown;
            this.MouseMove += LoginForm_MouseMove;
            this.MouseUp += LoginForm_MouseUp;
        }

        private void lblPass_Click(object sender, EventArgs e)
        {
            
        }
    }
}