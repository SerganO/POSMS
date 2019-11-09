namespace posmsLite
{
    partial class ShopInfo
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
            this.Shop_name_label = new System.Windows.Forms.Label();
            this.Shop_region_info_label = new System.Windows.Forms.Label();
            this.List_shop_goods = new System.Windows.Forms.DataGridView();
            this.Back_in_main_window = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.List_shop_goods)).BeginInit();
            this.SuspendLayout();
            // 
            // Shop_name_label
            // 
            this.Shop_name_label.AutoSize = true;
            this.Shop_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shop_name_label.Location = new System.Drawing.Point(16, 11);
            this.Shop_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Shop_name_label.Name = "Shop_name_label";
            this.Shop_name_label.Size = new System.Drawing.Size(245, 52);
            this.Shop_name_label.TabIndex = 0;
            this.Shop_name_label.Text = "Shop name";
            // 
            // Shop_region_info_label
            // 
            this.Shop_region_info_label.AutoSize = true;
            this.Shop_region_info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shop_region_info_label.Location = new System.Drawing.Point(20, 80);
            this.Shop_region_info_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Shop_region_info_label.Name = "Shop_region_info_label";
            this.Shop_region_info_label.Size = new System.Drawing.Size(270, 29);
            this.Shop_region_info_label.TabIndex = 1;
            this.Shop_region_info_label.Text = "Shop region information";
            // 
            // List_shop_goods
            // 
            this.List_shop_goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_shop_goods.Location = new System.Drawing.Point(15, 113);
            this.List_shop_goods.Margin = new System.Windows.Forms.Padding(4);
            this.List_shop_goods.Name = "List_shop_goods";
            this.List_shop_goods.ReadOnly = true;
            this.List_shop_goods.Size = new System.Drawing.Size(1036, 426);
            this.List_shop_goods.TabIndex = 2;
            // 
            // Back_in_main_window
            // 
            this.Back_in_main_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_in_main_window.Location = new System.Drawing.Point(947, 11);
            this.Back_in_main_window.Margin = new System.Windows.Forms.Padding(4);
            this.Back_in_main_window.Name = "Back_in_main_window";
            this.Back_in_main_window.Size = new System.Drawing.Size(104, 48);
            this.Back_in_main_window.TabIndex = 3;
            this.Back_in_main_window.Text = "Back";
            this.Back_in_main_window.UseVisualStyleBackColor = true;
            this.Back_in_main_window.Click += new System.EventHandler(this.Back_in_main_window_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.categoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "All",
            "Milk",
            "Bakery",
            "Household Сhemicals",
            "Meat",
            "Fish",
            "Cereals",
            "Pasta",
            "Fruit",
            "Vegetables",
            "Grocery"});
            this.categoryComboBox.Location = new System.Drawing.Point(647, 80);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(296, 24);
            this.categoryComboBox.TabIndex = 4;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(961, 80);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(789, 57);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(65, 17);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.Click += new System.EventHandler(this.categoryLabel_Click);
            // 
            // ShopInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.Back_in_main_window);
            this.Controls.Add(this.List_shop_goods);
            this.Controls.Add(this.Shop_region_info_label);
            this.Controls.Add(this.Shop_name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShopInfo";
            this.Text = "Shop Information";
            ((System.ComponentModel.ISupportInitialize)(this.List_shop_goods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Shop_name_label;
        private System.Windows.Forms.Label Shop_region_info_label;
        private System.Windows.Forms.DataGridView List_shop_goods;
        private System.Windows.Forms.Button Back_in_main_window;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label categoryLabel;
    }
}