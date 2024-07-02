namespace mini_project
{
    partial class ChangeExtension
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox1 = new TextBox();
            btn_apply = new Button();
            btn_cancle = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // btn_apply
            // 
            btn_apply.Location = new Point(118, 12);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(75, 23);
            btn_apply.TabIndex = 1;
            btn_apply.Text = "적용";
            btn_apply.UseVisualStyleBackColor = true;
            btn_apply.Click += btn_apply_Click;
            // 
            // btn_cancle
            // 
            btn_cancle.Location = new Point(199, 12);
            btn_cancle.Name = "btn_cancle";
            btn_cancle.Size = new Size(75, 23);
            btn_cancle.TabIndex = 2;
            btn_cancle.Text = "취소";
            btn_cancle.UseVisualStyleBackColor = true;
            btn_cancle.Click += btn_cancle_Click;
            // 
            // ChangeExtension
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 47);
            Controls.Add(btn_cancle);
            Controls.Add(btn_apply);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ChangeExtension";
            Text = "확장자 변경";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox1;
        private Button btn_apply;
        private Button btn_cancle;
    }
}