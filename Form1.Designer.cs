namespace WinFormsApp1
{
    partial class Form1
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
            button1 = new Button();
            txtusername = new TextBox();
            txtpasssword = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(385, 312);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(364, 190);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(150, 31);
            txtusername.TabIndex = 1;
            txtusername.TextChanged += textBox1_TextChanged;
            // 
            // txtpasssword
            // 
            txtpasssword.Location = new Point(364, 244);
            txtpasssword.Name = "txtpasssword";
            txtpasssword.Size = new Size(150, 31);
            txtpasssword.TabIndex = 2;
            txtpasssword.UseSystemPasswordChar = true;
            txtpasssword.TextChanged += txtpassword_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.ForeColor = Color.Maroon;
            panel1.Location = new Point(741, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 452);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.ForeColor = Color.Maroon;
            panel2.Location = new Point(1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(60, 452);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(219, 72);
            label1.Name = "label1";
            label1.Size = new Size(424, 45);
            label1.TabIndex = 5;
            label1.Text = "Computer Laboratoty Log";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(259, 117);
            label2.Name = "label2";
            label2.Size = new Size(349, 45);
            label2.TabIndex = 6;
            label2.Text = "Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtpasssword);
            Controls.Add(txtusername);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)

        {

        }

        #endregion

        private Button button1;
        private TextBox txtpasssword;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        public TextBox txtusername;
    }
}