using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        // ? znaczy że zmienna może być null    
        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}";

    }
}
