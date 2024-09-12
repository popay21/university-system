using System;
using System.Windows.Forms;
using UniversitySystem.Models;

namespace UniversitySystem.Forms
{
    public partial class MessageDetailsForm : Form
    {
        private UniversitySystem.Models.Message message;

        public MessageDetailsForm(UniversitySystem.Models.Message message) // Line 9
        {
            InitializeComponent();
            this.message = message;
            LoadMessageDetails();
        }

        private void LoadMessageDetails()
        {
            lblSender.Text = $"מאת: {message.Sender.Name}";
            lblDate.Text = $"תאריך: {message.Date:dd/MM/yyyy HH:mm:ss}";
            txtContent.Text = message.Content;
            chkFavorite.Checked = message.IsFavorite;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void chkFavorite_CheckedChanged(object sender, EventArgs e)
        {
            message.IsFavorite = chkFavorite.Checked;
            // TODO: עדכן את ההודעה במסד הנתונים
            // DatabaseHandler.UpdateMessage(message);
        }

        private void MessageDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
