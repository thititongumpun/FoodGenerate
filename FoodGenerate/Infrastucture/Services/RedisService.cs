using System;
using StackExchange.Redis;

namespace FoodGenerate.Infrastucture.Services
{
    public class RedisService<T> : BaseService<T>, IRedisService<T>
    {
        internal readonly IDatabase _db;
        protected readonly IRedisConnectionFactory _connectionFactory;
        public RedisService(IRedisConnectionFactory connectionFactory)
        {            
            _connectionFactory = connectionFactory;
            _db = _connectionFactory.Connection().GetDatabase();
        }

        public void Delete(string key)
        {
            if (string.IsNullOrWhiteSpace(key) || key.Contains(":")) throw new ArgumentException("invalid key");

            key = this.GenerateKey(key);
            _db.KeyDelete(key);
        }

        public T Get(string key)
        {
            key = this.GenerateKey(key);
            var hash = _db.HashGetAll(key);
            return this.MapFromHash(hash);
        }

        public void Save(string key, T obj)
        {
            if (obj != null)
            {
                var hash = this.GenerateHash(obj);
                key = this.GenerateKey(key);

                if (_db.HashLength(key) == 0)
                {
                    _db.HashSet(key, hash);
                }
                else
                {
                    var props = this.Properties;
                    foreach (var item in props)
                    {
                        if (_db.HashExists(key, item.Name))
                        {
                            _db.HashIncrement(key, item.Name, Convert.ToInt32(item.GetValue(obj)));
                        }
                    }
                }
            }
        }
    }
}