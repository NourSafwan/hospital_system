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
    public partial class Diagnosis : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NOURS-PC;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");

        private void displayDiagnosis()
        {
            try
            {
                con.Open();
                string Query = "select* from Diagnosis ";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
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
        public Diagnosis()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.FlatAppearance.BorderSize = 0;
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalDataSet.Doctor);
            // TODO: This line of code loads data into the 'hospitalDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);
            
            displayDiagnosis();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" ||  textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();
                    string query = "insert into Diagnosis Values('" + textBox1.Text + "','" + comboBox1.Text  + "','" + textBox3.Text + "' , '" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox2.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayDiagnosis();
                    con.Open();
                    MessageBox.Show("Added sucessfully");
                }
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" ||  textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update Diagnosis Set PatientId = @PatientId , Symptoms=@Symptoms,DiagnosticTest = @DiagnosticTest , Medicines=@Medicines ,DocId=@DocId where DId= @DId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PatientId", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Symptoms", textBox3.Text);
                    cmd.Parameters.AddWithValue("@DiagnosticTest", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Medicines", textBox5.Text);
                    cmd.Parameters.AddWithValue("@DocId", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@DId", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayDiagnosis();
                    con.Open();
                    MessageBox.Show("Updated sucessfully");
                }
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("Enter the Diagnosis id");
                }
                else
                {
                    con.Open();
                    string Query = "delete from Diagnosis where DId='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayDiagnosis();
                    con.Open();
                    MessageBox.Show("Deleted sucessfully");
                }
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

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
