namespace Nguyenthanhtung_Buoi2_bai4
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txt_a = new TextBox();
            txt_b = new TextBox();
            txt_c = new TextBox();
            label5 = new Label();
            txt_Max = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 24);
            label1.Name = "label1";
            label1.Size = new Size(304, 32);
            label1.TabIndex = 0;
            label1.Text = "Tìm số lớn nhất trong 3 số ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 108);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Nhập A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 171);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Nhập B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 234);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 0;
            label4.Text = "Nhập C ";
            // 
            // button1
            // 
            button1.Location = new Point(327, 171);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Tiếp tục ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(327, 108);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Thực hiện ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(327, 225);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "Thoát ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_a
            // 
            txt_a.Location = new Point(161, 108);
            txt_a.Name = "txt_a";
            txt_a.Size = new Size(100, 23);
            txt_a.TabIndex = 2;
            // 
            // txt_b
            // 
            txt_b.Location = new Point(161, 168);
            txt_b.Name = "txt_b";
            txt_b.Size = new Size(100, 23);
            txt_b.TabIndex = 2;
            // 
            // txt_c
            // 
            txt_c.Location = new Point(161, 226);
            txt_c.Name = "txt_c";
            txt_c.Size = new Size(100, 23);
            txt_c.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 307);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 0;
            label5.Text = "Kết quả ";
            // 
            // txt_Max
            // 
            txt_Max.Location = new Point(161, 299);
            txt_Max.Name = "txt_Max";
            txt_Max.Size = new Size(241, 23);
            txt_Max.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Max);
            Controls.Add(txt_c);
            Controls.Add(txt_b);
            Controls.Add(txt_a);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txt_a;
        private TextBox txt_b;
        private TextBox txt_c;
        private Label label5;
        private TextBox txt_Max;
    }
}
