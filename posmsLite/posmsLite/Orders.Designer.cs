namespace posmsLite
{
    partial class Orders
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
            this.Orders_label = new System.Windows.Forms.Label();
            this.List_Orders = new System.Windows.Forms.ComboBox();
            this.List_goods_order = new System.Windows.Forms.DataGridView();
            this.Back_in_main_window = new System.Windows.Forms.Button();
            this.Confirm_delivery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.List_goods_order)).BeginInit();
            this.SuspendLayout();
            // 
            // Orders_label
            // 
            this.Orders_label.AutoSize = true;
            this.Orders_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orders_label.Location = new System.Drawing.Point(184, 9);
            this.Orders_label.Name = "Orders_label";
            this.Orders_label.Size = new System.Drawing.Size(68, 24);
            this.Orders_label.TabIndex = 0;
            this.Orders_label.Text = "Orders";
            // 
            // List_Orders
            // 
            this.List_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_Orders.FormattingEnabled = true;
            this.List_Orders.Location = new System.Drawing.Point(157, 36);
            this.List_Orders.Name = "List_Orders";
            this.List_Orders.Size = new System.Drawing.Size(121, 32);
            this.List_Orders.TabIndex = 1;
            // 
            // List_goods_order
            // 
            this.List_goods_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_goods_order.Location = new System.Drawing.Point(12, 74);
            this.List_goods_order.Name = "List_goods_order";
            this.List_goods_order.Size = new System.Drawing.Size(388, 291);
            this.List_goods_order.TabIndex = 2;
            // 
            // Back_in_main_window
            // 
            this.Back_in_main_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_in_main_window.Location = new System.Drawing.Point(12, 388);
            this.Back_in_main_window.Name = "Back_in_main_window";
            this.Back_in_main_window.Size = new System.Drawing.Size(75, 40);
            this.Back_in_main_window.TabIndex = 3;
            this.Back_in_main_window.Text = "Back";
            this.Back_in_main_window.UseVisualStyleBackColor = true;
            this.Back_in_main_window.Click += new System.EventHandler(this.button1_Click);
            // 
            // Confirm_delivery
            // 
            this.Confirm_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Confirm_delivery.Location = new System.Drawing.Point(245, 388);
            this.Confirm_delivery.Name = "Confirm_delivery";
            this.Confirm_delivery.Size = new System.Drawing.Size(156, 40);
            this.Confirm_delivery.TabIndex = 4;
            this.Confirm_delivery.Text = "Confirm delivery";
            this.Confirm_delivery.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.Confirm_delivery);
            this.Controls.Add(this.Back_in_main_window);
            this.Controls.Add(this.List_goods_order);
            this.Controls.Add(this.List_Orders);
            this.Controls.Add(this.Orders_label);
            this.Name = "Orders";
            this.Text = "Orders Window";
            ((System.ComponentModel.ISupportInitialize)(this.List_goods_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Orders_label;
        private System.Windows.Forms.ComboBox List_Orders;
        private System.Windows.Forms.DataGridView List_goods_order;
        private System.Windows.Forms.Button Back_in_main_window;
        private System.Windows.Forms.Button Confirm_delivery;
    }
}