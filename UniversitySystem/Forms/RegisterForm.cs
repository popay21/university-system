// Forms/RegisterForm.cs
using System;
using System.IO;
using System.Windows.Forms;

namespace UniversitySystem.Forms
{
    public partial class RegisterForm : Form
    {
        private const string UsersFilePath = "users.txt";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType = cmbUserType.SelectedItem.ToString();
            string id = txtId.Text;
            string name = txtName.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(userType) || string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("אנא מלא את כל השדות.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UserExists(username))
            {
                MessageBox.Show("שם המשתמש כבר קיים במערכת.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string userInfo = $"{username},{password},{userType},{id},{name}";
                File.AppendAllText(UsersFilePath, userInfo + Environment.NewLine);
                MessageBox.Show("ההרשמה הושלמה בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"שגיאה בשמירת פרטי המשתמש: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UserExists(string username)
        {
            try
            {
                string[] lines = File.ReadAllLines(UsersFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length > 0 && parts[0] == username)
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
