//shubham

using core_Web_App.Models;
using Microsoft.Extensions.Caching.Memory;

namespace core_Web_App.Classes
{
    public interface ICacheServices
    {
        Person GetOrCreate<Person>(string cacheKey, Func<Person> createItem,MemoryCacheEntryOptions options);
        void Remove(string cacheKey);
    }

    public class ChacheService : ICacheServices
    { 
        private readonly IMemoryCache _cache;
        public ChacheService(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }

        public Person GetOrCreate<Person>(string cacheKey, Func<Person> createItem,MemoryCacheEntryOptions options)
        {
            return createItem();
        }

        public void Remove(string cacheKey)
        {
            _cache.Remove(cacheKey);    
        }
    }

}


