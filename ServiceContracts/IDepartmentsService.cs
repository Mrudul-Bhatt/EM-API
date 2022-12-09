using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceContracts.DTO;

namespace ServiceContracts
{
    public interface IDepartmentsService
    {
        Task<IEnumerable<DepartmentResponse>> GetAllDepartments();
        Task<DepartmentResponse> GetDepartmentById(Guid departmentId);
        Task<DepartmentResponse> AddDepartment(AddDepartmentRequest addDepartmentRequest);
        Task<bool> UpdateDepartment(UpdateDepartmentRequest updateDepartmentRequest);
        Task<bool> DeleteDepartment(Guid departmentId);
    }
}