using LiteDB;
using EdgeNote.Library.Objects;

namespace EdgeNote.Library.DAOs
{
    internal class NoteDAO : AbstractDAO<Note>
    {
        public NoteDAO(LiteDatabase _db) : base(_db)
        {
        }

        protected override string TableName => "Notes";

        protected override void VerifyIndexes()
        {

        }
    }
}
