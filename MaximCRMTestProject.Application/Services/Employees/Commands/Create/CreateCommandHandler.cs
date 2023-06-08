﻿using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Commands.CreateEmployees
{
    internal sealed class CreateCommandHandler : IRequestHandler<CreateCommand, EmployeeResult>
    {
        //private readonly IEmployeeRepository _employeeRepository;

        public CreateCommandHandler(IEmployeeRepository employeeRepository)
        {
            //_employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResult> Handle(CreateCommand command, CancellationToken token)
        {
            return null;

            //if (_employeeRepository.GetEmployeeByFullName(command.FullName) is not null)
            //{
            //    throw new EmployeeWithSameFullNameException(command.FullName);
            //}

            //EmployeeId employeeId = new EmployeeId(Guid.NewGuid());
            //var employee = new Employee(employeeId, command.FullName, command.Position);

            //var result = await _employeeRepository.Add(employee);

            //return new EmployeeResult(result.Id, result.FullName, result.Position);
        }
    }
}
