using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospital_system
{
    public partial class Search : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=NOURS-PC;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");

        private void displayDoctorDetails()
        {
            try
            {

                con.Open();
                string Query = "select* from Doctor where DocId='" + textBox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void displayPatientDetails()
        {
            try
            {
                con.Open();
                string Query = "select* from Patient where PId='" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void displayDiagnosisDetails()
        {
            try
            {
                con.Open();
                string Query = "select* from Diagnosis where DId='" + textBox3.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void displayPatientDiagnosisDetails()
        {
            try
            {
                con.Open();
                string Query = "SELECT Patient.PId, Patient.PName, Patient.PAge, Patient.PGen, Patient.BloodGroup, " +
                    "Patient.MajorDisease, Patient.DocId, Diagnosis.Did, Diagnosis.Symptoms, Diagnosis.DiagnosticTest, " +
                    "Diagnosis.Medicines FROM     Diagnosis INNER JOIN  " +
                    "Patient ON Diagnosis.PatientId = Patient.PId WHERE  " +
                    "(Patient.PId = '" + comboBox1.Text + "') ORDER BY Patient.PId";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public Search()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.FlatAppearance.BorderSize = 0;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                displayDoctorDetails();
            }
            else if (textBox2.Text != string.Empty)
            {
                displayPatientDetails();
            }
            else if (textBox3.Text != String.Empty)
            {
                displayDiagnosisDetails();
            }
            else if (comboBox1.Text != String.Empty)
            {
                displayPatientDiagnosisDetails();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
