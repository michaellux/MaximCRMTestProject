using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Commands.UpdateEmployees
{
    internal sealed class UpdateCommandHandler : IRequestHandler<UpdateCommand>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCommandHandler(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(UpdateCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(request.EmployeeId);

            if (employee is null)
            {
                throw new EmployeeNotFoundException(request.EmployeeId);
            }

            var targetEmployeeWithName = await _employeeRepository.GetEmployeeByFullName(request.FullName);

            if (targetEmployeeWithName is null)
            {
                employee.Update(request.FullName, request.Position);
                _employeeRepository.Update(employee);

                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
            else
            {
                throw new EmployeeWithSameFullNameException(employee.FullName);
            }
        }
    }
}
