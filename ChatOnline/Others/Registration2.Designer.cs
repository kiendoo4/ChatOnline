namespace ChatOnline.Others
{
    partial class Registration2
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
            Backbutton = new Button();
            FinishButton = new Button();
            username = new TextBox();
            label3 = new Label();
            hoten = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Backbutton
            // 
            Backbutton.BackColor = Color.IndianRed;
            Backbutton.Font = new Font("Paytone One", 10F, FontStyle.Bold);
            Backbutton.ForeColor = Color.White;
            Backbutton.Location = new Point(55, 396);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(148, 51);
            Backbutton.TabIndex = 29;
            Backbutton.Text = "Trở lại";
            Backbutton.UseVisualStyleBackColor = false;
            Backbutton.Click += Backbutton_Click;
            // 
            // FinishButton
            // 
            FinishButton.BackColor = Color.IndianRed;
            FinishButton.Font = new Font("Paytone One", 10F, FontStyle.Bold);
            FinishButton.ForeColor = Color.White;
            FinishButton.Location = new Point(307, 396);
            FinishButton.Name = "FinishButton";
            FinishButton.Size = new Size(148, 51);
            FinishButton.TabIndex = 26;
            FinishButton.Text = "Đăng ký";
            FinishButton.UseVisualStyleBackColor = false;
            FinishButton.Click += ContinueButton_Click;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.Font = new Font("Quicksand SemiBold", 15F);
            username.Location = new Point(55, 244);
            username.Name = "username";
            username.PasswordChar = '•';
            username.Size = new Size(400, 39);
            username.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 203);
            label3.Name = "label3";
            label3.Size = new Size(251, 38);
            label3.TabIndex = 24;
            label3.Text = "Xác nhận mật khẩu";
            // 
            // hoten
            // 
            hoten.BackColor = Color.White;
            hoten.Font = new Font("Quicksand SemiBold", 15F);
            hoten.Location = new Point(55, 151);
            hoten.Name = "hoten";
            hoten.PasswordChar = '•';
            hoten.Size = new Size(400, 39);
            hoten.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 110);
            label2.Name = "label2";
            label2.Size = new Size(130, 38);
            label2.TabIndex = 22;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Paytone One", 21F);
            label1.Location = new Point(46, 33);
            label1.Name = "label1";
            label1.Size = new Size(358, 57);
            label1.TabIndex = 21;
            label1.Text = "Đăng ký tài khoản";
            // 
            // Registration2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Backbutton);
            Controls.Add(FinishButton);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(hoten);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration2";
            Size = new Size(500, 481);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Backbutton;
        private Button FinishButton;
        private TextBox username;
        private Label label3;
        private TextBox hoten;
        private Label label2;
        private Label label1;
    }
}
