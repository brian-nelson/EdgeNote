using System;

namespace EdgeNote.Library.Objects
{
    public class NoteRelationship : AbstractObject
    {
        public Guid SideA { get; set; }

        public Guid SideB { get; set; }
    }
}
