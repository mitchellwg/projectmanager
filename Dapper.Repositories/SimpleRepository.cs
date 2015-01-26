using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq.Expressions;
using DapperExtensions;

namespace Dapper.Repositories
{
    public class SimpleRepository<T> : IRepository<T> where T : class, IEntity
    {
        private PredicateGroup _predicateGroup;

        private SqlConnection Connection {
            get {
                var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
                connection.Open();
                return connection;
            }
        }

        public IEnumerable<T> All() {
            return Connection.GetList<T>();
        }

        public T Get(int id)
        {
            return Connection.Get<T>(id);
        }

        public T Insert(T item)
        {
            return Connection.Insert(item);
        }

        public bool Update(T item)
        {
            return Connection.Update(item);
        }

        public bool Delete(T item)
        {
            return Connection.Update(item);
        }

        private SimpleRepository<T> Find(Expression<Func<T, object>> expression, object value, bool not)
        {
            if (_predicateGroup == null)
            {
                _predicateGroup = new PredicateGroup
                {
                    Operator = GroupOperator.And,
                    Predicates = new List<IPredicate>()
                };
            }

            var predicate = Predicates.Field(expression, Operator.Eq, value);
            _predicateGroup.Predicates.Add(predicate);
            return this;
        }

        public SimpleRepository<T> Find(Expression<Func<T, object>> expression, object value) { return Find(expression, value, false); }
        public SimpleRepository<T> FindNot(Expression<Func<T, object>> expression, object value) { return Find(expression, value, true); }
        public SimpleRepository<T> And(Expression<Func<T, object>> expression, object value) { return Find(expression, value); }
        public SimpleRepository<T> AndNot(Expression<Func<T, object>> expression, object value) { return Find(expression, value, true); }

        public IEnumerable<T> Build()
        {
            var enumerable = Connection.GetList<T>(_predicateGroup);
            _predicateGroup = null;
            return enumerable;
        }
    }
}
