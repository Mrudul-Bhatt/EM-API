using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryContracts;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeesService(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        public async Task<IEnumerable<EmployeeResponse>> GetAllEmployees()
        {
            var employees = await _employeesRepository.GetAllEmployees();

            return employees.Select(employee => employee.ToEmployeeResponse()).ToList();
        }

        public async Task<EmployeeResponse> GetEmployeeById(Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeResponse> AddEmployee(AddEmployeeRequest addEmployeeRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateEmployee(UpdateEmployeeRequest updateEmployeeRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteEmployee(Guid employeeId)
        {
            throw new NotImplementedException();
        }
    }
}