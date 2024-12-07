namespace Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServiceContracts;
    using Shared.Response;
    using Shared.Routing;

    [ApiController]
    [Route(ProfesorAsignaturaControllerRoutes.Root)]
    public class ProfesorAsignaturaController : ControllerBase
    {
        private readonly IProfesorAsignaturaService _service;

        public ProfesorAsignaturaController(IProfesorAsignaturaService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetProfesorAsignaturaProfesorId(int id)
        {
            var result = _service.GetProfesorAsignaturaByProfesorId(id);
            return Ok(result);
        }
    }
}
