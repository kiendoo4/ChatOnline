namespace ChatOnline.Others
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            ForgotPassword = new Button();
            LoginButton = new Button();
            RegistrationButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Paytone One", 21F);
            label1.Location = new Point(46, 33);
            label1.Name = "label1";
            label1.Size = new Size(409, 57);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 110);
            label2.Name = "label2";
            label2.Size = new Size(223, 38);
            label2.TabIndex = 1;
            label2.Text = "Username/Gmail";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Quicksand SemiBold", 15F);
            textBox1.Location = new Point(55, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 39);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 213);
            label3.Name = "label3";
            label3.Size = new Size(131, 38);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Quicksand SemiBold", 15F);
            textBox2.Location = new Point(56, 254);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(400, 39);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 403);
            label4.Name = "label4";
            label4.Size = new Size(246, 38);
            label4.TabIndex = 5;
            label4.Text = "Chưa có tài khoản?";
            // 
            // ForgotPassword
            // 
            ForgotPassword.BackColor = Color.SteelBlue;
            ForgotPassword.Font = new Font("Paytone One", 10F, FontStyle.Bold);
            ForgotPassword.ForeColor = Color.White;
            ForgotPassword.Location = new Point(56, 322);
            ForgotPassword.Name = "ForgotPassword";
            ForgotPassword.Size = new Size(181, 51);
            ForgotPassword.TabIndex = 6;
            ForgotPassword.Text = "Quên mật khẩu";
            ForgotPassword.UseVisualStyleBackColor = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Purple;
            LoginButton.Font = new Font("Paytone One", 10F, FontStyle.Bold);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(275, 322);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(181, 51);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Đăng nhập";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // RegistrationButton
            // 
            RegistrationButton.BackColor = Color.IndianRed;
            RegistrationButton.Font = new Font("Paytone One", 10F, FontStyle.Bold);
            RegistrationButton.ForeColor = Color.White;
            RegistrationButton.Location = new Point(308, 398);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(148, 51);
            RegistrationButton.TabIndex = 8;
            RegistrationButton.Text = "Đăng ký";
            RegistrationButton.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(RegistrationButton);
            Controls.Add(LoginButton);
            Controls.Add(ForgotPassword);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Size = new Size(500, 481);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Button ForgotPassword;
        private Button LoginButton;
        private Button RegistrationButton;
    }
}
