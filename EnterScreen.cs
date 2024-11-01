using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLogin
{
    public partial class EnterScreen : Form
    {
        public EnterScreen()
        {
            InitializeComponent();
            this.Password.PasswordChar = '*';
            this.StartPosition = FormStartPosition.CenterScreen;
            LoginButton.Click += LoginButton_Click; // This error can be ignored
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            if (username == "Username" && password == "Password")
            {
                MainScreen mainScreen = new MainScreen(); // If changed, only edit MainScreen and not mainScreen
                {
                    StartPosition = FormStartPosition.CenterScreen;
                };
                mainScreen.Show(); // Shows the new Screen
                this.Hide(); // Hides the current Screen
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
