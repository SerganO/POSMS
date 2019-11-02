namespace posmsLite
{
    partial class AddToOrder
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
            this.providerBox = new System.Windows.Forms.ComboBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.Back_in_order_goods_window = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Provider_label = new System.Windows.Forms.Label();
            this.Good_label = new System.Windows.Forms.Label();
            this.Quantity_label = new System.Windows.Forms.Label();
            this.List_goods = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // providerBox
            // 
            this.providerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.providerBox.FormattingEnabled = true;
            this.providerBox.Location = new System.Drawing.Point(13, 47);
            this.providerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.providerBox.Name = "providerBox";
            this.providerBox.Size = new System.Drawing.Size(497, 37);
            this.providerBox.TabIndex = 0;
            this.providerBox.SelectedIndexChanged += new System.EventHandler(this.providerBox_SelectedIndexChanged);
            // 
            // countTextBox
            // 
            this.countTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countTextBox.Location = new System.Drawing.Point(136, 281);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(233, 34);
            this.countTextBox.TabIndex = 2;
            // 
            // Back_in_order_goods_window
            // 
            this.Back_in_order_goods_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_in_order_goods_window.Location = new System.Drawing.Point(136, 351);
            this.Back_in_order_goods_window.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back_in_order_goods_window.Name = "Back_in_order_goods_window";
            this.Back_in_order_goods_window.Size = new System.Drawing.Size(100, 41);
            this.Back_in_order_goods_window.TabIndex = 3;
            this.Back_in_order_goods_window.Text = "Back";
            this.Back_in_order_goods_window.UseVisualStyleBackColor = true;
            this.Back_in_order_goods_window.Click += new System.EventHandler(this.Back_in_order_goods_window_Click);
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Confirm.Location = new System.Drawing.Point(244, 351);
            this.Confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(125, 41);
            this.Confirm.TabIndex = 4;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Provider_label
            // 
            this.Provider_label.AutoSize = true;
            this.Provider_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Provider_label.Location = new System.Drawing.Point(185, 9);
            this.Provider_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Provider_label.Name = "Provider_label";
            this.Provider_label.Size = new System.Drawing.Size(104, 29);
            this.Provider_label.TabIndex = 5;
            this.Provider_label.Text = "Provider";
            // 
            // Good_label
            // 
            this.Good_label.AutoSize = true;
            this.Good_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Good_label.Location = new System.Drawing.Point(199, 117);
            this.Good_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Good_label.Name = "Good_label";
            this.Good_label.Size = new System.Drawing.Size(73, 29);
            this.Good_label.TabIndex = 6;
            this.Good_label.Text = "Good";
            // 
            // Quantity_label
            // 
            this.Quantity_label.AutoSize = true;
            this.Quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quantity_label.Location = new System.Drawing.Point(189, 236);
            this.Quantity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quantity_label.Name = "Quantity_label";
            this.Quantity_label.Size = new System.Drawing.Size(100, 29);
            this.Quantity_label.TabIndex = 7;
            this.Quantity_label.Text = "Quantity";
            // 
            // List_goods
            // 
            this.List_goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.List_goods.Location = new System.Drawing.Point(13, 159);
            this.List_goods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.List_goods.Name = "List_goods";
            this.List_goods.Size = new System.Drawing.Size(497, 37);
            this.List_goods.TabIndex = 8;
            this.List_goods.SelectedIndexChanged += new System.EventHandler(this.List_goods_SelectedIndexChanged);
            // 
            // AddToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 411);
            this.Controls.Add(this.List_goods);
            this.Controls.Add(this.Quantity_label);
            this.Controls.Add(this.Good_label);
            this.Controls.Add(this.Provider_label);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Back_in_order_goods_window);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.providerBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddToOrder";
            this.Text = "Add to order Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox providerBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Button Back_in_order_goods_window;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Provider_label;
        private System.Windows.Forms.Label Good_label;
        private System.Windows.Forms.Label Quantity_label;
        private System.Windows.Forms.ComboBox List_goods;
    }
}