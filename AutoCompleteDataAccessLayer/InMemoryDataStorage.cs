using AutoCompleteDataAccessLayer.data;
using AutoCompleteDataAccessLayer.Model;
namespace AutoCompleteDataAccessLayer;
public class InMemoryDataStorage : IDataStorage
{
    private IEnumerable<Game> _data = GamesDataClass.GetGames();

    public async Task<IEnumerable<string>> SearchGameTitles(string? partOfNameSearch)
    {
        var fullGames = await SearchAsync(partOfNameSearch);
        return fullGames.Select(fullGame => fullGame.Title);
    }

    public async Task<IEnumerable<Game>> SearchAsync(string? partOfNameSearch)
    {
        var matchingGames = _data.Where((game) => game.Title.Contains(partOfNameSearch +"", StringComparison.OrdinalIgnoreCase));
        return await Task.FromResult(matchingGames);
    }
}