namespace Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ServiceContracts;
    using Shared.Request;
    using Shared.Routing;

    [ApiController]
    [Route(EstudianteControllerRoutes.Root)]
    public class EstudianteController(IEstudianteService service) : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var result = service.GetStudentById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult RegisterStudent([FromBody] RequestOfRegisterStudent request)
        {
            service.RegisterStudent(request);
            return Ok();
        }
    }
}
