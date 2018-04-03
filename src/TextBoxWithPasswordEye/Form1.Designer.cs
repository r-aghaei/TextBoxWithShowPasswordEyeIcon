namespace TextBoxWithPasswordEye
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
            this.exTextBox1 = new TextBoxWithPasswordEye.ExTextBox();
            this.exTextBox2 = new TextBoxWithPasswordEye.ExTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exTextBox3 = new TextBoxWithPasswordEye.ExTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exTextBox1
            // 
            this.exTextBox1.Location = new System.Drawing.Point(12, 12);
            this.exTextBox1.Name = "exTextBox1";
            this.exTextBox1.ShowPasswordEye = true;
            this.exTextBox1.Size = new System.Drawing.Size(239, 26);
            this.exTextBox1.TabIndex = 0;
            this.exTextBox1.Text = "password";
            this.exTextBox1.UseSystemPasswordChar = true;
            // 
            // exTextBox2
            // 
            this.exTextBox2.Location = new System.Drawing.Point(12, 12);
            this.exTextBox2.Name = "exTextBox2";
            this.exTextBox2.ShowPasswordEye = true;
            this.exTextBox2.Size = new System.Drawing.Size(239, 26);
            this.exTextBox2.TabIndex = 0;
            this.exTextBox2.Text = "password";
            this.exTextBox2.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exTextBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 162);
            this.panel1.TabIndex = 1;
            // 
            // exTextBox3
            // 
            this.exTextBox3.Location = new System.Drawing.Point(12, 44);
            this.exTextBox3.Name = "exTextBox3";
            this.exTextBox3.Size = new System.Drawing.Size(239, 26);
            this.exTextBox3.TabIndex = 0;
            this.exTextBox3.Text = "password";
            this.exTextBox3.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 162);
            this.Controls.Add(this.exTextBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExTextBox exTextBox1;
        private ExTextBox exTextBox2;
        private System.Windows.Forms.Panel panel1;
        private ExTextBox exTextBox3;
    }
}

