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
    public partial class OrderPanel : Form
    {
        public static int UserID;
        public static ListBox listbox;
        public OrderPanel()
        {
            InitializeComponent();
        }

        private void OrderPanel_Load(object sender, EventArgs e)
        {
            cmb_city.DataSource = Execute.CityList();
            cmb_city.DisplayMember = "Name";
            cmb_city.ValueMember = "ID";
            

            User user = Execute.UserById(UserID);
            Address adres = Execute.UserAddressById(UserID);

            txt_name.Text = user.Name;
            txt_surname.Text = user.Surname;
            txt_email.Text = user.Email;
            txt_rgs_username.Text = user.Username;
            msk_phone.Text = user.Phone;
            cmb_city.Text = adres.City;
            cmb_district.Text = adres.Distinct;
            rch_adres.Text = adres.Street;

            lst_orders.Items.AddRange(listbox.Items);

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
