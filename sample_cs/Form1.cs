﻿using System;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.name = tbName.Text;
            person.age = (int)nudAge.Value;

            MessageBox.Show(String.Format("{0} {1}", person.name, person.age));
        }
    }
}
