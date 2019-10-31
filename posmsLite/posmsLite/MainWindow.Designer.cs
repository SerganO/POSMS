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
            this.quartermasterBox = new System.Windows.Forms.GroupBox();
            this.Orders = new System.Windows.Forms.Button();
            this.Order_goods = new System.Windows.Forms.Button();
            this.Name_Shop_label = new System.Windows.Forms.Label();
            this.Name_Quarter_label = new System.Windows.Forms.Label();
            this.adminBox = new System.Windows.Forms.GroupBox();
            this.Set_prices = new System.Windows.Forms.Button();
            this.Name_Admin_Shop_label = new System.Windows.Forms.Label();
            this.Name_Admin_Label = new System.Windows.Forms.Label();
            this.Shop = new System.Windows.Forms.Button();
            this.QShop = new System.Windows.Forms.Button();
            this.quartermasterBox.SuspendLayout();
            this.adminBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_region
            // 
            this.List_region.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.List_region.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.List_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            "Vinnytsia",
            "Kyiv",
            "Cherkasy",
            "Kropyvnytskyi",
            "Mykolaiv",
            "Odesa",
            "Kherson",
            "Zaporizhzhia",
            "Dnipro",
            "Donetsk",
            "Luhansk",
            "Kharkiv",
            "Poltava",
            "Sumy",
            "Chernihiv",
            "Crimea"});
            this.List_region.Location = new System.Drawing.Point(351, 126);
            this.List_region.Margin = new System.Windows.Forms.Padding(4);
            this.List_region.Name = "List_region";
            this.List_region.Size = new System.Drawing.Size(375, 38);
            this.List_region.TabIndex = 0;
            this.List_region.SelectedIndexChanged += new System.EventHandler(this.List_region_SelectedIndexChanged);
            // 
            // List_shop
            // 
            this.List_shop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.List_shop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.List_shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_shop.FormattingEnabled = true;
            this.List_shop.Location = new System.Drawing.Point(351, 247);
            this.List_shop.Margin = new System.Windows.Forms.Padding(4);
            this.List_shop.Name = "List_shop";
            this.List_shop.Size = new System.Drawing.Size(375, 38);
            this.List_shop.TabIndex = 1;
            this.List_shop.SelectedIndexChanged += new System.EventHandler(this.List_shop_SelectedIndexChanged);
            // 
            // Region_label
            // 
            this.Region_label.AutoSize = true;
            this.Region_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Region_label.Location = new System.Drawing.Point(485, 91);
            this.Region_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Region_label.Name = "Region_label";
            this.Region_label.Size = new System.Drawing.Size(100, 31);
            this.Region_label.TabIndex = 2;
            this.Region_label.Text = "Region";
            // 
            // Shop_label
            // 
            this.Shop_label.AutoSize = true;
            this.Shop_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shop_label.Location = new System.Drawing.Point(497, 213);
            this.Shop_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Shop_label.Name = "Shop_label";
            this.Shop_label.Size = new System.Drawing.Size(77, 31);
            this.Shop_label.TabIndex = 3;
            this.Shop_label.Text = "Shop";
            // 
            // Search_in_database
            // 
            this.Search_in_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_in_database.Location = new System.Drawing.Point(452, 340);
            this.Search_in_database.Margin = new System.Windows.Forms.Padding(4);
            this.Search_in_database.Name = "Search_in_database";
            this.Search_in_database.Size = new System.Drawing.Size(176, 42);
            this.Search_in_database.TabIndex = 4;
            this.Search_in_database.Text = "Search";
            this.Search_in_database.UseVisualStyleBackColor = true;
            this.Search_in_database.Click += new System.EventHandler(this.Search_in_database_Click);
            // 
            // Price_monitoring
            // 
            this.Price_monitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_monitoring.Location = new System.Drawing.Point(808, 485);
            this.Price_monitoring.Margin = new System.Windows.Forms.Padding(4);
            this.Price_monitoring.Name = "Price_monitoring";
            this.Price_monitoring.Size = new System.Drawing.Size(243, 43);
            this.Price_monitoring.TabIndex = 5;
            this.Price_monitoring.Text = "Price monitoring";
            this.Price_monitoring.UseVisualStyleBackColor = true;
            // 
            // Back_to_login
            // 
            this.Back_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_to_login.Location = new System.Drawing.Point(16, 485);
            this.Back_to_login.Margin = new System.Windows.Forms.Padding(4);
            this.Back_to_login.Name = "Back_to_login";
            this.Back_to_login.Size = new System.Drawing.Size(301, 43);
            this.Back_to_login.TabIndex = 6;
            this.Back_to_login.Text = "Back in login window";
            this.Back_to_login.UseVisualStyleBackColor = true;
            this.Back_to_login.Click += new System.EventHandler(this.Back_to_login_Click);
            // 
            // quartermasterBox
            // 
            this.quartermasterBox.Controls.Add(this.QShop);
            this.quartermasterBox.Controls.Add(this.Orders);
            this.quartermasterBox.Controls.Add(this.Order_goods);
            this.quartermasterBox.Controls.Add(this.Name_Shop_label);
            this.quartermasterBox.Controls.Add(this.Name_Quarter_label);
            this.quartermasterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quartermasterBox.Location = new System.Drawing.Point(16, 15);
            this.quartermasterBox.Margin = new System.Windows.Forms.Padding(4);
            this.quartermasterBox.Name = "quartermasterBox";
            this.quartermasterBox.Padding = new System.Windows.Forms.Padding(4);
            this.quartermasterBox.Size = new System.Drawing.Size(228, 242);
            this.quartermasterBox.TabIndex = 7;
            this.quartermasterBox.TabStop = false;
            this.quartermasterBox.Text = "Quartermaster";
            this.quartermasterBox.Visible = false;
            // 
            // Orders
            // 
            this.Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orders.Location = new System.Drawing.Point(8, 140);
            this.Orders.Margin = new System.Windows.Forms.Padding(4);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(212, 39);
            this.Orders.TabIndex = 3;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // Order_goods
            // 
            this.Order_goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order_goods.Location = new System.Drawing.Point(8, 94);
            this.Order_goods.Margin = new System.Windows.Forms.Padding(4);
            this.Order_goods.Name = "Order_goods";
            this.Order_goods.Size = new System.Drawing.Size(212, 39);
            this.Order_goods.TabIndex = 2;
            this.Order_goods.Text = "Order goods";
            this.Order_goods.UseVisualStyleBackColor = true;
            this.Order_goods.Click += new System.EventHandler(this.Order_goods_Click);
            // 
            // Name_Shop_label
            // 
            this.Name_Shop_label.AutoSize = true;
            this.Name_Shop_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Shop_label.Location = new System.Drawing.Point(16, 65);
            this.Name_Shop_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Shop_label.Name = "Name_Shop_label";
            this.Name_Shop_label.Size = new System.Drawing.Size(52, 25);
            this.Name_Shop_label.TabIndex = 1;
            this.Name_Shop_label.Text = "ATB";
            // 
            // Name_Quarter_label
            // 
            this.Name_Quarter_label.AutoSize = true;
            this.Name_Quarter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Quarter_label.Location = new System.Drawing.Point(16, 36);
            this.Name_Quarter_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Quarter_label.Name = "Name_Quarter_label";
            this.Name_Quarter_label.Size = new System.Drawing.Size(138, 25);
            this.Name_Quarter_label.TabIndex = 0;
            this.Name_Quarter_label.Text = "Zybenko M. P.";
            // 
            // adminBox
            // 
            this.adminBox.Controls.Add(this.Shop);
            this.adminBox.Controls.Add(this.Set_prices);
            this.adminBox.Controls.Add(this.Name_Admin_Shop_label);
            this.adminBox.Controls.Add(this.Name_Admin_Label);
            this.adminBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminBox.Location = new System.Drawing.Point(16, 15);
            this.adminBox.Margin = new System.Windows.Forms.Padding(4);
            this.adminBox.Name = "adminBox";
            this.adminBox.Padding = new System.Windows.Forms.Padding(4);
            this.adminBox.Size = new System.Drawing.Size(228, 186);
            this.adminBox.TabIndex = 8;
            this.adminBox.TabStop = false;
            this.adminBox.Text = "Admin";
            this.adminBox.Visible = false;
            // 
            // Set_prices
            // 
            this.Set_prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Set_prices.Location = new System.Drawing.Point(8, 94);
            this.Set_prices.Margin = new System.Windows.Forms.Padding(4);
            this.Set_prices.Name = "Set_prices";
            this.Set_prices.Size = new System.Drawing.Size(212, 39);
            this.Set_prices.TabIndex = 2;
            this.Set_prices.Text = "Set prices";
            this.Set_prices.UseVisualStyleBackColor = true;
            this.Set_prices.Click += new System.EventHandler(this.Set_prices_Click);
            // 
            // Name_Admin_Shop_label
            // 
            this.Name_Admin_Shop_label.AutoSize = true;
            this.Name_Admin_Shop_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Admin_Shop_label.Location = new System.Drawing.Point(16, 65);
            this.Name_Admin_Shop_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Admin_Shop_label.Name = "Name_Admin_Shop_label";
            this.Name_Admin_Shop_label.Size = new System.Drawing.Size(52, 25);
            this.Name_Admin_Shop_label.TabIndex = 1;
            this.Name_Admin_Shop_label.Text = "ATB";
            // 
            // Name_Admin_Label
            // 
            this.Name_Admin_Label.AutoSize = true;
            this.Name_Admin_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Admin_Label.Location = new System.Drawing.Point(16, 36);
            this.Name_Admin_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Admin_Label.Name = "Name_Admin_Label";
            this.Name_Admin_Label.Size = new System.Drawing.Size(138, 25);
            this.Name_Admin_Label.TabIndex = 0;
            this.Name_Admin_Label.Text = "Zybenko M. P.";
            // 
            // Shop
            // 
            this.Shop.Location = new System.Drawing.Point(7, 140);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(212, 40);
            this.Shop.TabIndex = 3;
            this.Shop.Text = "Shop";
            this.Shop.UseVisualStyleBackColor = true;
            this.Shop.Click += new System.EventHandler(this.Shop_Click);
            // 
            // QShop
            // 
            this.QShop.Location = new System.Drawing.Point(7, 186);
            this.QShop.Name = "QShop";
            this.QShop.Size = new System.Drawing.Size(212, 40);
            this.QShop.TabIndex = 4;
            this.QShop.Text = "Shop";
            this.QShop.UseVisualStyleBackColor = true;
            this.QShop.Click += new System.EventHandler(this.QShop_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.adminBox);
            this.Controls.Add(this.quartermasterBox);
            this.Controls.Add(this.Back_to_login);
            this.Controls.Add(this.Price_monitoring);
            this.Controls.Add(this.Search_in_database);
            this.Controls.Add(this.Shop_label);
            this.Controls.Add(this.Region_label);
            this.Controls.Add(this.List_shop);
            this.Controls.Add(this.List_region);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.quartermasterBox.ResumeLayout(false);
            this.quartermasterBox.PerformLayout();
            this.adminBox.ResumeLayout(false);
            this.adminBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox quartermasterBox;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button Order_goods;
        private System.Windows.Forms.Label Name_Shop_label;
        private System.Windows.Forms.Label Name_Quarter_label;
        private System.Windows.Forms.GroupBox adminBox;
        private System.Windows.Forms.Button Set_prices;
        private System.Windows.Forms.Label Name_Admin_Shop_label;
        private System.Windows.Forms.Label Name_Admin_Label;
        private System.Windows.Forms.Button QShop;
        private System.Windows.Forms.Button Shop;
    }
}