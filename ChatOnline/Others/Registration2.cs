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
    public partial class Registration2 : UserControl
    {
        public event EventHandler ButtonClicked;
        public Registration2()
        {
            InitializeComponent();
        }
        public Registration2(Registration registration)
        {
            InitializeComponent();
        }
        private void ContinueButton_Click(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
