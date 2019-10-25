namespace posmsLite
{
    partial class LoginWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Sign_in_as_employee = new System.Windows.Forms.Button();
            this.Sign_in_as_guest = new System.Windows.Forms.Button();
            this.Sign_in_label = new System.Windows.Forms.Label();
            this.or_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(173, 154);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(173, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 28);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Login_label
            // 
            this.Login_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.Location = new System.Drawing.Point(271, 55);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(65, 25);
            this.Login_label.TabIndex = 3;
            this.Login_label.Text = "Login";
            this.Login_label.Click += new System.EventHandler(this.Login_label_Click);
            // 
            // Password_label
            // 
            this.Password_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.Location = new System.Drawing.Point(250, 126);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(106, 25);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Password";
            this.Password_label.Click += new System.EventHandler(this.Password_label_Click);
            // 
            // Sign_in_as_employee
            // 
            this.Sign_in_as_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sign_in_as_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_in_as_employee.Location = new System.Drawing.Point(118, 268);
            this.Sign_in_as_employee.Name = "Sign_in_as_employee";
            this.Sign_in_as_employee.Size = new System.Drawing.Size(122, 47);
            this.Sign_in_as_employee.TabIndex = 5;
            this.Sign_in_as_employee.Text = "Employee";
            this.Sign_in_as_employee.UseVisualStyleBackColor = true;
            // 
            // Sign_in_as_guest
            // 
            this.Sign_in_as_guest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Sign_in_as_guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_in_as_guest.Location = new System.Drawing.Point(364, 268);
            this.Sign_in_as_guest.Name = "Sign_in_as_guest";
            this.Sign_in_as_guest.Size = new System.Drawing.Size(122, 47);
            this.Sign_in_as_guest.TabIndex = 6;
            this.Sign_in_as_guest.Text = "Guest";
            this.Sign_in_as_guest.UseVisualStyleBackColor = true;
            // 
            // Sign_in_label
            // 
            this.Sign_in_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sign_in_label.AutoSize = true;
            this.Sign_in_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_in_label.Location = new System.Drawing.Point(264, 205);
            this.Sign_in_label.Name = "Sign_in_label";
            this.Sign_in_label.Size = new System.Drawing.Size(78, 25);
            this.Sign_in_label.TabIndex = 2;
            this.Sign_in_label.Text = "Sign in";
            this.Sign_in_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // or_label
            // 
            this.or_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.or_label.AutoSize = true;
            this.or_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.or_label.Location = new System.Drawing.Point(288, 278);
            this.or_label.Name = "or_label";
            this.or_label.Size = new System.Drawing.Size(31, 25);
            this.or_label.TabIndex = 7;
            this.or_label.Text = "or";
            this.or_label.Click += new System.EventHandler(this.or_label_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.or_label);
            this.Controls.Add(this.Sign_in_as_guest);
            this.Controls.Add(this.Sign_in_as_employee);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Sign_in_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginWindow";
            this.Text = "Login Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button Sign_in_as_employee;
        private System.Windows.Forms.Button Sign_in_as_guest;
        private System.Windows.Forms.Label Sign_in_label;
        private System.Windows.Forms.Label or_label;
    }
}

