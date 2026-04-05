namespace GUIDemo
{
    partial class DashboardForm
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
            btnDashboardForm = new Button();
            SuspendLayout();
            // 
            // btnDashboardForm
            // 
            btnDashboardForm.Location = new Point(42, 59);
            btnDashboardForm.Name = "btnDashboardForm";
            btnDashboardForm.Size = new Size(234, 40);
            btnDashboardForm.TabIndex = 0;
            btnDashboardForm.Text = "Manage Student";
            btnDashboardForm.UseVisualStyleBackColor = true;
            btnDashboardForm.Click += btnDashboardForm_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDashboardForm);
            Name = "DashboardForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDashboardForm;
    }
}