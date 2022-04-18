using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;

namespace MultiProjectsRoute.Modules.WeatherForecast;

public class FetchDataBase : ComponentBase, IDisposable
{
    protected Shared.WeatherForecast[]? Forecasts;
    [Inject] private HttpClient Http { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Forecasts = await Http.GetFromJsonAsync<Shared.WeatherForecast[]>("WeatherForecast");
    }

    #region Dispose
    public void Dispose(bool disposing)
    {
        if (disposing)
        {
        }
    }
    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~FetchDataBase()
    {
        this.Dispose(false);
    }
    #endregion
}