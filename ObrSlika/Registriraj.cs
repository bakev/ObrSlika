using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObrSlika
{
    public partial class Registriraj : Form
    {
        public Registriraj()
        {
            InitializeComponent();
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                Login obj = new Login
                {
                    Username = txtUserName.Text,
                    Password = txtPassword.Text
                };
                db.Logins.Add(obj);
                db.SaveChanges();
                MessageBox.Show("Корисникот е регистриран");
            }
        }
    }
}
