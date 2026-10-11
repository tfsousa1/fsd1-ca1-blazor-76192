
using System.Net.Http.Json;
using SchoolDirectory.Models;

namespace SchoolDirectory.Services;

public class SchoolService
{
    private readonly HttpClient _httpClient;

    public SchoolService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Retrieve the school array and deserialize it into C# objects.
    public async Task<List<School>> GetSchoolsAsync()
    {
        var schools = await _httpClient
            .GetFromJsonAsync<List<School>>("api/school");

        return schools ?? new List<School>();
    }
}
