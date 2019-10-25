namespace posmsLite
{
    partial class PriceMonitoringWindow
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
            this.Region_label = new System.Windows.Forms.Label();
            this.List_region = new System.Windows.Forms.ComboBox();
            this.List_goods = new System.Windows.Forms.ComboBox();
            this.Goods_label = new System.Windows.Forms.Label();
            this.Search_in_database = new System.Windows.Forms.Button();
            this.Back_in_main_window = new System.Windows.Forms.Button();
            this.List_good_in_shops = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.List_good_in_shops)).BeginInit();
            this.SuspendLayout();
            // 
            // Region_label
            // 
            this.Region_label.AutoSize = true;
            this.Region_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Region_label.Location = new System.Drawing.Point(81, 9);
            this.Region_label.Name = "Region_label";
            this.Region_label.Size = new System.Drawing.Size(60, 20);
            this.Region_label.TabIndex = 4;
            this.Region_label.Text = "Region";
            // 
            // List_region
            // 
            this.List_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.List_region.Location = new System.Drawing.Point(12, 32);
            this.List_region.Name = "List_region";
            this.List_region.Size = new System.Drawing.Size(215, 28);
            this.List_region.TabIndex = 3;
            // 
            // List_goods
            // 
            this.List_goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_goods.FormattingEnabled = true;
            this.List_goods.Items.AddRange(new object[] {
            "Bread",
            "Fish",
            "Soap",
            "Toilet paper",
            "Cake",
            "Instant noodles",
            "Chease",
            "Meat",
            "Tea",
            "Salt",
            "Sugar",
            "Water",
            "Egg",
            "Butter"});
            this.List_goods.Location = new System.Drawing.Point(245, 32);
            this.List_goods.Name = "List_goods";
            this.List_goods.Size = new System.Drawing.Size(172, 28);
            this.List_goods.TabIndex = 5;
            // 
            // Goods_label
            // 
            this.Goods_label.AutoSize = true;
            this.Goods_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Goods_label.Location = new System.Drawing.Point(310, 9);
            this.Goods_label.Name = "Goods_label";
            this.Goods_label.Size = new System.Drawing.Size(57, 20);
            this.Goods_label.TabIndex = 6;
            this.Goods_label.Text = "Goods";
            // 
            // Search_in_database
            // 
            this.Search_in_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_in_database.Location = new System.Drawing.Point(436, 32);
            this.Search_in_database.Name = "Search_in_database";
            this.Search_in_database.Size = new System.Drawing.Size(82, 28);
            this.Search_in_database.TabIndex = 7;
            this.Search_in_database.Text = "Search";
            this.Search_in_database.UseVisualStyleBackColor = true;
            // 
            // Back_in_main_window
            // 
            this.Back_in_main_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_in_main_window.Location = new System.Drawing.Point(710, 30);
            this.Back_in_main_window.Name = "Back_in_main_window";
            this.Back_in_main_window.Size = new System.Drawing.Size(78, 28);
            this.Back_in_main_window.TabIndex = 8;
            this.Back_in_main_window.Text = "Back";
            this.Back_in_main_window.UseVisualStyleBackColor = true;
            // 
            // List_good_in_shops
            // 
            this.List_good_in_shops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_good_in_shops.Location = new System.Drawing.Point(12, 78);
            this.List_good_in_shops.Name = "List_good_in_shops";
            this.List_good_in_shops.Size = new System.Drawing.Size(776, 360);
            this.List_good_in_shops.TabIndex = 9;
            // 
            // PriceMonitoringWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.List_good_in_shops);
            this.Controls.Add(this.Back_in_main_window);
            this.Controls.Add(this.Search_in_database);
            this.Controls.Add(this.Goods_label);
            this.Controls.Add(this.List_goods);
            this.Controls.Add(this.Region_label);
            this.Controls.Add(this.List_region);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PriceMonitoringWindow";
            this.Text = "Price Monitoring Window";
            ((System.ComponentModel.ISupportInitialize)(this.List_good_in_shops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Region_label;
        private System.Windows.Forms.ComboBox List_region;
        private System.Windows.Forms.ComboBox List_goods;
        private System.Windows.Forms.Label Goods_label;
        private System.Windows.Forms.Button Search_in_database;
        private System.Windows.Forms.Button Back_in_main_window;
        private System.Windows.Forms.DataGridView List_good_in_shops;
    }
}