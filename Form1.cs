using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var bday = Convert.ToDateTime(textBox3);
            var ts = DateTime.Today - bday;
            var year = DateTime.MinValue.Add(ts).Year - 1;
            return year >= 18;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           if (textBox4.Length < 8 || !textbox4.Any(char.IsUpper) || !textBox4.Any(char.IsLower) || !textBox4 = " @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\""");
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        
         if (textBox1.Text == "" || textBox2.Text == "" || testBox3.Text == "" || testBox3.Text == "" || testBox4.Text == "" || testBox5x.Text == "" || testBox6.Text == "")  
            {  
       MessageBox.Show("Please fill in all fields","Error",MessageBoxButton.OK,MessageBoxImage.Error);  
       firstNameTextBox.Focus();
         }
        private void Form1_Load_1(object sender, EventArgs e)
        {
        
        }
       }
    return;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            private void ValidateEmail()
            {
                string email = textBox3.Text;
                string unique= new un(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = un.Match(email);
                if (match.Success)
                    lbl_message.Text=email + " is Valid Email Address";  
                else
                    lbl_message.Text = email + " is Invalid Email Address"; 
            }  
        } 
       return;  
            }
private void button1_Click(object sender, EventArgs e)
{
string connectionString = sqlConnection con(db:employee)
}
}
