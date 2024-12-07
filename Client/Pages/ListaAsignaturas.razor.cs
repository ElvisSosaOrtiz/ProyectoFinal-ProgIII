namespace Client.Pages
{
    using Microsoft.AspNetCore.Components;
    using Shared.Response;
    using Shared.Routing;
    using System.Net.Http.Json;
    using System.Threading.Tasks;

    public partial class ListaAsignaturas
    {
        [Inject] private HttpClient HttpClient { get; init; } = null!;

        private IEnumerable<ResponseOfGetAsignatura> Asignaturas { get; set; } = [];

        private List<string> Titulaciones = []; 

        private IEnumerable<ResponseOfGetAsignatura> FilterByTitulacion(string titulacion) => Asignaturas.Where(a => a.Titulacion == titulacion);

        protected override async Task OnInitializedAsync()
        {
            Asignaturas = await HttpClient.GetFromJsonAsync<IEnumerable<ResponseOfGetAsignatura>>(AsignaturaControllerRoutes.GetAllAsignaturas) ?? [];
            Titulaciones = Asignaturas.Select(a => a.Titulacion).ToList();
        }
    }
}
