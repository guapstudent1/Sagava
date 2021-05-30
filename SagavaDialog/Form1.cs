using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SagavaDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void say_Click(object sender, EventArgs e)
        {
            dialog.Items.Add("you say: "+input.Text);
            dialog.Items.Add("bot say: "+input.Text);
            dialog.TopIndex = dialog.Items.Count - 1;
        }

        private void clearChat_Click(object sender, EventArgs e)
        {
            dialog.Items.Clear();
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dialog.Items.Add("you say: " + input.Text);
                dialog.Items.Add("bot say: " + input.Text);
                dialog.TopIndex = dialog.Items.Count - 1;
                input.Text = "";
            }
        }
    }
}
