namespace Client.Pages
{
    using Microsoft.AspNetCore.Components;
    using Shared.Response;
    using Shared.Routing;
    using System.Net.Http.Json;
    using System.Threading.Tasks;

    public partial class Profesor
    {
        [Inject] private HttpClient HttpClient { get; init; } = null!;

        [Parameter] public int ProfesorId { get; set; }

        public ResponseOfGetProfesor UnProfesor { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            UnProfesor = await HttpClient.GetFromJsonAsync<ResponseOfGetProfesor>(ProfesorControllerRoutes.GetProfesorId(ProfesorId)) ?? new();
        }
    }
}
