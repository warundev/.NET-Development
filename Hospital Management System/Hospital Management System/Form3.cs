using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            viewPatientToolStripMenuItem.Click += viewPatientToolStripMenuItem_Click;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 patientForm = new Form4();
            patientForm.ShowDialog();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMessage = "Hospital Managment System\n" +
                             "Version 1.0\n\n" +
                             "This software helps manage Medical operations.\n" +
                             "Contact: medicare@uov.com\n\n"+
                             "Powered by: WP-Ideas@2024";
            MessageBox.Show(aboutMessage, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowPatientDetails()
        {
            // Check if there are patients to display
            if (Form4.Patients.Count == 0)
            {
                MessageBox.Show("No patients available.", "View Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create a string to store patient details
            string patientDetails = "Patient Details:\n\n";

            // Loop through each patient and add their details to the string
            foreach (var patient in Form4.Patients)
            {
                patientDetails += $"Name: {patient.Name}\n" +
                                  $"Index No: {patient.IndexNo}\n" +
                                  $"Age: {patient.Age}\n" +
                                  $"Gender: {patient.Gender}\n" +
                                  $"Mobile Number: {patient.MobileNumber}\n" +
                                  $"Email: {patient.Email}\n" +
                                  $"Address: {patient.Address}\n\n";
            }

            // Display patient details in a message box
            MessageBox.Show(patientDetails, "View Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void viewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPatientDetails();
        }
    }
}
