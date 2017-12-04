using System;
using System.Collections.Generic;
using LiteDB;
using EdgeNote.Library.Objects;

namespace EdgeNote.Library.DAOs
{
    internal class NoteRelationshipDAO : AbstractDAO<NoteRelationship>
    {
        public NoteRelationshipDAO(LiteDatabase _db) 
            : base(_db)
        {
        }

        protected override string TableName => "noterelationships";

        protected override void VerifyIndexes()
        {
            Collection.EnsureIndex("SideA");
            Collection.EnsureIndex("SideB");
        }

        public List<NoteRelationship> GetRelated(Guid _id)
        {
            return null;
        }
    }
}
