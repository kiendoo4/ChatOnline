namespace ChatOnline.Others
{
    partial class Registration
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
            ContinueButton = new Button();
            username = new TextBox();
            label3 = new Label();
            hoten = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gmail = new TextBox();
            label4 = new Label();
            Backbutton = new Button();
            SuspendLayout();
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = Color.IndianRed;
            ContinueButton.Font = new Font("Paytone One", 10F, FontStyle.Bold);
            ContinueButton.ForeColor = Color.White;
            ContinueButton.Location = new Point(307, 396);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(148, 51);
            ContinueButton.TabIndex = 17;
            ContinueButton.Text = "Tiếp tục";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.Font = new Font("Quicksand SemiBold", 15F);
            username.Location = new Point(55, 244);
            username.Name = "username";
            username.PasswordChar = '•';
            username.Size = new Size(400, 39);
            username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 203);
            label3.Name = "label3";
            label3.Size = new Size(141, 38);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // hoten
            // 
            hoten.BackColor = Color.White;
            hoten.Font = new Font("Quicksand SemiBold", 15F);
            hoten.Location = new Point(55, 151);
            hoten.Name = "hoten";
            hoten.Size = new Size(400, 39);
            hoten.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 110);
            label2.Name = "label2";
            label2.Size = new Size(134, 38);
            label2.TabIndex = 10;
            label2.Text = "Họ và tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Paytone One", 21F);
            label1.Location = new Point(46, 33);
            label1.Name = "label1";
            label1.Size = new Size(358, 57);
            label1.TabIndex = 9;
            label1.Text = "Đăng ký tài khoản";
            // 
            // gmail
            // 
            gmail.BackColor = Color.White;
            gmail.Font = new Font("Quicksand SemiBold", 15F);
            gmail.Location = new Point(55, 334);
            gmail.Name = "gmail";
            gmail.PasswordChar = '•';
            gmail.Size = new Size(400, 39);
            gmail.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 293);
            label4.Name = "label4";
            label4.Size = new Size(85, 38);
            label4.TabIndex = 18;
            label4.Text = "Gmail";
            // 
            // Backbutton
            // 
            Backbutton.BackColor = Color.IndianRed;
            Backbutton.Font = new Font("Paytone One", 10F, FontStyle.Bold);
            Backbutton.ForeColor = Color.White;
            Backbutton.Location = new Point(55, 396);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(148, 51);
            Backbutton.TabIndex = 20;
            Backbutton.Text = "Trở lại";
            Backbutton.UseVisualStyleBackColor = false;
            Backbutton.Click += Backbutton_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Backbutton);
            Controls.Add(gmail);
            Controls.Add(label4);
            Controls.Add(ContinueButton);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(hoten);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration";
            Size = new Size(500, 481);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ContinueButton;
        private TextBox username;
        private Label label3;
        private TextBox hoten;
        private Label label2;
        private Label label1;
        private TextBox gmail;
        private Label label4;
        private Button Backbutton;
    }
}
