namespace mini_project
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_insert_num = new Button();
            btn_removeByDigit = new Button();
            btn_name_number = new Button();
            btn_changeExtension = new Button();
            btn_apply = new Button();
            btn_exit = new Button();
            btn_undo = new Button();
            btn_reset = new Button();
            btn_import_path = new Button();
            btn_import = new Button();
            openFileDialog1 = new OpenFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.AllowDrop = true;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(15, 16);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(775, 608);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ColumnClick += listView1_ColumnClick;
            listView1.DragDrop += listView1_DragDrop;
            listView1.DragEnter += listView1_DragEnter;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "선택";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "파일명 수정 전";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "파일명 수정 후";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "확장자명";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "파일 경로";
            columnHeader5.Width = 200;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btn_insert_num, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_removeByDigit, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_name_number, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_changeExtension, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_apply, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_exit, 1, 4);
            tableLayoutPanel1.Controls.Add(btn_undo, 0, 3);
            tableLayoutPanel1.Controls.Add(btn_reset, 0, 4);
            tableLayoutPanel1.Controls.Add(btn_import_path, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_import, 0, 0);
            tableLayoutPanel1.Location = new Point(813, 16);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(257, 609);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_insert_num
            // 
            btn_insert_num.Location = new Point(4, 125);
            btn_insert_num.Margin = new Padding(4);
            btn_insert_num.Name = "btn_insert_num";
            btn_insert_num.Size = new Size(120, 113);
            btn_insert_num.TabIndex = 2;
            btn_insert_num.Text = "번호 붙이기";
            btn_insert_num.UseVisualStyleBackColor = true;
            btn_insert_num.Click += btn_insert_num_Click;
            // 
            // btn_removeByDigit
            // 
            btn_removeByDigit.Location = new Point(132, 125);
            btn_removeByDigit.Margin = new Padding(4);
            btn_removeByDigit.Name = "btn_removeByDigit";
            btn_removeByDigit.Size = new Size(121, 113);
            btn_removeByDigit.TabIndex = 3;
            btn_removeByDigit.Text = "자릿수로\r\n지우기";
            btn_removeByDigit.UseVisualStyleBackColor = true;
            btn_removeByDigit.Click += btn_removeByDigit_Click;
            // 
            // btn_name_number
            // 
            btn_name_number.Location = new Point(4, 246);
            btn_name_number.Margin = new Padding(4);
            btn_name_number.Name = "btn_name_number";
            btn_name_number.Size = new Size(120, 113);
            btn_name_number.TabIndex = 4;
            btn_name_number.Text = "동일한 파일명 + 번호";
            btn_name_number.UseVisualStyleBackColor = true;
            btn_name_number.Click += btn_name_number_Click;
            // 
            // btn_changeExtension
            // 
            btn_changeExtension.Location = new Point(132, 246);
            btn_changeExtension.Margin = new Padding(4);
            btn_changeExtension.Name = "btn_changeExtension";
            btn_changeExtension.Size = new Size(121, 113);
            btn_changeExtension.TabIndex = 5;
            btn_changeExtension.Text = "확장자 변경";
            btn_changeExtension.UseVisualStyleBackColor = true;
            btn_changeExtension.Click += btn_changeExtension_Click;
            // 
            // btn_apply
            // 
            btn_apply.Location = new Point(132, 367);
            btn_apply.Margin = new Padding(4);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(121, 113);
            btn_apply.TabIndex = 7;
            btn_apply.Text = "변경 적용";
            btn_apply.UseVisualStyleBackColor = true;
            btn_apply.Click += btn_apply_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(132, 488);
            btn_exit.Margin = new Padding(4);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(121, 116);
            btn_exit.TabIndex = 9;
            btn_exit.Text = "종료";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_undo
            // 
            btn_undo.Location = new Point(4, 367);
            btn_undo.Margin = new Padding(4);
            btn_undo.Name = "btn_undo";
            btn_undo.Size = new Size(120, 113);
            btn_undo.TabIndex = 6;
            btn_undo.Text = "변경 취소";
            btn_undo.UseVisualStyleBackColor = true;
            btn_undo.Click += btn_undo_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(4, 488);
            btn_reset.Margin = new Padding(4);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(120, 113);
            btn_reset.TabIndex = 1;
            btn_reset.Text = "목록\r\n초기화";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_import_path
            // 
            btn_import_path.Location = new Point(132, 4);
            btn_import_path.Margin = new Padding(4);
            btn_import_path.Name = "btn_import_path";
            btn_import_path.Size = new Size(121, 113);
            btn_import_path.TabIndex = 0;
            btn_import_path.Text = "경로로 파일\r\n가져오기";
            btn_import_path.UseVisualStyleBackColor = true;
            // 
            // btn_import
            // 
            btn_import.Location = new Point(4, 4);
            btn_import.Margin = new Padding(4);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(120, 113);
            btn_import.TabIndex = 8;
            btn_import.Text = "파일 선택";
            btn_import.UseVisualStyleBackColor = true;
            btn_import.Click += btn_import_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 641);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "파일명 변경";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_import_path;
        private Button btn_reset;
        private Button btn_insert_num;
        private Button btn_removeByDigit;
        private Button btn_name_number;
        private Button btn_changeExtension;
        private Button btn_undo;
        private Button btn_apply;
        private Button btn_import;
        private Button btn_exit;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ColumnHeader columnHeader5;
    }
}
