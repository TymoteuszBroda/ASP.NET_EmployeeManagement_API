using EmployeeManagement.Data;
using EmployeeManagement.Models;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task AddEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
