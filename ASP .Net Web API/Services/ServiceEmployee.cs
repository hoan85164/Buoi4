using ASP_.Net_Web_API.Dto;
using ASP_.Net_Web_API.Entities;

namespace ASP_.Net_Web_API.Services
{
    public class ServiceEmployee : IEmployee
    {
        private static int Id = 0;
        private static List<Employee> _employee = new();
        private readonly ILogger _logger;

        public ServiceEmployee(ILogger<ServiceEmployee> logger)
        {
            _logger = logger;
            _logger.LogInformation("vào đây");
        }
        public void CreatEmployee(CreateEmployee input)
        {
            _employee.Add(new Employee 
            { 
                Id = ++ServiceEmployee.Id,
                Name = input.Name
            });
        }
        public object GetById(int Id)
        {
            var studentfind = _employee.FirstOrDefault(x => x.Id == Id);
            return studentfind;
        }
    }
}
