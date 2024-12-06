namespace Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServiceContracts;
    using Shared.Routing;

    [ApiController]
    [Route(EstudianteAsignaturaControllerRoutes.Root)]
    public class EstudianteAsignaturaController : ControllerBase
    {
        private readonly IEstudianteAsignaturaService _estudianteAsignaturaService;

        public EstudianteAsignaturaController(IEstudianteAsignaturaService estudianteAsignaturaService)
        {
            _estudianteAsignaturaService = estudianteAsignaturaService;
        }

        [HttpPost("{idEstudiante}")]
        public IActionResult AddAsignatura(
            [FromBody] List<int> idAsignaturas,
            int idEstudiante)
        {
            _estudianteAsignaturaService.AddAsignatura(idAsignaturas, idEstudiante);
            return Ok();
        }

        [HttpGet("{idEstudiante}")]
        public IActionResult GetAsignaturasEstudiante(int idEstudiante)
        {
            var result = _estudianteAsignaturaService.GetAsignaturasEstudiante(idEstudiante);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult RemoveAsignatura([FromBody] List<int> idAsignaturas)
        {
            _estudianteAsignaturaService.RemoveAsignatura(idAsignaturas);
            return Ok();
        }
    }
}
