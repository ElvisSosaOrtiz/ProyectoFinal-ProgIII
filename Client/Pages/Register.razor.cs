namespace Client.Pages
{
    using Client.ViewModels;
    using Microsoft.AspNetCore.Components;

    public partial class Register
    {
        [Inject]
        private NavigationManager NavManager { get; init; } = null!;

        private EstudianteViewModel ViewModel { get; set; } = new();
    }
}
