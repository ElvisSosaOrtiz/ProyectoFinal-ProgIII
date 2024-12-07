namespace Client.Pages
{
    using Microsoft.AspNetCore.Components;
    using Shared.Response;
    using Shared.Routing;
    using System.Net.Http.Json;
    using System.Threading.Tasks;

    public partial class SeleccionAsignaturas
    {
        [Inject] private HttpClient HttpClient { get; init; } = null!;
        [Inject] private NavigationManager NavManager { get; init; } = null!;

        public IEnumerable<ResponseOfGetAsignatura> Asignaturas { get; set; } = [];

        private List<int> addIdAsignaturas = [];

        protected override async Task OnInitializedAsync()
        {
            Asignaturas = await HttpClient.GetFromJsonAsync<IEnumerable<ResponseOfGetAsignatura>>(AsignaturaControllerRoutes.GetAllAsignaturas) ?? [];
        }

        private async Task AddAsignaturasAsync()
        {
            await HttpClient.PostAsJsonAsync(EstudianteAsignaturaControllerRoutes.AddAsignaturas(4), JsonContent.Create(addIdAsignaturas));
        }
    }
}
