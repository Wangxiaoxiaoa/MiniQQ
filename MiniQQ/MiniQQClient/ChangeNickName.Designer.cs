﻿namespace MiniQQClient
{
    partial class ChangeNickName
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            old_name = new TextBox();
            textBox1 = new TextBox();
            new_name = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(54, 29);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 0;
            label1.Text = "好友用户名：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(42, 67);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 1;
            label2.Text = "好友当前昵称：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(42, 103);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 2;
            label3.Text = "修改好友昵称：";
            // 
            // old_name
            // 
            old_name.Location = new Point(140, 26);
            old_name.Name = "old_name";
            old_name.Size = new Size(137, 23);
            old_name.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 4;
            // 
            // new_name
            // 
            new_name.Location = new Point(140, 100);
            new_name.Name = "new_name";
            new_name.Size = new Size(137, 23);
            new_name.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(90, 142);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "修改";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 142);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "确定";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ChangeNickName
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_bg;
            ClientSize = new Size(375, 198);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(new_name);
            Controls.Add(textBox1);
            Controls.Add(old_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangeNickName";
            Text = "修改好友昵称";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox old_name;
        public TextBox textBox1;
        private TextBox new_name;
        private Button button1;
        private Button button2;
    }
}