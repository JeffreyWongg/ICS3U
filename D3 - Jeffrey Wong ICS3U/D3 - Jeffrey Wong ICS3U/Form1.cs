// Jeffrey Wong
// ICS3U
// December 13th 2023
// D3

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3___Jeffrey_Wong_ICS3U
{
    public partial class Form1 : Form
    {
        // Initializing string variables to represent username and password
        string username;
        string password;

        public Form1()
        {
            InitializeComponent();
        }

        // This is when the username textbox gets text changed, which is assigned to a string variable called "username"
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            username = usernameTextBox.Text; // Assigns whatever the user inputs to the "username" variable
            username = username.ToUpper(); // Converts the username to uppercase to accept lowercase or uppercase inputs
        }

        // This is when the password textbox gets text changed, which is assigned to a string variable called "password"
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            password = passwordTextBox.Text; // Assigns whatever the user inputs to the "password" variable
            password = password.ToUpper(); // Converts the passwprd to uppercase to accept lowercase or uppercase inputs
        }

        // The "OK" button is used to confirm whether or not the user has entered the right username/password
        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (username.Equals("JEFFREY") && password.Equals("HELLO123")) // The username required is "jeffrey", the password required is "hello123", uppercase/lowercase does not matter
            {
                MessageBox.Show("Login Successful"); // Shows a message box to show the username and password are correct
                Application.Exit(); // Exits application
            }
            else // This means the username or password inputted does not match the desired input
            {
                MessageBox.Show("Access Denied"); // Shows a message box to indicate the username or password is incorrect
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*'; // Changes every character in the password textbox to an asterisks, which hides the input
        }
    }
}
