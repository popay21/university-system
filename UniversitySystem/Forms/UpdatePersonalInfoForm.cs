using System;
using System.Windows.Forms;
using System.Xml.Linq;
using UniversitySystem.Models;

namespace UniversitySystem.Forms
{
    public partial class UpdatePersonalInfoForm : Form
    {
        private Person currentUser;

        public UpdatePersonalInfoForm(Person user)
        {
            InitializeComponent();
            currentUser = user;
            LoadCurrentInfo();
        }

        private void LoadCurrentInfo()
        {
            txtName.Text = currentUser.Name;
            txtEmail.Text = currentUser.Email;

            if (currentUser is Student student)
            {
                txtSpecificInfo.Text = student.Program;
                lblSpecificInfo.Text = "מסלול לימודים:";
            }
            else if (currentUser is Lecturer lecturer)
            {
                txtSpecificInfo.Text = lecturer.Department;
                lblSpecificInfo.Text = "מחלקה:";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                currentUser.Name = txtName.Text;
                currentUser.Email = txtEmail.Text;

                if (currentUser is Student student)
                {
                    student.Program = txtSpecificInfo.Text;
                }
                else if (currentUser is Lecturer lecturer)
                {
                    lecturer.Department = txtSpecificInfo.Text;
                }

                // TODO: Add code to save changes to database or file
                // For example:
                // DatabaseHandler.UpdateUser(currentUser);

                MessageBox.Show("הפרטים עודכנו בהצלחה!", "עדכון פרטים", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("אנא הזן שם.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("אנא הזן כתובת אימייל תקינה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSpecificInfo.Text))
            {
                MessageBox.Show("אנא הזן את המידע הספציפי.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void UpdatePersonalInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}