namespace LabApp
{
    partial class FormChoose
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
            labelchoose = new Label();
            btnbicycle = new Button();
            btnmushroom = new Button();
            SuspendLayout();
            // 
            // labelchoose
            // 
            labelchoose.AutoSize = true;
            labelchoose.Location = new Point(215, 50);
            labelchoose.Name = "labelchoose";
            labelchoose.Size = new Size(150, 20);
            labelchoose.TabIndex = 0;
            labelchoose.Text = "Choose a program";
            // 
            // btnbicycle
            // 
            btnbicycle.Location = new Point(120, 130);
            btnbicycle.Name = "btnbicycle";
            btnbicycle.Size = new Size(140, 40);
            btnbicycle.TabIndex = 1;
            btnbicycle.Text = "Bicycle";
            btnbicycle.UseVisualStyleBackColor = true;
            btnbicycle.Click += btnbicycle_Click;
            // 
            // btnmushroom
            // 
            btnmushroom.Location = new Point(320, 130);
            btnmushroom.Name = "btnmushroom";
            btnmushroom.Size = new Size(140, 40);
            btnmushroom.TabIndex = 2;
            btnmushroom.Text = "Mushroom";
            btnmushroom.UseVisualStyleBackColor = true;
            btnmushroom.Click += btnmushroom_Click;
            // 
            // FormChoose
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 250);
            Controls.Add(btnmushroom);
            Controls.Add(btnbicycle);
            Controls.Add(labelchoose);
            Name = "FormChoose";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose";
            FormClosed += FormChoose_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelchoose;
        private Button btnbicycle;
        private Button btnmushroom;
    }
}
