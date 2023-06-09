﻿using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Commands.Update
{
    public record UpdateCommand(EmployeeId EmployeeId, string FullName, string Position) : IRequest<EmployeeResult>;
}
