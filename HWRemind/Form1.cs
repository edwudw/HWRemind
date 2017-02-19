using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWRemind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            ListItems listForm = new ListItems();
            DialogResult dr = listForm.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                englishButton.BackColor = Color.Lime;
            }
            else
            {
                englishButton.BackColor = Color.Red;
            }
        }
    }
}
