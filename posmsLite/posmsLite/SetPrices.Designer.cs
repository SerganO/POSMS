namespace posmsLite
{
    partial class SetPrices
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
            this.Back_in_main_window = new System.Windows.Forms.Button();
            this.List_price_goods = new System.Windows.Forms.DataGridView();
            this.Shop_region_info_label = new System.Windows.Forms.Label();
            this.Shop_name_label = new System.Windows.Forms.Label();
            this.Update_prices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.List_price_goods)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_in_main_window
            // 
            this.Back_in_main_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_in_main_window.Location = new System.Drawing.Point(711, 11);
            this.Back_in_main_window.Name = "Back_in_main_window";
            this.Back_in_main_window.Size = new System.Drawing.Size(78, 39);
            this.Back_in_main_window.TabIndex = 7;
            this.Back_in_main_window.Text = "Back";
            this.Back_in_main_window.UseVisualStyleBackColor = true;
            // 
            // List_price_goods
            // 
            this.List_price_goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_price_goods.Location = new System.Drawing.Point(12, 94);
            this.List_price_goods.Name = "List_price_goods";
            this.List_price_goods.Size = new System.Drawing.Size(777, 346);
            this.List_price_goods.TabIndex = 6;
            // 
            // Shop_region_info_label
            // 
            this.Shop_region_info_label.AutoSize = true;
            this.Shop_region_info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shop_region_info_label.Location = new System.Drawing.Point(16, 67);
            this.Shop_region_info_label.Name = "Shop_region_info_label";
            this.Shop_region_info_label.Size = new System.Drawing.Size(211, 24);
            this.Shop_region_info_label.TabIndex = 5;
            this.Shop_region_info_label.Text = "Shop region information";
            // 
            // Shop_name_label
            // 
            this.Shop_name_label.AutoSize = true;
            this.Shop_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shop_name_label.Location = new System.Drawing.Point(13, 11);
            this.Shop_name_label.Name = "Shop_name_label";
            this.Shop_name_label.Size = new System.Drawing.Size(193, 39);
            this.Shop_name_label.TabIndex = 4;
            this.Shop_name_label.Text = "Shop name";
            // 
            // Update_prices
            // 
            this.Update_prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_prices.Location = new System.Drawing.Point(545, 11);
            this.Update_prices.Name = "Update_prices";
            this.Update_prices.Size = new System.Drawing.Size(90, 39);
            this.Update_prices.TabIndex = 8;
            this.Update_prices.Text = "Update";
            this.Update_prices.UseVisualStyleBackColor = true;
            // 
            // SetPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update_prices);
            this.Controls.Add(this.Back_in_main_window);
            this.Controls.Add(this.List_price_goods);
            this.Controls.Add(this.Shop_region_info_label);
            this.Controls.Add(this.Shop_name_label);
            this.Name = "SetPrices";
            this.Text = "Set prices Window";
            ((System.ComponentModel.ISupportInitialize)(this.List_price_goods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_in_main_window;
        private System.Windows.Forms.DataGridView List_price_goods;
        private System.Windows.Forms.Label Shop_region_info_label;
        private System.Windows.Forms.Label Shop_name_label;
        private System.Windows.Forms.Button Update_prices;
    }
}