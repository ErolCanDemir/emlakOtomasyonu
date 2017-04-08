using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdvertApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent(); // componentleri başlattıık...
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool logged = false;

            if (username == "")
            {
                MessageBox.Show("Please type your 'username'.", "Oooppss!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password == "")
            {
                MessageBox.Show("Please type your 'password'.", "Oooppss!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string path = @"users.txt";
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string line = reader.ReadLine();

                string[] split = line.Split(';');
                Dictionary<string, string> users = new Dictionary<string, string>();

                /*
                 *  ["seymasa" => "10711453"]
                 */
                while (line != null)
                {
                    split = line.Split(';');
                    users.Add(split[0], split[1]);
                    line = reader.ReadLine();
                }
                file.Close();

                if (users.ContainsKey(username))
                {
                    if (users[username]==password)
                    {
                        logged = true;
                    }
                }

                if (logged)
                {
                    Program.Log(username+" has been logged in", "LOGIN");
                    Program.newForm = new AdvertsForm();
                    Program.close = false;
                    Close();
                }
                else
                {
                    MessageBox.Show("username or password is wrong.", "Oooppss!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
