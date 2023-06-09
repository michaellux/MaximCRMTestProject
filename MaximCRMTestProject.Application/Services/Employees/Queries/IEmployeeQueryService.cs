using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximCRMTestProject.Application.Services.Employees.Queries
{
    public interface IEmployeeQueryService
    {
        Task<EmployeeResult> GetEmployee(EmployeeId id);
    }
}
