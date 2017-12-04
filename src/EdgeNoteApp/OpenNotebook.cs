using EdgeNote.Library.Managers;
using LiteDB;
using System;
using System.IO;
using System.Windows.Forms;

namespace EdgeNote.App
{
    public partial class OpenNotebook : Form
    {
        public string Filename { get; set; }
        public Notebook Notebook { get; set; }

        public OpenNotebook()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "EdgeNote Files (*.edn)|*.edn";
            ofd.CheckFileExists = true;

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Filename = ofd.FileName;
                txtFilePath.Text = Filename;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Filename = txtFilePath.Text;

            if (!File.Exists(Filename))
            {
                MessageBox.Show("You must pick a file");
                return;
            }

            try
            {
                Notebook = new Notebook(Filename, txtPassword.Text);
            }
            catch (LiteException lex)
            {
                if (lex.ErrorCode == LiteException.DATABASE_WRONG_PASSWORD)
                {
                    MessageBox.Show("Invalid password");
                    return;
                }

                MessageBox.Show(lex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error occurred");
                return;
            }
            

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
