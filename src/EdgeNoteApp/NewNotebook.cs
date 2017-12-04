using EdgeNote.Library.Managers;
using System;
using System.IO;
using System.Windows.Forms;

namespace EdgeNote.App
{
    public partial class NewNotebook : Form
    {
        public string Filename { get; set; }
        public Notebook Notebook { get; set; }

        public NewNotebook()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "EdgeNote Files (*.edn)|*.edn";
            
            DialogResult dr = sfd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Filename = sfd.FileName;
                txtFilePath.Text = Filename;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (File.Exists(Filename))
            {
                MessageBox.Show("You must pick a new file");
                return;
            }

            Filename = txtFilePath.Text;
            Notebook = new Notebook(Filename, txtPassword.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Filename = null;
            Notebook = null;

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
