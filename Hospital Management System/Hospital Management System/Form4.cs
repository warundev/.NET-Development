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
    public class Patient
    {
        public string Name { get; set; }
        public string IndexNo { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
    public partial class Form4 : Form
    {
        public static List<Patient> Patients = new List<Patient>();
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient
            {
                Name = txtName.Text,
                IndexNo = txtIndex.Text,
                Age = int.Parse(txtAge.Text),
                Gender = txtGender.Text,
                MobileNumber = txtMobile.Text,
                Email = txtEmail.Text,
                Address = richTxtAddress.Text
            };

            // Add the patient to the static list
            Form4.Patients.Add(newPatient);

            MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form
            this.Close();
            
            Form3 homepage = new Form3();
            homepage.Show();
        }
    }
}
