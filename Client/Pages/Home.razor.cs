namespace Client.Pages
{
    using Microsoft.AspNetCore.Components;
    using Shared.Response;
    using Shared.Routing;
    using System.Net.Http.Json;
    using System.Threading.Tasks;

    public partial class Home
    {
        [Inject] private HttpClient HttpClient { get; init; } = null!;

        public IEnumerable<ResponseOfGetEstudianteAsignatura> Asignaturas { get; set; } = [];

        protected override async Task OnInitializedAsync()
        {
            Asignaturas = await HttpClient.GetFromJsonAsync<IEnumerable<ResponseOfGetEstudianteAsignatura>>(EstudianteAsignaturaControllerRoutes.GetEstudianteAsignaturas(4)) ?? [];
        }
    }
}
