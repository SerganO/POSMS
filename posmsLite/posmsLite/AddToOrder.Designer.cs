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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Back_in_order_goods_window = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Provider_label = new System.Windows.Forms.Label();
            this.Good_label = new System.Windows.Forms.Label();
            this.Quantity_label = new System.Windows.Forms.Label();
            this.List_goods = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(40, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 2;
            // 
            // Back_in_order_goods_window
            // 
            this.Back_in_order_goods_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_in_order_goods_window.Location = new System.Drawing.Point(12, 287);
            this.Back_in_order_goods_window.Name = "Back_in_order_goods_window";
            this.Back_in_order_goods_window.Size = new System.Drawing.Size(75, 33);
            this.Back_in_order_goods_window.TabIndex = 3;
            this.Back_in_order_goods_window.Text = "Back";
            this.Back_in_order_goods_window.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Confirm.Location = new System.Drawing.Point(93, 287);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(94, 33);
            this.Confirm.TabIndex = 4;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // Provider_label
            // 
            this.Provider_label.AutoSize = true;
            this.Provider_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Provider_label.Location = new System.Drawing.Point(49, 9);
            this.Provider_label.Name = "Provider_label";
            this.Provider_label.Size = new System.Drawing.Size(80, 24);
            this.Provider_label.TabIndex = 5;
            this.Provider_label.Text = "Provider";
            // 
            // Good_label
            // 
            this.Good_label.AutoSize = true;
            this.Good_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Good_label.Location = new System.Drawing.Point(60, 88);
            this.Good_label.Name = "Good_label";
            this.Good_label.Size = new System.Drawing.Size(57, 24);
            this.Good_label.TabIndex = 6;
            this.Good_label.Text = "Good";
            // 
            // Quantity_label
            // 
            this.Quantity_label.AutoSize = true;
            this.Quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quantity_label.Location = new System.Drawing.Point(51, 185);
            this.Quantity_label.Name = "Quantity_label";
            this.Quantity_label.Size = new System.Drawing.Size(78, 24);
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
            this.List_goods.Location = new System.Drawing.Point(12, 131);
            this.List_goods.Name = "List_goods";
            this.List_goods.Size = new System.Drawing.Size(168, 32);
            this.List_goods.TabIndex = 8;
            // 
            // AddToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 334);
            this.Controls.Add(this.List_goods);
            this.Controls.Add(this.Quantity_label);
            this.Controls.Add(this.Good_label);
            this.Controls.Add(this.Provider_label);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Back_in_order_goods_window);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddToOrder";
            this.Text = "Add to order Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Back_in_order_goods_window;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Provider_label;
        private System.Windows.Forms.Label Good_label;
        private System.Windows.Forms.Label Quantity_label;
        private System.Windows.Forms.ComboBox List_goods;
    }
}