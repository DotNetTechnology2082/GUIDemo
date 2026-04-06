using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUIDemo
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        int selectedIndex = -1;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            comboGender.Items.Add("Male");
            comboGender.Items.Add("Female");
            comboGender.Items.Add("Other");

            comboGender.SelectedIndex = 0;
        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                selectedIndex = e.RowIndex;
                Student student = students[selectedIndex];
                txtName.Text = student.Name;
                txtEmail.Text = student.Email;
                txtPhone.Text = student.Phone;
                dtDOB.Value = student.DOB;
                comboGender.Text = comboGender.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtName.Text;
            student.Email = txtEmail.Text;
            student.Phone = txtPhone.Text;
            student.DOB = dtDOB.Value;
            student.Gender = comboGender.Text;

            students.Add(student);

            //Here need to load Grid
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;
        }
    }
}
