﻿namespace posmsLite
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
            ((System.ComponentModel.ISupportInitialize)(this.List_shop_goods)).BeginInit();
            this.SuspendLayout();
            // 
            // Shop_name_label
            // 
            this.Shop_name_label.AutoSize = true;
            this.Shop_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shop_name_label.Location = new System.Drawing.Point(12, 9);
            this.Shop_name_label.Name = "Shop_name_label";
            this.Shop_name_label.Size = new System.Drawing.Size(193, 39);
            this.Shop_name_label.TabIndex = 0;
            this.Shop_name_label.Text = "Shop name";
            // 
            // Shop_region_info_label
            // 
            this.Shop_region_info_label.AutoSize = true;
            this.Shop_region_info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shop_region_info_label.Location = new System.Drawing.Point(15, 65);
            this.Shop_region_info_label.Name = "Shop_region_info_label";
            this.Shop_region_info_label.Size = new System.Drawing.Size(211, 24);
            this.Shop_region_info_label.TabIndex = 1;
            this.Shop_region_info_label.Text = "Shop region information";
            // 
            // List_shop_goods
            // 
            this.List_shop_goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_shop_goods.Location = new System.Drawing.Point(11, 92);
            this.List_shop_goods.Name = "List_shop_goods";
            this.List_shop_goods.Size = new System.Drawing.Size(777, 346);
            this.List_shop_goods.TabIndex = 2;
            // 
            // Back_in_main_window
            // 
            this.Back_in_main_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_in_main_window.Location = new System.Drawing.Point(710, 9);
            this.Back_in_main_window.Name = "Back_in_main_window";
            this.Back_in_main_window.Size = new System.Drawing.Size(78, 39);
            this.Back_in_main_window.TabIndex = 3;
            this.Back_in_main_window.Text = "Back";
            this.Back_in_main_window.UseVisualStyleBackColor = true;
            // 
            // ShopInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_in_main_window);
            this.Controls.Add(this.List_shop_goods);
            this.Controls.Add(this.Shop_region_info_label);
            this.Controls.Add(this.Shop_name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    }
}