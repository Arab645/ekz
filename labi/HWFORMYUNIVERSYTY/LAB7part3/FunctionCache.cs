using System;
using System.Collections.Generic;
namespace LAB7part3
{
    public class FunctionCache<TKey, TResult>
    {
        private Dictionary<TKey, CacheItem> cache = new Dictionary<TKey, CacheItem>();

        public TResult GetOrCreate(TKey key, Func<TKey, TResult> function, TimeSpan expiration)
        {
            if (cache.TryGetValue(key, out var cacheItem) && !IsExpired(cacheItem))
            {
                return cacheItem.Result;
            }

            TResult result = function(key);
            cache[key] = new CacheItem(result, DateTime.Now.Add(expiration));
            return result;
        }

        private bool IsExpired(CacheItem cacheItem)
        {
            return DateTime.Now > cacheItem.Expiration;
        }

        private class CacheItem
        {
            public TResult Result { get; }
            public DateTime Expiration { get; }

            public CacheItem(TResult result, DateTime expiration)
            {
                Result = result;
                Expiration = expiration;
            }
        }
    }
}