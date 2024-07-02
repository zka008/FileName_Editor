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
    public partial class ChangeToName_Num : Form
    {
        MainForm mainForm;
        public ChangeToName_Num()
        {
            InitializeComponent();
        }
        public ChangeToName_Num(MainForm mform)
        {
            InitializeComponent();
            mainForm = mform;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                mainForm.changeListByName_Num(textBox1.Text, ((int)numericUpDown1.Value));
                this.Close();
            }
            else
            {
                MessageBox.Show("필드가 비어있습니다");
            }

        }
    }
}
