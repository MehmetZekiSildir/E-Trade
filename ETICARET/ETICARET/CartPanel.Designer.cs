namespace ETICARET
{
    partial class CartPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgrid_products = new System.Windows.Forms.DataGridView();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.lst_orders = new System.Windows.Forms.ListBox();
            this.btn_cartAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_products)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(270, 32);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(271, 21);
            this.cmbcategory.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(136, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "KATEGORİ:";
            // 
            // dtgrid_products
            // 
            this.dtgrid_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_products.Location = new System.Drawing.Point(139, 132);
            this.dtgrid_products.Name = "dtgrid_products";
            this.dtgrid_products.Size = new System.Drawing.Size(512, 150);
            this.dtgrid_products.TabIndex = 14;
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_list.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_list.Location = new System.Drawing.Point(270, 84);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(271, 33);
            this.btn_list.TabIndex = 34;
            this.btn_list.Text = "LİSTELE";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_order.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_order.Location = new System.Drawing.Point(749, 304);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(207, 33);
            this.btn_order.TabIndex = 35;
            this.btn_order.Text = "SİPARİŞ VER";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // lst_orders
            // 
            this.lst_orders.FormattingEnabled = true;
            this.lst_orders.Location = new System.Drawing.Point(749, 32);
            this.lst_orders.Name = "lst_orders";
            this.lst_orders.Size = new System.Drawing.Size(196, 251);
            this.lst_orders.TabIndex = 36;
            // 
            // btn_cartAdd
            // 
            this.btn_cartAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cartAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cartAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cartAdd.Location = new System.Drawing.Point(270, 304);
            this.btn_cartAdd.Name = "btn_cartAdd";
            this.btn_cartAdd.Size = new System.Drawing.Size(271, 33);
            this.btn_cartAdd.TabIndex = 37;
            this.btn_cartAdd.Text = "SEPETE EKLE";
            this.btn_cartAdd.UseVisualStyleBackColor = false;
            this.btn_cartAdd.Click += new System.EventHandler(this.btn_cartAdd_Click);
            // 
            // CartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 450);
            this.Controls.Add(this.btn_cartAdd);
            this.Controls.Add(this.lst_orders);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.dtgrid_products);
            this.Controls.Add(this.cmbcategory);
            this.Controls.Add(this.label5);
            this.Name = "CartPanel";
            this.Text = "CartPanel";
            this.Load += new System.EventHandler(this.OrderPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgrid_products;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.ListBox lst_orders;
        private System.Windows.Forms.Button btn_cartAdd;
    }
}