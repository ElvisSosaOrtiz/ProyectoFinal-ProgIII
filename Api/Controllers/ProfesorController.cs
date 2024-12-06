namespace Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServiceContracts;
    using Shared.Response;
    using Shared.Routing;

    [ApiController]
    [Route(ProfesorControllerRoutes.Root)]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorService _service;

        public ProfesorController(IProfesorService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetProfesor(int id)
        {
            var result = _service.GetProfesorById(id);
            if (result is null || result == ResponseOfGetProfesor.Empty) return NotFound();

            return Ok(result);
        }
    }
}
