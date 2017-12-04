using LiteDB;
using System;

namespace EdgeNote.Library.Objects
{
    public abstract class AbstractObject
    {
        [BsonField("_id")]
        public Guid Id { get; set; }
    }
}
