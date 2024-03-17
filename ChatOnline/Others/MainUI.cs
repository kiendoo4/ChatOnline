using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatOnline.Others
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            HideButton.Size = new Size(20, 20);
            HideButton.BackColor = Color.Green;
            HideButton.FlatStyle = FlatStyle.Flat;
            HideButton.FlatAppearance.BorderSize = 0;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 20, 20);
            HideButton.Region = new Region(path);
            Controls.Add(HideButton);
            closeButton.Size = new Size(20, 20);
            closeButton.BackColor = Color.Red;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            GraphicsPath closePath = new GraphicsPath();
            closePath.AddEllipse(0, 0, 20, 20);
            closeButton.Region = new Region(closePath);
            HideButton.Click += HideButton_Click;
            closeButton.Click += closeButton_Click;
        }
        public MainUI(Form1 form1)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            HideButton.Size = new Size(20, 20);
            HideButton.BackColor = Color.Green;
            HideButton.FlatStyle = FlatStyle.Flat;
            HideButton.FlatAppearance.BorderSize = 0;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 20, 20);
            HideButton.Region = new Region(path);
            Controls.Add(HideButton);
            closeButton.Size = new Size(20, 20);
            closeButton.BackColor = Color.Red;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            GraphicsPath closePath = new GraphicsPath();
            closePath.AddEllipse(0, 0, 20, 20);
            closeButton.Region = new Region(closePath);
            HideButton.Click += HideButton_Click;
            closeButton.Click += closeButton_Click;
            AccountList.FlowDirection = FlowDirection.TopDown; // Arrange controls horizontally
            AccountList.WrapContents = true; // Enable wrapping of controls

            // Add some controls to the AccountList
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Text = "Button " + i;
                AccountList.Controls.Add(button);
            }

            // Add the AccountList to the form
            panel1.Controls.Add(AccountList);
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }
        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
