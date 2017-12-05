using EdgeNote.Library.DAOs;
using EdgeNote.Library.Objects;
using LiteDB;
using System.Collections.Generic;

namespace EdgeNote.Library.Managers
{
    public class Notebook
    {
        private string m_Filename;
        private string m_Password;
        private LiteDatabase m_DB;

        public Notebook(string _filename, string _password)
        {
            m_Filename = _filename;
            m_Password = _password;

            m_DB = new LiteDatabase($"Filename={m_Filename};Password={m_Password};");

            VerifyDatabase();
        }

        private void VerifyDatabase()
        {
            NoteTypeDAO noteTypeDao = new NoteTypeDAO(m_DB);
            NoteDAO noteDao = new NoteDAO(m_DB);
            NoteRelationshipDAO nrDao = new NoteRelationshipDAO(m_DB);           
        }

        public List<Note> GetAllNotes()
        {
            NoteDAO dao = new NoteDAO(m_DB);
            return dao.GetAll();
        }

        public void Save(Note note)
        {
            NoteDAO dao = new NoteDAO(m_DB);
            dao.Save(note);
        }
    }
}
