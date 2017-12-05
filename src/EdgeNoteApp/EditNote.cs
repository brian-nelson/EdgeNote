using EdgeNote.Library.Objects;
using System;
using System.Windows.Forms;

namespace EdgeNote.App
{
    public partial class EditNote : Form
    {
        public EditNote()
        {
            InitializeComponent();
        }

        public Note Note { get; set; }

        public void SetupForm()
        {
            if (Note != null)
            {
                txtSubject.Text = Note.Subject;
                txtContent.Text = Note.Content;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Note == null)
            {
                Note = new Note();
            }

            Note.Subject = txtSubject.Text;
            Note.Content = txtContent.Text;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
