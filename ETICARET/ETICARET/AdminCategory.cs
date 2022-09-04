using ETICARET.ORM.Context;
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
    public partial class AdminCategory : Form
    {
        public AdminCategory()
        {
            InitializeComponent();
        }
        ProjectContext db;
        private void Form1_Load(object sender, EventArgs e)
        {
            db= new ProjectContext();   
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Description = txt_description.Text;
            cat.CategoryName = txt_categoryName.Text;

            int Sonuc=Execute.CategoryInsert(cat);

            if (Sonuc > 0)
            {
                txt_categoryName.Text = "";
                txt_description.Text = "";
                MessageBox.Show("Kayıt Başarılı.");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!!");
            }
          
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProduct ad = new AdminProduct();
            ad.Show();
        }
    }
}
