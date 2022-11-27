using AutoCompleteDataAccessLayer.Model;

namespace AutoCompleteDataAccessLayer;

public interface IDataStorage
{
    Task<IEnumerable<Game>> SearchAsync(string? partOfNameSearch);
    Task<IEnumerable<string>> SearchGameTitles(string? partOfNameSearch);
}