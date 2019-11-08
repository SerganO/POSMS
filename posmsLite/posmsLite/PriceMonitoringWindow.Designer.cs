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
            this.Goods_label = new System.Windows.Forms.Label();
            this.Search_in_database = new System.Windows.Forms.Button();
            this.Back_in_main_window = new System.Windows.Forms.Button();
            this.List_good_in_shops = new System.Windows.Forms.DataGridView();
            this.List_region = new System.Windows.Forms.ComboBox();
            this.goodTextBox = new System.Windows.Forms.TextBox();
            this.sortByAscendingButton = new System.Windows.Forms.Button();
            this.sortByDescendingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.List_good_in_shops)).BeginInit();
            this.SuspendLayout();
            // 
            // Region_label
            // 
            this.Region_label.AutoSize = true;
            this.Region_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Region_label.Location = new System.Drawing.Point(108, 11);
            this.Region_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Region_label.Name = "Region_label";
            this.Region_label.Size = new System.Drawing.Size(73, 25);
            this.Region_label.TabIndex = 4;
            this.Region_label.Text = "Region";
            // 
            // Goods_label
            // 
            this.Goods_label.AutoSize = true;
            this.Goods_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Goods_label.Location = new System.Drawing.Point(413, 11);
            this.Goods_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Goods_label.Name = "Goods_label";
            this.Goods_label.Size = new System.Drawing.Size(70, 25);
            this.Goods_label.TabIndex = 6;
            this.Goods_label.Text = "Goods";
            // 
            // Search_in_database
            // 
            this.Search_in_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_in_database.Location = new System.Drawing.Point(581, 39);
            this.Search_in_database.Margin = new System.Windows.Forms.Padding(4);
            this.Search_in_database.Name = "Search_in_database";
            this.Search_in_database.Size = new System.Drawing.Size(109, 34);
            this.Search_in_database.TabIndex = 7;
            this.Search_in_database.Text = "Search";
            this.Search_in_database.UseVisualStyleBackColor = true;
            this.Search_in_database.Click += new System.EventHandler(this.Search_in_database_Click);
            // 
            // Back_in_main_window
            // 
            this.Back_in_main_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_in_main_window.Location = new System.Drawing.Point(947, 37);
            this.Back_in_main_window.Margin = new System.Windows.Forms.Padding(4);
            this.Back_in_main_window.Name = "Back_in_main_window";
            this.Back_in_main_window.Size = new System.Drawing.Size(104, 34);
            this.Back_in_main_window.TabIndex = 8;
            this.Back_in_main_window.Text = "Back";
            this.Back_in_main_window.UseVisualStyleBackColor = true;
            this.Back_in_main_window.Click += new System.EventHandler(this.Back_in_main_window_Click);
            // 
            // List_good_in_shops
            // 
            this.List_good_in_shops.AllowUserToAddRows = false;
            this.List_good_in_shops.AllowUserToDeleteRows = false;
            this.List_good_in_shops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_good_in_shops.Location = new System.Drawing.Point(16, 96);
            this.List_good_in_shops.Margin = new System.Windows.Forms.Padding(4);
            this.List_good_in_shops.Name = "List_good_in_shops";
            this.List_good_in_shops.ReadOnly = true;
            this.List_good_in_shops.Size = new System.Drawing.Size(1035, 443);
            this.List_good_in_shops.TabIndex = 9;
            // 
            // List_region
            // 
            this.List_region.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.List_region.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.List_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.List_region.Location = new System.Drawing.Point(40, 37);
            this.List_region.Margin = new System.Windows.Forms.Padding(4);
            this.List_region.Name = "List_region";
            this.List_region.Size = new System.Drawing.Size(228, 33);
            this.List_region.TabIndex = 10;
            this.List_region.SelectedIndexChanged += new System.EventHandler(this.List_region_SelectedIndexChanged);
            // 
            // goodTextBox
            // 
            this.goodTextBox.Location = new System.Drawing.Point(332, 47);
            this.goodTextBox.Name = "goodTextBox";
            this.goodTextBox.Size = new System.Drawing.Size(242, 22);
            this.goodTextBox.TabIndex = 11;
            // 
            // sortByAscendingButton
            // 
            this.sortByAscendingButton.Location = new System.Drawing.Point(746, 47);
            this.sortByAscendingButton.Name = "sortByAscendingButton";
            this.sortByAscendingButton.Size = new System.Drawing.Size(75, 23);
            this.sortByAscendingButton.TabIndex = 12;
            this.sortByAscendingButton.Text = "Sort V";
            this.sortByAscendingButton.UseVisualStyleBackColor = true;
            this.sortByAscendingButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // sortByDescendingButton
            // 
            this.sortByDescendingButton.Location = new System.Drawing.Point(848, 47);
            this.sortByDescendingButton.Name = "sortByDescendingButton";
            this.sortByDescendingButton.Size = new System.Drawing.Size(75, 23);
            this.sortByDescendingButton.TabIndex = 13;
            this.sortByDescendingButton.Text = "Sort ^";
            this.sortByDescendingButton.UseVisualStyleBackColor = true;
            this.sortByDescendingButton.Click += new System.EventHandler(this.sortByDescendingButton_Click);
            // 
            // PriceMonitoringWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.sortByDescendingButton);
            this.Controls.Add(this.sortByAscendingButton);
            this.Controls.Add(this.goodTextBox);
            this.Controls.Add(this.List_region);
            this.Controls.Add(this.List_good_in_shops);
            this.Controls.Add(this.Back_in_main_window);
            this.Controls.Add(this.Search_in_database);
            this.Controls.Add(this.Goods_label);
            this.Controls.Add(this.Region_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PriceMonitoringWindow";
            this.Text = "Price Monitoring Window";
            ((System.ComponentModel.ISupportInitialize)(this.List_good_in_shops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Region_label;
        private System.Windows.Forms.Label Goods_label;
        private System.Windows.Forms.Button Search_in_database;
        private System.Windows.Forms.Button Back_in_main_window;
        private System.Windows.Forms.DataGridView List_good_in_shops;
        private System.Windows.Forms.ComboBox List_region;
        private System.Windows.Forms.TextBox goodTextBox;
        private System.Windows.Forms.Button sortByAscendingButton;
        private System.Windows.Forms.Button sortByDescendingButton;
    }
}