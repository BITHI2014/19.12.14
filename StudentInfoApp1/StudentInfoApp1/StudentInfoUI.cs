﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApp1
{
    public partial class StudentInfoUI : Form
    {
        public StudentInfoUI()
        {
            InitializeComponent();
        }
        List<Student> students=new List<Student>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student student1=new Student();
            student1.regNo = regNoTextBox.Text;
            student1.firstName = firstNameTextBox.Text;
            student1.lastName = lastNameTextBox.Text;
           
            students.Add(student1);
             MessageBox.Show("A new entry added");
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string save = "Registration No.    Name\n";
            foreach (Student aStudent in students)

            {
                save = save+aStudent.regNo + "    " + aStudent.firstName + " " + aStudent.lastName + "\n";
                
            }
            MessageBox.Show(save);

        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            students.Clear();
            MessageBox.Show("All data is clear");
        }
    }
}
