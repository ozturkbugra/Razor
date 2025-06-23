using Razor.Models;

namespace Razor.Repository
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee {Id=1,Name = "Buğra Öztürk", Email = "ztrk1212@gmail.com",Photo="1.jpg",Department="Yönetici"},
                new Employee {Id=2,Name = "Fatma Öztürk", Email = "ztrk1213@gmail.com",Photo="2.jpg",Department="Yönetici 2"},
                new Employee {Id=3,Name = "Haşim Öztürk", Email = "ztrk1214@gmail.com",Photo="1.jpg",Department="Yönetici 3"},
                new Employee {Id=4,Name = "Sümeyye Öztürk", Email = "ztrk1215@gmail.com",Photo="3.jpg",Department="Yönetici 4"}
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeList;
        }
    }
}
