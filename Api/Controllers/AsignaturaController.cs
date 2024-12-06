namespace Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServiceContracts;
    using Shared.Response;
    using Shared.Routing;

    [ApiController]
    [Route(AsignaturaControllerRoutes.Root)]
    public class AsignaturaController : ControllerBase
    {
        private readonly IAsignaturaService _service;

        public AsignaturaController(IAsignaturaService service)
        {
            _service = service;
        }

        [HttpGet("/{id}")]
        public IActionResult GetAsignatura(int id)
        {
            var result = _service.GetAsignaturaById(id);
            if (result is null || result == ResponseOfGetAsignatura.Empty) return NotFound();

            return Ok(result);
        }
    }
}
