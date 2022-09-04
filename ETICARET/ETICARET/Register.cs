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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            cmb_city.DataSource = Execute.CityList();
            cmb_city.DisplayMember = "Name";
            cmb_city.ValueMember = "ID";
            cmb_city.SelectedIndex = -1;

        }
    

        private void btn_register_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Phone = msk_phone.Text;
            user.Surname = txt_surname.Text;
            user.Name = txt_name.Text;
            user.Username = txt_rgs_username.Text;
            user.Email = txt_email.Text;
            user.Password = txt_rgs_password.Text;

            Address address = new Address();
            address.City = cmb_city.Text;
            address.Distinct = cmb_district.Text;
            address.Street = rch_adres.Text;

            user.Addresses.Add(address);


            int result = Execute.UserInsert(user);
            if (result == -1)
                MessageBox.Show("Tanımlı Kullanıcı Adı Hatası");
            else if(result==-2)
                MessageBox.Show("Tanımlı Email Adresi Hatası");
            else if (result > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
                LoginPanel form = new LoginPanel();
                form.Show();
                this.Hide();
            }
              
            else
                MessageBox.Show("Kayıt Başarısız!!");

            
        }

        private void cmb_city_DropDownClosed(object sender, EventArgs e)
        {
            int id = (int)cmb_city.SelectedValue;
            cmb_district.DataSource = Execute.DistrictList(id);
            cmb_district.DisplayMember = "Name";
            cmb_district.ValueMember = "ID";
        }
    }
}
