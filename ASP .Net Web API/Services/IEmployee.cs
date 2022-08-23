using ASP_.Net_Web_API.Dto;
using ASP_.Net_Web_API.Entities;

namespace ASP_.Net_Web_API.Services
{
    public interface IEmployee
    {
        void CreatEmployee(CreateEmployee input);
        object GetById(int Id);
    }
}
