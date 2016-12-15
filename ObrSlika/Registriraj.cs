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
       
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtIme.Text)|| String.IsNullOrEmpty(txtPrezime.Text) || String.IsNullOrEmpty(txtMeil.Text))
            {
                MessageBox.Show("Ве молиме потполнете ги соодветните полиња.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LogFile.WriteWarningLog("Пробано да се регистрира корисник ,но проблем празно поле");
            }
            else
            {
                try
                {
                    using (var db = new DatabaseContext())
                    {
                        Login obj = new Login
                        {
                            Username = txtUserName.Text,
                            Password = txtPassword.Text,
                            Ime = txtIme.Text,
                            Prezime = txtPrezime.Text,
                            Email = txtMeil.Text
                        };
                        db.Logins.Add(obj);
                        db.SaveChanges();
                        MessageBox.Show("Корисникот е регистриран");
                        LogFile.WriteInformationLog("Внесен е нов корисник");
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("UserName веќе постои");

                    LogFile.WriteErrorLog("Внесен корисник со постеечки UserName");
                }
            }
        }

        private void btnVratiVoNajava_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }
    }
}
