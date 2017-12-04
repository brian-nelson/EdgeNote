using EdgeNote.App;
using EdgeNote.Library.Managers;
using EdgeNote.Library.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdgeNote.App
{
    public partial class MainForm : Form
    {
        private Notebook m_NoteBook;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNotebook onf = new OpenNotebook();

            onf.ShowDialog();

            if (onf.DialogResult == DialogResult.OK
                && onf.Notebook != null)
            {
                m_NoteBook = onf.Notebook;

                RefreshNotebook();    
            }
        }

        private void RefreshNotebook()
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewNotebook nnf = new NewNotebook();
            nnf.ShowDialog();

            if (nnf.DialogResult == DialogResult.OK
                && nnf.Notebook != null)
            {
                m_NoteBook = nnf.Notebook;

                RefreshNotebook();
            }
        }
    }
}
