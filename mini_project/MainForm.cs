using System.Runtime.InteropServices;

namespace mini_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        static bool state = false;

        [DllImport("mini_project_dll.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr removeSubString(string str, int start, int end);

        [DllImport("mini_project_dll.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void freeString(IntPtr str);

        [DllImport("mini_project_dll.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr appendNumber(string str, int number, bool atFront);

        
        enum Index { original = 1, revision, extension, path }

        void addListViewItem(string name, string extension, string path, string revision = "", string idx = "")
        {
            ListViewItem listItem = new ListViewItem(idx);
            listItem.SubItems.Add(name); //���� �� �̸� -> ����
            listItem.SubItems.Add(revision); //���� �� �̸� -> ����
            listItem.SubItems.Add(extension); //Ȯ���ڸ�
            listItem.SubItems.Add(path); //��ü ���
            listView1.Items.Add(listItem);
        }

        // ���� �ҷ����� ��ư
        private void btn_import_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            String[] filePath;
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileNames;
                foreach (var item in filePath)
                {
                    if (File.Exists(item))
                    {
                        string name = Path.GetFileNameWithoutExtension(item);
                        string extention = Path.GetExtension(item);

                        addListViewItem(name, extention, item);
                    }
                    if (Directory.Exists(item))
                    {
                        string[] files = Directory.GetFiles(item, "*", SearchOption.TopDirectoryOnly);
                        foreach (string file in files)
                        {
                            string name = Path.GetFileNameWithoutExtension(file);
                            string extention = Path.GetExtension(file);
                            addListViewItem(name, extention, item);
                        }
                    }
                }
            }
        }
        // ��ü �ʱ�ȭ ��ư
        private void btn_reset_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Flag.State.IsChanged = false;
        }
        // ���� ��ư
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ���� ���� ��� ��ư
        private void btn_undo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.SubItems[((int)Index.revision)].Text = "";
            }
            Flag.State.IsChanged = false;
        }
        // ���� ��ư
        private void btn_apply_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (File.Exists(item.SubItems[((int)Index.path)].Text))
                {
                    try
                    {
                        string path = item.SubItems[4].Text;
                        string dest = Path.Combine(Path.GetDirectoryName(item.SubItems[4].Text), item.SubItems[2].Text) + item.SubItems[3].Text;
                        File.Move(path, dest, true);
                        item.SubItems[((int)Index.original)].Text = Path.GetFileName(dest);
                        item.SubItems[((int)Index.revision)].Text = "";
                        item.SubItems[((int)Index.extension)].Text = Path.GetExtension(dest);
                        item.SubItems[((int)Index.path)].Text = dest;
                    }
                    catch
                    {
                        MessageBox.Show("���� �߻�");
                    }
                }
            }
            MessageBox.Show("���� �Ϸ�");
            Flag.State.IsChanged = false;
        }


        // ���� ���ϸ� ���� �߰�
        private void btn_insert_num_Click(object sender, EventArgs e)
        {
            AppendNumber appendForm = new AppendNumber(this);
            appendForm.StartPosition = FormStartPosition.CenterParent;
            appendForm.Show();
        }
        public void appendListNum(bool atFront)
        {
            int i = 1;
            if (Flag.State.IsChanged == false)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    IntPtr resultPtr = appendNumber(item.SubItems[((int)Index.original)].Text, i++, atFront);
                    string result = Marshal.PtrToStringAnsi(resultPtr);
                    item.SubItems[((int)Index.revision)].Text = result;

                    //item.SubItems[((int)Index.revision)].Text = i.ToString() + "." + item.SubItems[((int)Index.original)].Text;
                    //i++;
                }
                Flag.State.IsChanged = true;
            }
            else
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    //item.SubItems[((int)Index.revision)].Text = i.ToString() + "." + item.SubItems[((int)Index.revision)].Text;
                    //i++;

                    IntPtr resultPtr = appendNumber(item.SubItems[((int)Index.revision)].Text, i++, atFront);
                    string result = Marshal.PtrToStringAnsi(resultPtr);
                    item.SubItems[((int)Index.revision)].Text = result;
                }
            }
        }

        // "�������ϸ�+����"�� �ϰ� ���� ��ư
        private void btn_name_number_Click(object sender, EventArgs e)
        {
            ChangeToName_Num form2 = new ChangeToName_Num(this);
            form2.StartPosition = FormStartPosition.CenterParent;
            form2.Show();
        }
        public void changeListByName_Num(string name, int i)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if(Flag.State.IsChanged == true)
                {
                    item.SubItems[((int)Index.revision)].Text = name + i.ToString();
                    i++;
                }
                else
                {
                    item.SubItems[((int)Index.revision)].Text = name + i.ToString();
                    i++;

                }
            }
        }

        // �ڸ����� ���ϸ� ���� ��ư
        private void btn_removeByDigit_Click(object sender, EventArgs e)
        {
            RemoveByDigit removeByDigit = new RemoveByDigit(this);
            removeByDigit.StartPosition = FormStartPosition.CenterParent;
            removeByDigit.Show();
        }
        public void changeListByDigit(int startIdx, int endIdx)
        {
            if (!Flag.State.IsChanged)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    string originalText = item.SubItems[((int)Index.original)].Text;
                    int len = originalText.Length;

                    IntPtr resultPtr = removeSubString(originalText, startIdx, endIdx);
                    string result = Marshal.PtrToStringAnsi(resultPtr);
                    item.SubItems[((int)Index.revision)].Text = result;

                    freeString(resultPtr);

                    //if (startIdx >= len)
                    //{
                    //    // startIdx�� ���ڿ� ���̺��� ũ�ų� ������ �������� ����.
                    //    item.SubItems[((int)Index.revision)].Text = originalText;
                    //}
                    //else
                    //{
                    //    // startIdx�� ���ڿ� ���̺��� ���� ���
                    //    int removalLength = Math.Min(endIdx - startIdx + 1, len - startIdx);
                    //    try
                    //    {
                    //        item.SubItems[((int)Index.revision)].Text = originalText.Remove(startIdx, removalLength);
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        item.SubItems[((int)Index.revision)].Text = originalText;
                    //    }
                    //}
                }
                Flag.State.IsChanged = true;
            }
            else
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    string revisionText = item.SubItems[((int)Index.revision)].Text;
                    int len = revisionText.Length;

                    IntPtr resultPtr = removeSubString(revisionText, startIdx, endIdx);
                    string result = Marshal.PtrToStringAnsi(resultPtr);
                    item.SubItems[((int)Index.revision)].Text = result;

                    freeString(resultPtr);
                    //if (startIdx < len)
                    //{
                    //    int removalLength = Math.Min(endIdx - startIdx + 1, len - startIdx);
                    //    try
                    //    {
                    //        item.SubItems[((int)Index.revision)].Text = revisionText.Remove(startIdx, removalLength);
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        item.SubItems[((int)Index.revision)].Text = revisionText;
                    //    }
                    //}
                }
            }
        }


        //�巡�� �� ��� �̺�Ʈ
        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // ������ �巡�׵Ǹ� ���� ȿ���� ����
            }
            else
            {
                e.Effect = DragDropEffects.None; // ������ �ƴϸ� �ƹ� �۾��� �������� ����
            }
        }
        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropItem = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var item in dropItem)
            {
                if (File.Exists(item))
                {
                    string name = Path.GetFileNameWithoutExtension(item);
                    string extention = Path.GetExtension(item);

                    addListViewItem(name, extention, item);
                }
                if (Directory.Exists(item))
                {

                    string[] files = Directory.GetFiles(item, "*", SearchOption.TopDirectoryOnly);
                    foreach (string file in files)
                    {
                        string name = Path.GetFileNameWithoutExtension(file);
                        string extention = Path.GetExtension(file);
                        addListViewItem(name, extention, file);
                    }
                }
            }
        }
        private void btn_changeExtension_Click(object sender, EventArgs e)
        {
                ChangeExtension changeExtension = new ChangeExtension(this);
                changeExtension.StartPosition = FormStartPosition.CenterParent;
                changeExtension.Show();
        }
        public void ChangeListExtension(string ext)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.SubItems[((int)Index.extension)].Text = "." + ext;
            }
        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int idx = e.Column;
            if (state == false)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Checked = true;
                }
                state = true;
            }
            else
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Checked = false;
                }
                state = false;
            }
        }
    }
}
