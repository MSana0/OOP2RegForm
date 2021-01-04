using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fName = textBoxFName.Text;
            string lName = textBoxLName.Text;
            string pass = textBoxPass.Text;
            string dOB = textBoxDOB.Text;
            string gender = comboBoxGender.Text;
            string email = textBoxEmail.Text;
            string rEmail = textBoxREmail.Text;
            string rPass = textBoxRPass.Text;
            string sQ = comboBoxSQ.Text;
            string sA = textBoxSA.Text;
            string address = textBoxAddress.Text;
            string city = textBoxCity.Text;
            string state = comboBoxState.Text;
            string zip = textBoxZC.Text;
            string phone = textBoxPhone.Text;

            /*string output = String.Format("First Name: {0}" +
                "\n Email: {1}" +
                "\n Password: {2}", fName, lName);
            MessageBox.Show(output);
            rTOutput.Text = output;*/
            new Dashboard(fName, lName, pass, dOB, gender, email, rEmail, rPass, sQ, sA, address, city, state, zip, phone).Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
