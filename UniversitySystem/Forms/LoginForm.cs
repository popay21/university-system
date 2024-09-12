// Forms/LoginForm.cs
using System;
using System.IO;
using System.Windows.Forms;
using UniversitySystem.Models;



namespace UniversitySystem.Forms
{
    public partial class LoginForm : Form
    {
        private const string UsersFilePath = "users.txt";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateUser(username, password))
            {
                Person user = GetUserDetails(username);
                OpenMainForm(user);
            }
            else
            {
                MessageBox.Show("שם משתמש או סיסמה לא נכונים.", "שגיאת התחברות", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Open registration form
            using (var registerForm = new RegisterForm())
            {
                if (registerForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("ההרשמה הושלמה בהצלחה. אנא התחבר.", "הרשמה הושלמה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                string[] lines = File.ReadAllLines(UsersFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 2 && parts[0] == username && parts[1] == password)
                    {
                        return true;
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"שגיאה בקריאת קובץ המשתמשים: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private Person GetUserDetails(string username)
        {
            try
            {
                string[] lines = File.ReadAllLines(UsersFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 5 && parts[0] == username)
                    {
                        string userType = parts[2];
                        string id = parts[3];
                        string name = parts[4];

                        switch (userType)
                        {
                            case "Student":
                                return new Student { Id = id, Name = name };
                            case "Lecturer":
                                return new Lecturer { Id = id, Name = name };
                            case "DepartmentHead":
                                return new DepartmentHead { Id = id, Name = name };
                            default:
                                throw new ArgumentException("סוג משתמש לא תקין.");
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"שגיאה בקריאת קובץ המשתמשים: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void OpenMainForm(Person user)
        {
            this.Hide();
            using (var mainForm = new MainForm(user))
            {
                mainForm.ShowDialog();
            }
            this.Close();
        }

    }
}
