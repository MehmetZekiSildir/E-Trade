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
    public partial class AdminProduct : Form
    {
        public AdminProduct()
        {
            InitializeComponent();
        }

        private void CategoryList()
        {
            cmbcategory.DataSource = Execute.CategoryList();
            cmbcategory.DisplayMember = "CategoryName";
            cmbcategory.ValueMember = "ID";
            cmbcategory.SelectedIndex = -1;
        }

        private void AdminProduct_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = txtproductname.Text;
            p.Price = (double)nmr_price.Value;
            p.Stock = (int)nmr_price.Value;
            p.CategoryID = (int)cmbcategory.SelectedValue;

            if (Execute.ProductInsert(p) > 0)
            {
                txtproductname.Text = "";
                nmr_price.Value = 0;
                nmr_stock.Value = 0;
                cmbcategory.SelectedIndex = -1;
                MessageBox.Show("Kayıt Başarılı.");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!!");
            }

        }
    }
}
