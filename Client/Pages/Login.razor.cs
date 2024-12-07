namespace Client.Pages
{
    using Client.ViewModels;
    using Microsoft.AspNetCore.Components;
    using Microsoft.JSInterop;
    using Shared.Response;
    using Shared.Routing;
    using System.Net.Http.Json;

    public partial class Login
    {
        [Inject] private HttpClient HttpClient { get; init; } = null!;
        [Inject] private NavigationManager NavManager { get; init; } = null!;
        [Inject] private IJSRuntime JSRuntime { get; init; } = null!;

        private EstudianteViewModel ViewModel { get; set; } = new();

        private string LabelClass = "d-none";

        //private async Task SignInAsync()
        //{
        //    var estudiante = (await HttpClient.GetFromJsonAsync<ResponseOfGetEstudiante>(EstudianteControllerRoutes.GetEstudiante(ViewModel.Username, ViewModel.Password)))!;

        //    if (estudiante == ResponseOfGetEstudiante.Empty) LabelClass = string.Empty;
        //    else
        //    {
        //        LabelClass = "d-none";
        //        //await JSRuntime.InvokeVoidAsync("open", "/home", "_self");
        //        NavManager.NavigateTo("/home");
        //    }
        //}
    }
}
