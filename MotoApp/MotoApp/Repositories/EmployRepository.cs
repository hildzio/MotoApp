using MotoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{
    internal class EmployRepository
    {
        private readonly List<Employee> _employees = new();

        public void Add(Employee employee)
        {
            employee.Id = _employees.Count + 1;
            _employees.Add(employee);   
        }

        public void Save()
        {
            foreach(var employee in _employees) 
            {
                Console.WriteLine(employee);
            }
        }

        public Employee GetById(int id)
        { 
            return _employees.Single(item => item.Id == id);
        }
    }
}
