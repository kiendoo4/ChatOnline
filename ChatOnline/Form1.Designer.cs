namespace ChatOnline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            HideButton = new Button();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(846, 663);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Paytone One", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 692);
            label1.Name = "label1";
            label1.Size = new Size(600, 69);
            label1.TabIndex = 1;
            label1.Text = "Phần mềm nhắn tin online";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Location = new Point(1049, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 481);
            panel1.TabIndex = 2;
            // 
            // HideButton
            // 
            HideButton.BackColor = Color.Green;
            HideButton.ForeColor = SystemColors.ControlText;
            HideButton.Location = new Point(1509, 12);
            HideButton.Name = "HideButton";
            HideButton.Size = new Size(19, 17);
            HideButton.TabIndex = 3;
            HideButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Red;
            closeButton.ForeColor = SystemColors.ControlText;
            closeButton.Location = new Point(1545, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(19, 17);
            closeButton.TabIndex = 4;
            closeButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1600, 800);
            Controls.Add(closeButton);
            Controls.Add(HideButton);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Button HideButton;
        private Button closeButton;
    }
}
