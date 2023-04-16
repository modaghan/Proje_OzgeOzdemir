using Proje.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
            if (chkRememberMe.Checked = Settings.Default.RememberMe)
            {
                txtUsername.Text = Settings.Default.CurrentUsername;
                txtPassword.Text = Settings.Default.CurrentPassword;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == null)
                    throw new Exception("Kullanıcı adınızı giriniz!");
                if (txtPassword.Text == null)
                    throw new Exception("Parolanızı giriniz!");
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if ((username == Settings.Default.Username1 && password == Settings.Default.Password1) ||
                    (username == Settings.Default.Username2 && password == Settings.Default.Password2) ||
                    (username == Settings.Default.Username3 && password == Settings.Default.Password3))
                {
                    Settings.Default.RememberMe = chkRememberMe.Checked;
                    if (chkRememberMe.Checked)
                    {
                        Settings.Default.CurrentUsername = username;
                        Settings.Default.CurrentPassword = password;
                    }
                    else
                    {
                        Settings.Default.CurrentUsername = null;
                        Settings.Default.CurrentPassword = null;
                    }
                    Settings.Default.Save();

                    DialogResult = DialogResult.OK;
                }
                else
                    throw new Exception("Giriş onaylanmadı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
