namespace ETICARET
{
    partial class OrderPanel
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rch_adres = new System.Windows.Forms.RichTextBox();
            this.cmb_district = new System.Windows.Forms.ComboBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.msk_phone = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_orderCompleted = new System.Windows.Forms.Button();
            this.txt_rgs_username = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_orders = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_orders);
            this.groupBox2.Controls.Add(this.rch_adres);
            this.groupBox2.Controls.Add(this.cmb_district);
            this.groupBox2.Controls.Add(this.cmb_city);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.msk_phone);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_orderCompleted);
            this.groupBox2.Controls.Add(this.txt_rgs_username);
            this.groupBox2.Controls.Add(this.txt_surname);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(18, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1348, 381);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SİPARİŞ PANELİ";
            // 
            // rch_adres
            // 
            this.rch_adres.Location = new System.Drawing.Point(578, 138);
            this.rch_adres.Name = "rch_adres";
            this.rch_adres.Size = new System.Drawing.Size(342, 177);
            this.rch_adres.TabIndex = 23;
            this.rch_adres.Text = "";
            // 
            // cmb_district
            // 
            this.cmb_district.FormattingEnabled = true;
            this.cmb_district.Location = new System.Drawing.Point(578, 84);
            this.cmb_district.Name = "cmb_district";
            this.cmb_district.Size = new System.Drawing.Size(342, 28);
            this.cmb_district.TabIndex = 22;
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(578, 35);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(342, 28);
            this.cmb_city.TabIndex = 21;
            this.cmb_city.DropDownClosed += new System.EventHandler(this.cmb_city_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "İlçe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Şehir:";
            // 
            // msk_phone
            // 
            this.msk_phone.Location = new System.Drawing.Point(158, 242);
            this.msk_phone.Mask = "(999) 000-0000";
            this.msk_phone.Name = "msk_phone";
            this.msk_phone.Size = new System.Drawing.Size(247, 26);
            this.msk_phone.TabIndex = 14;
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.Location = new System.Drawing.Point(158, 186);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(247, 26);
            this.txt_email.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email:";
            // 
            // btn_orderCompleted
            // 
            this.btn_orderCompleted.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_orderCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_orderCompleted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_orderCompleted.Location = new System.Drawing.Point(31, 337);
            this.btn_orderCompleted.Name = "btn_orderCompleted";
            this.btn_orderCompleted.Size = new System.Drawing.Size(1132, 29);
            this.btn_orderCompleted.TabIndex = 5;
            this.btn_orderCompleted.Text = "SİPARİŞ TAMAMLA";
            this.btn_orderCompleted.UseVisualStyleBackColor = false;
            // 
            // txt_rgs_username
            // 
            this.txt_rgs_username.Enabled = false;
            this.txt_rgs_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_rgs_username.Location = new System.Drawing.Point(158, 135);
            this.txt_rgs_username.Name = "txt_rgs_username";
            this.txt_rgs_username.Size = new System.Drawing.Size(247, 26);
            this.txt_rgs_username.TabIndex = 7;
            // 
            // txt_surname
            // 
            this.txt_surname.Enabled = false;
            this.txt_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_surname.Location = new System.Drawing.Point(158, 84);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(247, 26);
            this.txt_surname.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_name.Location = new System.Drawing.Point(158, 31);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(247, 26);
            this.txt_name.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Soyisim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "İsim:";
            // 
            // lst_orders
            // 
            this.lst_orders.FormattingEnabled = true;
            this.lst_orders.ItemHeight = 20;
            this.lst_orders.Location = new System.Drawing.Point(967, 37);
            this.lst_orders.Name = "lst_orders";
            this.lst_orders.Size = new System.Drawing.Size(196, 244);
            this.lst_orders.TabIndex = 37;
            // 
            // OrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 415);
            this.Controls.Add(this.groupBox2);
            this.Name = "OrderPanel";
            this.Text = "OrderPanel";
            this.Load += new System.EventHandler(this.OrderPanel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rch_adres;
        private System.Windows.Forms.ComboBox cmb_district;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox msk_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_orderCompleted;
        private System.Windows.Forms.TextBox txt_rgs_username;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_orders;
    }
}