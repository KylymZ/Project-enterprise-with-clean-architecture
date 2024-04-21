using Microsoft.AspNetCore.Mvc;

namespace Production.Enterprise.Api.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeesController : ControllerBase
    {
       private readonly ILogger<EmployeesController> _logger;

       public EmployeesController(ILogger<EmployeesController> logger)
        {
            _logger = logger;
        }
    }
}
