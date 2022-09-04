using ETICARET.ORM.Entities;
using ETICARET.ORM.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETICARET
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = Execute.UserLogin(txt_email.Text, txt_password.Text);

            if (user == null)
            {
                MessageBox.Show("Giriş Başarısız. Bilgileri kontrol ediniz veya kayıt olunuz.");
            }

            else
            {
                MessageBox.Show("Giriş Başarılı");
                if (user.Username == "altanemre34")
                {
                    AdminCategory form = new AdminCategory();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    OrderPanel.UserID = user.ID;
                    CartPanel form = new CartPanel();
                    form.Show();
                    this.Hide();
                }
                
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            this.Hide();
            form.Show();
        }
    }
}
