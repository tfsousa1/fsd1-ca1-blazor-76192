using System.Net.Http.Json;
using SchoolDirectory.Models;

namespace SchoolDirectory.Services;

public class SchoolService
{
    private readonly HttpClient _httpClient;

    // Receive the configured HTTP client through dependency injection.
    public SchoolService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Retrieve the API response and return the schools inside its value property.
    public async Task<List<School>> GetSchoolsAsync()
    {
        var response = await _httpClient
            .GetFromJsonAsync<SchoolApiResponse>("api/school");

        return response?.Value ?? new List<School>();
    }
}