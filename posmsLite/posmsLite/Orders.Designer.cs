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
            this.OnlyNotDeliveredCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.List_goods_order)).BeginInit();
            this.SuspendLayout();
            // 
            // Orders_label
            // 
            this.Orders_label.AutoSize = true;
            this.Orders_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orders_label.Location = new System.Drawing.Point(245, 11);
            this.Orders_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Orders_label.Name = "Orders_label";
            this.Orders_label.Size = new System.Drawing.Size(88, 29);
            this.Orders_label.TabIndex = 0;
            this.Orders_label.Text = "Orders";
            // 
            // List_Orders
            // 
            this.List_Orders.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.List_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_Orders.FormattingEnabled = true;
            this.List_Orders.Location = new System.Drawing.Point(16, 44);
            this.List_Orders.Margin = new System.Windows.Forms.Padding(4);
            this.List_Orders.Name = "List_Orders";
            this.List_Orders.Size = new System.Drawing.Size(517, 35);
            this.List_Orders.TabIndex = 1;
            this.List_Orders.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.List_Orders_DrawItem);
            this.List_Orders.SelectedIndexChanged += new System.EventHandler(this.List_Orders_SelectedIndexChanged);
            // 
            // List_goods_order
            // 
            this.List_goods_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_goods_order.Location = new System.Drawing.Point(16, 91);
            this.List_goods_order.Margin = new System.Windows.Forms.Padding(4);
            this.List_goods_order.Name = "List_goods_order";
            this.List_goods_order.Size = new System.Drawing.Size(517, 358);
            this.List_goods_order.TabIndex = 2;
            // 
            // Back_in_main_window
            // 
            this.Back_in_main_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_in_main_window.Location = new System.Drawing.Point(16, 478);
            this.Back_in_main_window.Margin = new System.Windows.Forms.Padding(4);
            this.Back_in_main_window.Name = "Back_in_main_window";
            this.Back_in_main_window.Size = new System.Drawing.Size(100, 49);
            this.Back_in_main_window.TabIndex = 3;
            this.Back_in_main_window.Text = "Back";
            this.Back_in_main_window.UseVisualStyleBackColor = true;
            this.Back_in_main_window.Click += new System.EventHandler(this.Back_in_main_window_Click);
            // 
            // Confirm_delivery
            // 
            this.Confirm_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Confirm_delivery.Location = new System.Drawing.Point(327, 478);
            this.Confirm_delivery.Margin = new System.Windows.Forms.Padding(4);
            this.Confirm_delivery.Name = "Confirm_delivery";
            this.Confirm_delivery.Size = new System.Drawing.Size(208, 49);
            this.Confirm_delivery.TabIndex = 4;
            this.Confirm_delivery.Text = "Confirm delivery";
            this.Confirm_delivery.UseVisualStyleBackColor = true;
            this.Confirm_delivery.Click += new System.EventHandler(this.Confirm_delivery_Click);
            // 
            // OnlyNotDeliveredCheckBox
            // 
            this.OnlyNotDeliveredCheckBox.AutoSize = true;
            this.OnlyNotDeliveredCheckBox.Location = new System.Drawing.Point(16, 11);
            this.OnlyNotDeliveredCheckBox.Name = "OnlyNotDeliveredCheckBox";
            this.OnlyNotDeliveredCheckBox.Size = new System.Drawing.Size(149, 21);
            this.OnlyNotDeliveredCheckBox.TabIndex = 5;
            this.OnlyNotDeliveredCheckBox.Text = "Only Not Delivered";
            this.OnlyNotDeliveredCheckBox.UseVisualStyleBackColor = true;
            this.OnlyNotDeliveredCheckBox.CheckedChanged += new System.EventHandler(this.OnlyNotDeliveredCheckBox_CheckedChanged);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 554);
            this.Controls.Add(this.OnlyNotDeliveredCheckBox);
            this.Controls.Add(this.Confirm_delivery);
            this.Controls.Add(this.Back_in_main_window);
            this.Controls.Add(this.List_goods_order);
            this.Controls.Add(this.List_Orders);
            this.Controls.Add(this.Orders_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Orders";
            this.Text = "Orders Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Orders_FormClosing);
            this.Load += new System.EventHandler(this.Orders_Load);
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
        private System.Windows.Forms.CheckBox OnlyNotDeliveredCheckBox;
    }
}