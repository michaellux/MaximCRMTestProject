using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Commands.DeleteEmployees
{
    internal sealed class DeleteCommandHandler : IRequestHandler<DeleteCommand>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCommandHandler(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(request.EmployeeId);

            if (employee is null)
            {
                throw new EmployeeNotFoundException(request.EmployeeId);
            }

            _employeeRepository.Remove(employee);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
