using Getri_API_LstEmployees.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Getri_API_LstEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly List<Employee> lstEmployees = new List<Employee>();

        public EmployeeController()
        {            
            lstEmployees.Add(new Employee() { EmpId = 101, EmpName = "Jimmy", EmpGender = "Male", EmpAge = 20});
            lstEmployees.Add(new Employee() { EmpId = 102, EmpName = "Raj", EmpGender = "Male", EmpAge = 25});
            lstEmployees.Add(new Employee() { EmpId = 103, EmpName = "Ricky", EmpGender = "Female", EmpAge = 23 });
            lstEmployees.Add(new Employee() { EmpId = 104, EmpName = "Cris", EmpGender = "Male", EmpAge = 27 });
            lstEmployees.Add(new Employee() { EmpId = 105, EmpName = "Jennifer", EmpGender = "Female", EmpAge = 22 });          
        }

        [HttpGet("FetchEmployees")]
        public IEnumerable<Employee> GetRecords()
        {
               return lstEmployees;
        }

        [HttpGet("{id}", Name = "FetchEmployeeById")]
        public Employee FetchById(int id)
        {
            return lstEmployees.FirstOrDefault(e => e.EmpId == id);            
        }
    }
}
