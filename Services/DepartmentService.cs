using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorUts72190277.Models;

namespace BlazorUts72190277.Services
{
    public class DepartmentService : IDepartmentService
    {
        private HttpClient _httpClient;

        public DepartmentService(HttpClient httpClient){
            _httpClient = httpClient;    
        }
        public async Task<IEnumerable<Department>> GetAll()
        { 
            var rslt = await _httpClient.GetFromJsonAsync<IEnumerable<Department>>("api/Departments");
            return rslt;
        }

        public async Task<Department> GetById(int id)
        {
            var rslt = await _httpClient.GetFromJsonAsync<Department>($"api/Departments/{id}");
            return rslt;
        }
    }
}