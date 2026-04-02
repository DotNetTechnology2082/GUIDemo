using System.Xml.Linq;

namespace GUIDemo
{
    partial class StudentForm
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
            lblStudentForm = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblGender = new Label();
            lblDOB = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            dtDOB = new DateTimePicker();
            comboGender = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblStudentForm
            // 
            lblStudentForm.AutoSize = true;
            lblStudentForm.Location = new Point(516, 33);
            lblStudentForm.Name = "lblStudentForm";
            lblStudentForm.Size = new Size(137, 30);
            lblStudentForm.TabIndex = 0;
            lblStudentForm.Text = "Student Form";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(205, 130);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 30);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(205, 204);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(74, 30);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email: ";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(205, 274);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(83, 30);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone: ";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(205, 335);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(91, 30);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender: ";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(205, 412);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(67, 30);
            lblDOB.TabIndex = 5;
            lblDOB.Text = "DOB: ";
            // 
            // textBox1
            // 
            txtName.Location = new Point(316, 134);
            txtName.Name = "textBox1";
            txtName.Size = new Size(355, 35);
            txtName.TabIndex = 6;
            // 
            // textBox2
            // 
            txtEmail.Location = new Point(316, 201);
            txtEmail.Name = "textBox2";
            txtEmail.Size = new Size(355, 35);
            txtEmail.TabIndex = 7;
            // 
            // textBox3
            // 
            txtPhone.Location = new Point(316, 274);
            txtPhone.Name = "textBox3";
            txtPhone.Size = new Size(355, 35);
            txtPhone.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dtDOB.Location = new Point(321, 417);
            dtDOB.Name = "dateTimePicker1";
            dtDOB.Size = new Size(350, 35);
            dtDOB.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Location = new Point(317, 343);
            comboGender.Name = "comboBox1";
            comboGender.Size = new Size(354, 38);
            comboGender.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(388, 520);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 40);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(540, 520);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 40);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "button1";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 727);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(comboGender);
            Controls.Add(dtDOB);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblDOB);
            Controls.Add(lblGender);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblStudentForm);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentForm;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblGender;
        private Label lblDOB;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private DateTimePicker dtDOB;
        private ComboBox comboGender;
        private Button btnSave;
        private Button btnCancel;
    }
}