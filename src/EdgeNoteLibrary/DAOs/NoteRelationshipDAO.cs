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
            var sideA = Collection.Find(Query.EQ("SideA", _id));
            var sideB = Collection.Find(Query.EQ("SideB", _id));

            List<NoteRelationship> relationships = new List<NoteRelationship>();
            relationships.AddRange(sideA);
            relationships.AddRange(sideB);

            return relationships;
        }
    }
}
