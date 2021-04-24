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
        // 最初に実行される
        // ここは、グローバル変数のように使える
        private List<Person> members = new List<Person>();
        private BindingSource bs = new BindingSource();

        // フォームが表示された時に実行される
        public Form1()
        {
            InitializeComponent();

            // 列の自動追加を無効にする
            dgvMembers.AutoGenerateColumns = false;

            // BindingSourceをDataGridViewに表示する
            bs.DataSource = members;
            dgvMembers.DataSource = bs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = tbName.Text;
            person.Age = (int)nudAge.Value;

            bs.Add(person);
        }
    }
}
