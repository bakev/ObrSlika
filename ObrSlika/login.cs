using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ObrSlika
{
    public partial class login : Form
    {


        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Boolean user = LoginUser(UsernameText.Text, PasswordText.Text);
            if (user == true)
            {
                LogFile.WriteInformationLog("Najaven Korisnik");
                this.Hide();
                Slika ss = new Slika();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Ве молиме проверете го вашето корисничко име или пасвордот");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean LoginUser(String Username, String Password)
        {
            using (var db = new DatabaseContext())
            {
                var query = from u in db.Logins
                            where u.Username == Username && u.Password == Password
                            select u;
                if (query.Count() == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            Registriraj obj1 = new Registriraj();
            this.Hide();
            obj1.ShowDialog();
            this.Show();
        }

        private void PasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }
    }
}
