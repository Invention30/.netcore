using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EntityManager;
using BusinessManager;

namespace EmpWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("getemp")]
        public List<Employee> Get()
        {
            EmpBusinessManager empBusinessManager = new EmpBusinessManager();
            return empBusinessManager.GetAllEmp();
        }
    }
}
