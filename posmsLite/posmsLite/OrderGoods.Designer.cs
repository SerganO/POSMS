﻿namespace posmsLite
{
    partial class OrderGoods
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
            this.List_order_goods = new System.Windows.Forms.DataGridView();
            this.Add_good = new System.Windows.Forms.Button();
            this.Change_quantity_good = new System.Windows.Forms.Button();
            this.Delete_good = new System.Windows.Forms.Button();
            this.Back_in_main_window = new System.Windows.Forms.Button();
            this.Confirm_order = new System.Windows.Forms.Button();
            this.Price_all_goods = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.List_order_goods)).BeginInit();
            this.SuspendLayout();
            // 
            // List_order_goods
            // 
            this.List_order_goods.AllowUserToAddRows = false;
            this.List_order_goods.AllowUserToDeleteRows = false;
            this.List_order_goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_order_goods.Location = new System.Drawing.Point(16, 15);
            this.List_order_goods.Margin = new System.Windows.Forms.Padding(4);
            this.List_order_goods.Name = "List_order_goods";
            this.List_order_goods.Size = new System.Drawing.Size(911, 458);
            this.List_order_goods.TabIndex = 0;
            this.List_order_goods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.List_order_goods_CellEndEdit);
            this.List_order_goods.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.List_order_goods_DataError);
            // 
            // Add_good
            // 
            this.Add_good.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_good.Location = new System.Drawing.Point(935, 79);
            this.Add_good.Margin = new System.Windows.Forms.Padding(4);
            this.Add_good.Name = "Add_good";
            this.Add_good.Size = new System.Drawing.Size(116, 41);
            this.Add_good.TabIndex = 1;
            this.Add_good.Text = "Add";
            this.Add_good.UseVisualStyleBackColor = true;
            this.Add_good.Click += new System.EventHandler(this.Add_good_Click);
            // 
            // Change_quantity_good
            // 
            this.Change_quantity_good.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_quantity_good.Location = new System.Drawing.Point(935, 159);
            this.Change_quantity_good.Margin = new System.Windows.Forms.Padding(4);
            this.Change_quantity_good.Name = "Change_quantity_good";
            this.Change_quantity_good.Size = new System.Drawing.Size(116, 41);
            this.Change_quantity_good.TabIndex = 2;
            this.Change_quantity_good.Text = "Change";
            this.Change_quantity_good.UseVisualStyleBackColor = true;
            this.Change_quantity_good.Click += new System.EventHandler(this.Change_quantity_good_Click);
            // 
            // Delete_good
            // 
            this.Delete_good.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_good.Location = new System.Drawing.Point(935, 238);
            this.Delete_good.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_good.Name = "Delete_good";
            this.Delete_good.Size = new System.Drawing.Size(116, 41);
            this.Delete_good.TabIndex = 3;
            this.Delete_good.Text = "Delete";
            this.Delete_good.UseVisualStyleBackColor = true;
            this.Delete_good.Click += new System.EventHandler(this.Delete_good_Click);
            // 
            // Back_in_main_window
            // 
            this.Back_in_main_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_in_main_window.Location = new System.Drawing.Point(16, 498);
            this.Back_in_main_window.Margin = new System.Windows.Forms.Padding(4);
            this.Back_in_main_window.Name = "Back_in_main_window";
            this.Back_in_main_window.Size = new System.Drawing.Size(100, 41);
            this.Back_in_main_window.TabIndex = 4;
            this.Back_in_main_window.Text = "Back";
            this.Back_in_main_window.UseVisualStyleBackColor = true;
            this.Back_in_main_window.Click += new System.EventHandler(this.Back_in_main_window_Click);
            // 
            // Confirm_order
            // 
            this.Confirm_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Confirm_order.Location = new System.Drawing.Point(863, 498);
            this.Confirm_order.Margin = new System.Windows.Forms.Padding(4);
            this.Confirm_order.Name = "Confirm_order";
            this.Confirm_order.Size = new System.Drawing.Size(188, 41);
            this.Confirm_order.TabIndex = 5;
            this.Confirm_order.Text = "Confirm order";
            this.Confirm_order.UseVisualStyleBackColor = true;
            this.Confirm_order.Click += new System.EventHandler(this.Confirm_order_Click);
            // 
            // Price_all_goods
            // 
            this.Price_all_goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_all_goods.Location = new System.Drawing.Point(586, 503);
            this.Price_all_goods.Margin = new System.Windows.Forms.Padding(4);
            this.Price_all_goods.Name = "Price_all_goods";
            this.Price_all_goods.ReadOnly = true;
            this.Price_all_goods.Size = new System.Drawing.Size(230, 34);
            this.Price_all_goods.TabIndex = 6;
            // 
            // OrderGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Price_all_goods);
            this.Controls.Add(this.Confirm_order);
            this.Controls.Add(this.Back_in_main_window);
            this.Controls.Add(this.Delete_good);
            this.Controls.Add(this.Change_quantity_good);
            this.Controls.Add(this.Add_good);
            this.Controls.Add(this.List_order_goods);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderGoods";
            this.Text = "Order goods Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderGoods_FormClosing);
            this.Load += new System.EventHandler(this.OrderGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List_order_goods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView List_order_goods;
        private System.Windows.Forms.Button Add_good;
        private System.Windows.Forms.Button Change_quantity_good;
        private System.Windows.Forms.Button Delete_good;
        private System.Windows.Forms.Button Back_in_main_window;
        private System.Windows.Forms.Button Confirm_order;
        private System.Windows.Forms.TextBox Price_all_goods;
    }
}