namespace ChatOnline.Others
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            closeButton = new Button();
            HideButton = new Button();
            label1 = new Label();
            panel1 = new Panel();
            AccountList = new FlowLayoutPanel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Red;
            closeButton.ForeColor = SystemColors.ControlText;
            closeButton.Location = new Point(1545, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(19, 17);
            closeButton.TabIndex = 6;
            closeButton.UseVisualStyleBackColor = false;
            // 
            // HideButton
            // 
            HideButton.BackColor = Color.Green;
            HideButton.ForeColor = SystemColors.ControlText;
            HideButton.Location = new Point(1509, 12);
            HideButton.Name = "HideButton";
            HideButton.Size = new Size(19, 17);
            HideButton.TabIndex = 5;
            HideButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Paytone One", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(178, 48);
            label1.TabIndex = 7;
            label1.Text = "Đoạn chat";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(AccountList);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 760);
            panel1.TabIndex = 8;
            // 
            // AccountList
            // 
            AccountList.BackColor = Color.IndianRed;
            AccountList.FlowDirection = FlowDirection.TopDown;
            AccountList.Location = new Point(0, 135);
            AccountList.Name = "AccountList";
            AccountList.Size = new Size(431, 624);
            AccountList.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(28, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 38);
            panel2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Quicksand SemiBold", 10F);
            textBox1.Location = new Point(52, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 28);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1582, 753);
            Controls.Add(panel1);
            Controls.Add(closeButton);
            Controls.Add(HideButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainUI";
            Load += MainUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button closeButton;
        private Button HideButton;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private FlowLayoutPanel AccountList;
    }
}