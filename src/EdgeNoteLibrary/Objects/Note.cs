using System;

namespace EdgeNote.Library.Objects
{
    public class Note : AbstractObject
    {
        public string Content { get; set; }

        public Guid? NoteType { get; set; }
    }
}
