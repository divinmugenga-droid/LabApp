namespace LabApp
{
    partial class FormMushroom
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
            labelinfo = new Label();
            labelquestion = new Label();
            btnyes = new Button();
            btnno = new Button();
            btnlogout = new Button();
            SuspendLayout();
            // 
            // labelinfo
            // 
            labelinfo.AutoSize = true;
            labelinfo.Location = new Point(40, 30);
            labelinfo.Name = "labelinfo";
            labelinfo.Size = new Size(400, 20);
            labelinfo.TabIndex = 0;
            labelinfo.Text = "Think of a mushroom and answer with Yes or No.";
            // 
            // labelquestion
            // 
            labelquestion.AutoSize = true;
            labelquestion.Location = new Point(40, 100);
            labelquestion.Name = "labelquestion";
            labelquestion.Size = new Size(300, 20);
            labelquestion.TabIndex = 1;
            labelquestion.Text = "Question";
            // 
            // btnyes
            // 
            btnyes.Location = new Point(40, 160);
            btnyes.Name = "btnyes";
            btnyes.Size = new Size(94, 35);
            btnyes.TabIndex = 2;
            btnyes.Text = "Yes";
            btnyes.UseVisualStyleBackColor = true;
            btnyes.Click += btnyes_Click;
            // 
            // btnno
            // 
            btnno.Location = new Point(160, 160);
            btnno.Name = "btnno";
            btnno.Size = new Size(94, 35);
            btnno.TabIndex = 3;
            btnno.Text = "No";
            btnno.UseVisualStyleBackColor = true;
            btnno.Click += btnno_Click;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(380, 270);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 4;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // FormMushroom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 330);
            Controls.Add(btnlogout);
            Controls.Add(btnno);
            Controls.Add(btnyes);
            Controls.Add(labelquestion);
            Controls.Add(labelinfo);
            Name = "FormMushroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom";
            FormClosed += FormMushroom_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelinfo;
        private Label labelquestion;
        private Button btnyes;
        private Button btnno;
        private Button btnlogout;
    }
}
