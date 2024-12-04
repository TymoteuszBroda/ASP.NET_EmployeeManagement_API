using EmployeeManagement.Models;
using EmployeeManagement.Models;
using EmployeeManagement.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepostiry)
        {
            _employeeRepository = employeeRepostiry;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployeesAsync()
        {
            var allEmployees = await _employeeRepository.GetAllAsync();
            return Ok(allEmployees);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null) 
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            await _employeeRepository.AddEmployeeAsync(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new {id = employee.id }, employee);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployeeById(int id)
        {
            await _employeeRepository.DeleteEmployeeAsync(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee)
        {
            if (id != employee.id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }
            await _employeeRepository.UpdateEmployeeAsync(employee);
            return NoContent();
        }


    }
}
