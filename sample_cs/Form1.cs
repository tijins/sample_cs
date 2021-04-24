using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("こんにちは");
        }

        private void btnBye_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("さよならですか？","サンプルアプリ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("さようなら");
                Close();
            }
        }
    }
}
