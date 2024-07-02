namespace mini_project
{
    partial class AppendNumber
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
            btn_front = new Button();
            btn_back = new Button();
            btn_cancle = new Button();
            SuspendLayout();
            // 
            // btn_front
            // 
            btn_front.Location = new Point(12, 12);
            btn_front.Name = "btn_front";
            btn_front.Size = new Size(130, 70);
            btn_front.TabIndex = 0;
            btn_front.Text = "num.name 형식";
            btn_front.UseVisualStyleBackColor = true;
            btn_front.Click += btn_front_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(148, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(130, 70);
            btn_back.TabIndex = 1;
            btn_back.Text = "name num 형식";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_cancle
            // 
            btn_cancle.Location = new Point(284, 12);
            btn_cancle.Name = "btn_cancle";
            btn_cancle.Size = new Size(130, 70);
            btn_cancle.TabIndex = 2;
            btn_cancle.Text = "취소";
            btn_cancle.UseVisualStyleBackColor = true;
            btn_cancle.Click += btn_cancle_Click;
            // 
            // AppendNumber
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 94);
            Controls.Add(btn_cancle);
            Controls.Add(btn_back);
            Controls.Add(btn_front);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppendNumber";
            Text = "번호 붙이기";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_front;
        private Button btn_back;
        private Button btn_cancle;
    }
}