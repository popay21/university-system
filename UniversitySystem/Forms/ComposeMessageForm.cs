using System;
using System.Windows.Forms;
using UniversitySystem.Models;

namespace UniversitySystem.Forms
{
    public partial class ComposeMessageForm : Form
    {
        private UniversitySystem.Models.Message message;
        private Person messageSender; // שינוי השם של המשתנה sender כדי להימנע מהתנגשות

        public ComposeMessageForm(Person sender)
        {
            InitializeComponent();
            this.messageSender = sender; // אתחול השולח
            this.message = new UniversitySystem.Models.Message(); // אתחול ההודעה
        }

        private void ComposeMessageForm_Load(object sender, EventArgs e)
        {
            LoadRecipients();
        }

        private void LoadRecipients()
        {
            // TODO: טען את רשימת הנמענים האפשריים
            // לדוגמה:
            // var recipients = DatabaseHandler.GetAllUsers();
            // cmbRecipient.DataSource = recipients;
            // cmbRecipient.DisplayMember = "Name";
            // cmbRecipient.ValueMember = "Id";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SendMessage();
            }
        }

        private bool ValidateInput()
        {
            if (cmbRecipient.SelectedItem == null)
            {
                MessageBox.Show("אנא בחר נמען.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSubject.Text))
            {
                MessageBox.Show("אנא הזן נושא להודעה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("אנא הזן תוכן להודעה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SendMessage()
        {
            var recipient = (Person)cmbRecipient.SelectedItem;
            message.Sender = messageSender;
            message.Receiver = recipient;
            message.Subject = txtSubject.Text; // שימוש ב-message שהוגדר מראש
            message.Content = txtContent.Text;
            message.Date = DateTime.Now;
            message.IsFavorite = false;

            // שמירת ההודעה במסד הנתונים
            DatabaseHandler.SaveMessage(message);

            MessageBox.Show("ההודעה נשלחה בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
