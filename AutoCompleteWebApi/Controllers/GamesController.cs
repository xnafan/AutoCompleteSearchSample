using AutoCompleteDataAccessLayer;
using AutoCompleteDataAccessLayer.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoCompleteWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class GamesController : ControllerBase
    {
        private IDataStorage _dataService;

        public GamesController(IDataStorage dataService) => _dataService = dataService;

        [HttpGet("Search")]
        public async Task <IEnumerable<Game>> Search([FromQuery]string? partOfNameSearch)
        {
            return await _dataService.SearchAsync(partOfNameSearch);
        }

        [HttpGet("SearchGameNames")]
        public async Task<IEnumerable<string>> SearchGameNames([FromQuery] string? partOfNameSearch)
        {
            return await _dataService.SearchGameTitles(partOfNameSearch);
        }
    }
}
