namespace Client.Pages
{
    using Client.Routing;
    using Microsoft.AspNetCore.Components;
    using Shared.Response;
    using Shared.Routing;
    using System.Net.Http.Json;
    using System.Threading.Tasks;

    public partial class Asignatura
    {
        [Inject] private HttpClient HttpClient { get; init; } = null!;
        [Inject] private NavigationManager NavManager { get; init; } = null!;

        [Parameter] public int Id { get; set; }

        public ResponseOfGetAsignatura AsignaturaResponse { get; set; } = ResponseOfGetAsignatura.Empty;

        protected override async Task OnInitializedAsync()
        {
            AsignaturaResponse = await HttpClient.GetFromJsonAsync<ResponseOfGetAsignatura>(AsignaturaControllerRoutes.GetAsignatura(Id)) ?? new();
        }

        private void NavigateToProfesor(int id) => NavManager.NavigateTo(ClientRoutes.NavigateToProfesor(id));
    }
}
