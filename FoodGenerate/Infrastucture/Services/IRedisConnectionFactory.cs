using StackExchange.Redis;

namespace FoodGenerate.Infrastucture.Services
{
    public interface IRedisConnectionFactory
    {
        ConnectionMultiplexer Connection();
    }
}