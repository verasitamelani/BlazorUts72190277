using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUts72190277.Models;

namespace BlazorUts72190277.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task<Employee> Update(int id, Employee employee);
    }
}