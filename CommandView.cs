using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperFileConverter
{
    public partial class CommandView : Form
    {
        public CommandView()
        {
            InitializeComponent();
        }

        public void SetCommandText(string text)
        {
            tbCommandText.Text = text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
