namespace LabApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            textusername = new TextBox();
            label2 = new Label();
            textpassword = new TextBox();
            btnlogin = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 62);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // textusername
            // 
            textusername.Location = new Point(218, 62);
            textusername.Name = "textusername";
            textusername.Size = new Size(297, 27);
            textusername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 140);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textpassword
            // 
            textpassword.Location = new Point(218, 140);
            textpassword.Name = "textpassword";
            textpassword.PasswordChar = '*';
            textpassword.Size = new Size(297, 27);
            textpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(218, 220);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(421, 220);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 5;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 320);
            Controls.Add(btnexit);
            Controls.Add(btnlogin);
            Controls.Add(textpassword);
            Controls.Add(label2);
            Controls.Add(textusername);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textusername;
        private Label label2;
        private TextBox textpassword;
        private Button btnlogin;
        private Button btnexit;
    }
}
