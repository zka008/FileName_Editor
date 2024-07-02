using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_project
{
    public partial class ChangeExtension : Form
    {
        MainForm mainForm;
        public ChangeExtension()
        {
            InitializeComponent();
        }
        public ChangeExtension(MainForm mform)
        {
            InitializeComponent();
            mainForm = mform;
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.ChangeListExtension(textBox1.Text);
                this.Close();
            }
            else
                MessageBox.Show("확장자를 입력하세요");
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
