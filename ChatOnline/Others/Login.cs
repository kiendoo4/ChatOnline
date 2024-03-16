using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatOnline.Others
{
    public partial class Login : UserControl
    {
        public event EventHandler ButtonClicked;
        public Login()
        {
            InitializeComponent();
            ForgotPassword.MouseEnter += (sender, e) => ForgotPassword.BackColor = Color.DeepSkyBlue;
            ForgotPassword.MouseLeave += (sender, e) => ForgotPassword.BackColor = Color.SteelBlue;
            LoginButton.MouseEnter += (sender, e) => LoginButton.BackColor = Color.PaleVioletRed;
            LoginButton.MouseLeave += (sender, e) => LoginButton.BackColor = Color.Purple;
            LoginButton.Click += LoginButton_Click;
            RegistrationButton.MouseEnter += (sender, e) => RegistrationButton.BackColor = Color.LightCoral;
            RegistrationButton.MouseLeave += (sender, e) => RegistrationButton.BackColor = Color.IndianRed;
            RegistrationButton.Click += RegistrationButton_Click;
        }

        private void RegistrationButton_Click(object? sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login button clicked!");
        }
    }
}
