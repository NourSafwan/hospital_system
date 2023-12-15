using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_system
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.FlatAppearance.BorderSize = 0;

            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.FlatAppearance.BorderSize = 0;
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void patientBtn_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Close();
        }

        private void diagnosisBtn_Click(object sender, EventArgs e)
        {
            Diagnosis Diagnosis = new Diagnosis();
            Diagnosis.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Search Search = new Search();
            Search.Show();
            this.Close();
        }
    }
}
