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
    public partial class Registration : UserControl
    {
        public event EventHandler ButtonClicked;
        public event EventHandler ButtonClicked2;
        public Registration()
        {
            InitializeComponent();
        }
        private void Backbutton_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            ButtonClicked2?.Invoke(this, EventArgs.Empty);
        }
    }
}
