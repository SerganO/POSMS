namespace posmsLite
{
    partial class MainWindow
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
            this.List_region = new System.Windows.Forms.ComboBox();
            this.List_shop = new System.Windows.Forms.ComboBox();
            this.Region_label = new System.Windows.Forms.Label();
            this.Shop_label = new System.Windows.Forms.Label();
            this.Search_in_database = new System.Windows.Forms.Button();
            this.Price_monitoring = new System.Windows.Forms.Button();
            this.Back_to_login = new System.Windows.Forms.Button();
            this.adminBox = new System.Windows.Forms.GroupBox();
            this.Name_Admin_label = new System.Windows.Forms.Label();
            this.Name_Shop_label = new System.Windows.Forms.Label();
            this.Order_goods = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.Button();
            this.quartemasterBox = new System.Windows.Forms.GroupBox();
            this.Set_prices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminBox.SuspendLayout();
            this.quartemasterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_region
            // 
            this.List_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_region.FormattingEnabled = true;
            this.List_region.Items.AddRange(new object[] {
            "Lutsk",
            "Lviv",
            "Uzhhorod",
            "Ivano-Frankivsk",
            "Ternopil",
            "Rivne",
            "Zhytomyr",
            "Khmelnytskyi",
            "Chernivtsi",
            "Vinnytsya",
            "Kyiv",
            "Cherkassy",
            "Kirovohrad",
            "Mykolayiv",
            "Odessa",
            "Kherson",
            "Zaporizhzhya",
            "Dnipropetrovsk",
            "Donetsk",
            "Luhansk",
            "Kharkiv",
            "Poltava",
            "Sumy",
            "Chernihiv",
            "Cream"});
            this.List_region.Location = new System.Drawing.Point(263, 102);
            this.List_region.Name = "List_region";
            this.List_region.Size = new System.Drawing.Size(282, 33);
            this.List_region.TabIndex = 0;
            // 
            // List_shop
            // 
            this.List_shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_shop.FormattingEnabled = true;
            this.List_shop.Items.AddRange(new object[] {
            "ATB",
            "SILPO",
            "Apelmon",
            "VARUS",
            "Brusnichka",
            "TavriaV",
            "Ashan"});
            this.List_shop.Location = new System.Drawing.Point(263, 201);
            this.List_shop.Name = "List_shop";
            this.List_shop.Size = new System.Drawing.Size(282, 33);
            this.List_shop.TabIndex = 1;
            // 
            // Region_label
            // 
            this.Region_label.AutoSize = true;
            this.Region_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Region_label.Location = new System.Drawing.Point(364, 74);
            this.Region_label.Name = "Region_label";
            this.Region_label.Size = new System.Drawing.Size(80, 25);
            this.Region_label.TabIndex = 2;
            this.Region_label.Text = "Region";
            // 
            // Shop_label
            // 
            this.Shop_label.AutoSize = true;
            this.Shop_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shop_label.Location = new System.Drawing.Point(373, 173);
            this.Shop_label.Name = "Shop_label";
            this.Shop_label.Size = new System.Drawing.Size(62, 25);
            this.Shop_label.TabIndex = 3;
            this.Shop_label.Text = "Shop";
            // 
            // Search_in_database
            // 
            this.Search_in_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_in_database.Location = new System.Drawing.Point(339, 276);
            this.Search_in_database.Name = "Search_in_database";
            this.Search_in_database.Size = new System.Drawing.Size(132, 34);
            this.Search_in_database.TabIndex = 4;
            this.Search_in_database.Text = "Search";
            this.Search_in_database.UseVisualStyleBackColor = true;
            // 
            // Price_monitoring
            // 
            this.Price_monitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_monitoring.Location = new System.Drawing.Point(606, 394);
            this.Price_monitoring.Name = "Price_monitoring";
            this.Price_monitoring.Size = new System.Drawing.Size(182, 35);
            this.Price_monitoring.TabIndex = 5;
            this.Price_monitoring.Text = "Price monitoring";
            this.Price_monitoring.UseVisualStyleBackColor = true;
            // 
            // Back_to_login
            // 
            this.Back_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_to_login.Location = new System.Drawing.Point(12, 394);
            this.Back_to_login.Name = "Back_to_login";
            this.Back_to_login.Size = new System.Drawing.Size(226, 35);
            this.Back_to_login.TabIndex = 6;
            this.Back_to_login.Text = "Back in login window";
            this.Back_to_login.UseVisualStyleBackColor = true;
            this.Back_to_login.Click += new System.EventHandler(this.Back_to_login_Click);
            // 
            // adminBox
            // 
            this.adminBox.Controls.Add(this.quartemasterBox);
            this.adminBox.Controls.Add(this.Orders);
            this.adminBox.Controls.Add(this.Order_goods);
            this.adminBox.Controls.Add(this.Name_Shop_label);
            this.adminBox.Controls.Add(this.Name_Admin_label);
            this.adminBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminBox.Location = new System.Drawing.Point(12, 12);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(171, 153);
            this.adminBox.TabIndex = 7;
            this.adminBox.TabStop = false;
            this.adminBox.Text = "Admin";
            this.adminBox.Visible = false;
            // 
            // Name_Admin_label
            // 
            this.Name_Admin_label.AutoSize = true;
            this.Name_Admin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Admin_label.Location = new System.Drawing.Point(12, 29);
            this.Name_Admin_label.Name = "Name_Admin_label";
            this.Name_Admin_label.Size = new System.Drawing.Size(109, 20);
            this.Name_Admin_label.TabIndex = 0;
            this.Name_Admin_label.Text = "Zybenko M. P.";
            // 
            // Name_Shop_label
            // 
            this.Name_Shop_label.AutoSize = true;
            this.Name_Shop_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Shop_label.Location = new System.Drawing.Point(12, 53);
            this.Name_Shop_label.Name = "Name_Shop_label";
            this.Name_Shop_label.Size = new System.Drawing.Size(40, 20);
            this.Name_Shop_label.TabIndex = 1;
            this.Name_Shop_label.Text = "ATB";
            // 
            // Order_goods
            // 
            this.Order_goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order_goods.Location = new System.Drawing.Point(6, 76);
            this.Order_goods.Name = "Order_goods";
            this.Order_goods.Size = new System.Drawing.Size(159, 32);
            this.Order_goods.TabIndex = 2;
            this.Order_goods.Text = "Order goods";
            this.Order_goods.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            this.Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orders.Location = new System.Drawing.Point(6, 114);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(159, 32);
            this.Orders.TabIndex = 3;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // quartemasterBox
            // 
            this.quartemasterBox.Controls.Add(this.Set_prices);
            this.quartemasterBox.Controls.Add(this.label1);
            this.quartemasterBox.Controls.Add(this.label2);
            this.quartemasterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quartemasterBox.Location = new System.Drawing.Point(0, 0);
            this.quartemasterBox.Name = "quartemasterBox";
            this.quartemasterBox.Size = new System.Drawing.Size(171, 116);
            this.quartemasterBox.TabIndex = 8;
            this.quartemasterBox.TabStop = false;
            this.quartemasterBox.Text = "Quartemaster";
            this.quartemasterBox.Visible = false;
            // 
            // Set_prices
            // 
            this.Set_prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Set_prices.Location = new System.Drawing.Point(6, 76);
            this.Set_prices.Name = "Set_prices";
            this.Set_prices.Size = new System.Drawing.Size(159, 32);
            this.Set_prices.TabIndex = 2;
            this.Set_prices.Text = "Set prices";
            this.Set_prices.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Zybenko M. P.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminBox);
            this.Controls.Add(this.Back_to_login);
            this.Controls.Add(this.Price_monitoring);
            this.Controls.Add(this.Search_in_database);
            this.Controls.Add(this.Shop_label);
            this.Controls.Add(this.Region_label);
            this.Controls.Add(this.List_shop);
            this.Controls.Add(this.List_region);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.adminBox.ResumeLayout(false);
            this.adminBox.PerformLayout();
            this.quartemasterBox.ResumeLayout(false);
            this.quartemasterBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox List_region;
        private System.Windows.Forms.ComboBox List_shop;
        private System.Windows.Forms.Label Region_label;
        private System.Windows.Forms.Label Shop_label;
        private System.Windows.Forms.Button Search_in_database;
        private System.Windows.Forms.Button Price_monitoring;
        private System.Windows.Forms.Button Back_to_login;
        private System.Windows.Forms.GroupBox adminBox;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button Order_goods;
        private System.Windows.Forms.Label Name_Shop_label;
        private System.Windows.Forms.Label Name_Admin_label;
        private System.Windows.Forms.GroupBox quartemasterBox;
        private System.Windows.Forms.Button Set_prices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}