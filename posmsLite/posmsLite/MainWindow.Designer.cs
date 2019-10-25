﻿namespace posmsLite
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
            this.List_region.Location = new System.Drawing.Point(351, 126);
            this.List_region.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.List_region.Name = "List_region";
            this.List_region.Size = new System.Drawing.Size(375, 38);
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
            this.List_shop.Location = new System.Drawing.Point(351, 247);
            this.List_shop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.List_shop.Name = "List_shop";
            this.List_shop.Size = new System.Drawing.Size(375, 38);
            this.List_shop.TabIndex = 1;
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
            this.Search_in_database.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search_in_database.Name = "Search_in_database";
            this.Search_in_database.Size = new System.Drawing.Size(176, 42);
            this.Search_in_database.TabIndex = 4;
            this.Search_in_database.Text = "Search";
            this.Search_in_database.UseVisualStyleBackColor = true;
            // 
            // Price_monitoring
            // 
            this.Price_monitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_monitoring.Location = new System.Drawing.Point(808, 485);
            this.Price_monitoring.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.Back_to_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back_to_login.Name = "Back_to_login";
            this.Back_to_login.Size = new System.Drawing.Size(301, 43);
            this.Back_to_login.TabIndex = 6;
            this.Back_to_login.Text = "Back in login window";
            this.Back_to_login.UseVisualStyleBackColor = true;
            this.Back_to_login.Click += new System.EventHandler(this.Back_to_login_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Back_to_login);
            this.Controls.Add(this.Price_monitoring);
            this.Controls.Add(this.Search_in_database);
            this.Controls.Add(this.Shop_label);
            this.Controls.Add(this.Region_label);
            this.Controls.Add(this.List_shop);
            this.Controls.Add(this.List_region);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
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
    }
}