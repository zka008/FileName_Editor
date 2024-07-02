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
    public partial class AppendNumber : Form
    {
        MainForm mainForm;
        public AppendNumber()
        {
            InitializeComponent();
        }
        public AppendNumber(MainForm mform)
        {
            InitializeComponent();
            mainForm = mform;
        }

        private void btn_front_Click(object sender, EventArgs e)
        {
            mainForm.appendListNum(true);
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            mainForm.appendListNum(false);
            this.Close();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
