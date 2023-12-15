using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace hospital_system
{
    public partial class Doctor : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=NOURS-PC;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True");
        //SqlDataAdapter da; 
        //DataTable dt = new DataTable();
        //SqlCommand cmd;

        private void displayDoctor()
        {
            try
            {
                con.Open();
                string Query = "select* from Doctor ";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
                //var ds = new DataSet();
                //sda.Fill(ds);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                //dataGridView1.DataSource = ds.Tables[0];
                //con.Close();
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

        public Doctor()
        {
            InitializeComponent();
            //da = new SqlDataAdapter(@"select * from Doctor", con);
            //da.Fill(dt); 
            //dataGridView1.DataSource = dt;
            this.StartPosition = FormStartPosition.CenterScreen;

            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.FlatAppearance.BorderSize = 0;

        }

        private void Doctor_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'hospitalDataSet1.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalDataSet1.Doctor);
            // TODO: This line of code loads data into the 'hospitalDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);
            // TODO: This line of code loads data into the 'hospitalDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hospitalDataSet.Doctor);
            displayDoctor();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show(); 
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || comboBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " ")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();
                    string addQuery = "insert into Doctor Values(' " + textBox1.Text + " ' , '" + textBox2.Text + " ' , '" + comboBox2.Text + " ' , '" + textBox3.Text + " ' , '" + textBox4.Text + " ' )";
                    SqlCommand cmd = new SqlCommand(addQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayDoctor();
                    con.Open();
                    MessageBox.Show("Added sucessfully");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " )
                {
                    MessageBox.Show("Enter the doctor id");
                }
                else
                {
                    con.Open();
                    string Query = "delete from Doctor where DocId =' " + textBox1.Text + " ' ";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayDoctor();
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || comboBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " ")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();
                    string Query = "update Doctor set DocName = @Param2 , DocGen = @Param3 , Experience = @Param4 , Licensce = @Param5 where DocId = @Param1";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@Param1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Param2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Param3", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Param4", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Param5", textBox4.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayDoctor();
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
        

    }
}
