using APIXUnitTest.Model;
using APIXUnitTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace APIXUnitTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiWithCachingController : ControllerBase
    {
        private const string continentListCacheKey = "continentList";
        private readonly IGeographyService geographyService;
        private IMemoryCache _cache;
        private ILogger<ApiWithCachingController> _logger;
        public ApiWithCachingController(IGeographyService _geographyService,   IMemoryCache cache, ILogger<ApiWithCachingController> logger)
        {
            geographyService = _geographyService;
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        [HttpGet]
        public IEnumerable<Continent> GetAllContinent()
        {
            _logger.Log(LogLevel.Information, "Trying to fetch the list of continents from cache.");
            if (_cache.TryGetValue(continentListCacheKey, out IEnumerable<Continent> continents))
            {
                _logger.Log(LogLevel.Information, "continentlist found in cache.");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Continent list not found in cache. Fetching from database.");
                continents = geographyService.GetContinentList();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                        .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                        .SetPriority(CacheItemPriority.Normal)
                        .SetSize(1024);
                _cache.Set(continentListCacheKey, continents, cacheEntryOptions);
            }
            return (continents);
        }
    }
}
///// use this after each edit or create     _cache.Remove(continentListCacheKey);