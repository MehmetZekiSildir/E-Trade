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
    public partial class CartPanel : Form
    {
        public CartPanel()
        {
            InitializeComponent();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            int catid = (int)cmbcategory.SelectedValue;
            dtgrid_products.DataSource= Execute.ProductByCategoryId(catid);
        }

        private void OrderPanel_Load(object sender, EventArgs e)
        {
            cmbcategory.DataSource = Execute.CategoryList();
            cmbcategory.DisplayMember = "CategoryName";
            cmbcategory.ValueMember = "ID";
            cmbcategory.SelectedIndex = -1;
        }

        private void btn_cartAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgrid_products.SelectedRows)
            {
                //lst_orders.Items.Add(Execute.ProductById(Convert.ToInt32(row.Cells[0].Value.ToString())).ProductName);
                lst_orders.Items.Add(Execute.ProductById(Convert.ToInt32(row.Cells[0].Value.ToString())));
            }
            
            OrderPanel.listbox=lst_orders;
            
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OrderPanel form = new OrderPanel();
            this.Hide();
            form.Show();
        }
    }
}
