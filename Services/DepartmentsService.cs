using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{
    public class DepartmentsService : IDepartmentsService
    {
        public async Task<IEnumerable<DepartmentResponse>> GetAllDepartments()
        {
            throw new NotImplementedException();
        }

        public async Task<DepartmentResponse> GetDepartmentById(Guid departmentId)
        {
            throw new NotImplementedException();
        }

        public async Task<DepartmentResponse> AddDepartment(AddDepartmentRequest addDepartmentRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateDepartment(UpdateDepartmentRequest updateDepartmentRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteDepartment(Guid departmentId)
        {
            throw new NotImplementedException();
        }
    }
}