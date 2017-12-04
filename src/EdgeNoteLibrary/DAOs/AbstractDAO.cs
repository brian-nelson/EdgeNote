using EdgeNote.Library.Objects;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EdgeNote.Library.DAOs
{
    public abstract class AbstractDAO<T> where T:AbstractObject
    {
        protected LiteDatabase Database { get; private set; }
        protected LiteCollection<T> Collection { get; private set; }

        public AbstractDAO(LiteDatabase _db)
        {
            Database = _db;
            Collection = Database.GetCollection<T>(TableName);

            VerifyIndexes();
        }

        protected abstract void VerifyIndexes();
        protected abstract string TableName { get; }

        public T Get(Guid _guid)
        {
            T value = Collection.FindOne(Query.EQ("_id", _guid));

            return value;
        }

        public List<T> GetAll()
        {
            var list = Collection.FindAll();

            return list.ToList();
        }

        public void Save(T item)
        {
            Collection.Upsert(item);
        }

        public void Delete(Guid id)
        {
            Collection.Delete(id);
        }
    }
}
