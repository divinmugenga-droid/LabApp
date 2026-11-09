namespace LabApp
{
    partial class FormBicycle
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
            textstart = new TextBox();
            label2 = new Label();
            textend = new TextBox();
            btncalculate = new Button();
            label3 = new Label();
            texttotal = new TextBox();
            btnlogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 40);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Start time (0 - 23)";
            // 
            // textstart
            // 
            textstart.Location = new Point(260, 37);
            textstart.Name = "textstart";
            textstart.Size = new Size(200, 27);
            textstart.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 90);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 2;
            label2.Text = "End time (1 - 24)";
            // 
            // textend
            // 
            textend.Location = new Point(260, 87);
            textend.Name = "textend";
            textend.Size = new Size(200, 27);
            textend.TabIndex = 3;
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(260, 140);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(120, 35);
            btncalculate.TabIndex = 4;
            btncalculate.Text = "Calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 205);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Total";
            // 
            // texttotal
            // 
            texttotal.Location = new Point(260, 202);
            texttotal.Name = "texttotal";
            texttotal.ReadOnly = true;
            texttotal.Size = new Size(200, 27);
            texttotal.TabIndex = 6;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(380, 270);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 7;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // FormBicycle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 330);
            Controls.Add(btnlogout);
            Controls.Add(texttotal);
            Controls.Add(label3);
            Controls.Add(btncalculate);
            Controls.Add(textend);
            Controls.Add(label2);
            Controls.Add(textstart);
            Controls.Add(label1);
            Name = "FormBicycle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bicycle Rental";
            FormClosed += FormBicycle_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textstart;
        private Label label2;
        private TextBox textend;
        private Button btncalculate;
        private Label label3;
        private TextBox texttotal;
        private Button btnlogout;
    }
}
