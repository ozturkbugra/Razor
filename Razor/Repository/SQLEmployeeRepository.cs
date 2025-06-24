using Razor.Models;

namespace Razor.Repository
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;

        public SQLEmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public Employee Update(Employee entity)
        {
            var entity2 = _context.Employees.FirstOrDefault(x => x.Id == entity.Id);
            if(entity2 != null)
            {
                entity2.Name = entity.Name;
                entity2.Email = entity.Email;
                entity2.Department = entity.Department;
                _context.SaveChanges();
            }

            return entity2;
        }
    }
}
