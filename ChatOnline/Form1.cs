using ChatOnline.Others;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace ChatOnline
{
    public partial class Form1 : Form
    {
        Login login = new Login();
        Registration registration = new Registration();
        public Form1()
        {
            InitializeComponent();
            login.ButtonClicked += Login_ButtonClicked;
            login.LoginSuccessClicked += Login_LoginSuccessClicked;
            registration.ButtonClicked += Registration_ButtonClicked;
            registration.ButtonClicked2 += RegistrationConti_ButtonClicked;
            this.BackColor = Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            SetPanelAppearance(panel1, 20, Color.Black);
            HideButton.Size = new Size(20, 20);
            HideButton.BackColor = Color.Green;
            HideButton.FlatStyle = FlatStyle.Flat;
            HideButton.FlatAppearance.BorderSize = 0;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 20, 20);
            HideButton.Region = new Region(path);
            HideButton.Click += HideButton_Click;
            Controls.Add(HideButton);
            closeButton.Size = new Size(20, 20);
            closeButton.BackColor = Color.Red;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            GraphicsPath closePath = new GraphicsPath();
            closePath.AddEllipse(0, 0, 20, 20);
            closeButton.Region = new Region(closePath);
            closeButton.Click += closeButton_Click;
            panel1.Controls.Clear();
            panel1.Controls.Add(login);
        }

        private void Login_LoginSuccessClicked(object? sender, EventArgs e)
        {
            MainUI mainUI = new MainUI(this);
            mainUI.Show();
            this.Hide();
            mainUI.FormClosed += (s, args) => this.Close();
            mainUI.Show();
        }

        private void Registration_ButtonClicked(object? sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(login);
        }
        private void RegistrationConti_ButtonClicked(object? sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Registration2 registration2 = new Registration2(registration);
            registration2.ButtonClicked += Registration2_ButtonClicked;
            panel1.Controls.Add(registration2);
        }

        private void Registration2_ButtonClicked(object? sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(registration);
        }

        private void Login_ButtonClicked(object? sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(registration);
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SetPanelAppearance(Panel panel, int radius, Color borderColor)
        {
            // Create a GraphicsPath to define the shape of the panel (rounded rectangle)
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(panel.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(panel.Width - (radius * 2), panel.Height - (radius * 2), radius * 2, radius * 2, 0, 90);
            path.AddArc(0, panel.Height - (radius * 2), radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
            panel.BackColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
