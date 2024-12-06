using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void HyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здравуствуйте!");
        }

        private void Close2Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
