using EdgeNote.Library.Objects;
using LiteDB;

namespace EdgeNote.Library.DAOs
{
    internal class NoteTypeDAO : AbstractDAO<NoteType>
    {
        public NoteTypeDAO(LiteDatabase _db) : base(_db)
        {
        }

        protected override string TableName => "notetypes";

        protected override void VerifyIndexes()
        {

        }
    }
}
