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
    public partial class Dashboard : Form
    {
        public Dashboard(string fName, string lName, string dOB, string gender, string email, string rEmail, string pass, string rPass, string sQ, string sA, string address, string city, string state, string zip, string phone)
        {
            InitializeComponent();
            string output = String.Format("First Name: {0}" +
                "\nLast Name: {1}"+
                "\nDate Of Birth: {2}"+
                "\nGender: {3}",fName, lName,dOB,gender);
            ///MessageBox.Show(output);
            rTOutput.Text = output;
        }
    }
}
