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
    public partial class RemoveByDigit : Form
    {
        MainForm mainForm;
        public RemoveByDigit()
        {
            InitializeComponent();
        }
        public RemoveByDigit(MainForm mform)
        {
            InitializeComponent();
            mainForm = mform;
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            int startIdx = ((int)numericUpDown1.Value)-1;
            int endIdx = ((int)numericUpDown2.Value);

            mainForm.changeListByDigit(startIdx, endIdx);
            this.Close();

        }
        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
