using System;
namespace Doolabs

public class EmployeeService
{
    private readonly EmployeeRepository _context;
    private readonly HelperEmployee _helper;

    public EmployeeService(EmployeeRepository context, HelperEmployee helper )
    {
        _context = context;
        _helper = helper
    }

    public void AddEmployee(Employee employee)
    {
            metodos del propio framework para realizar las consultas.
        _context.Employees.Add(employee);
        _context.SaveChanges();
    }

    public List<Employee> GetEmployees()
    {
        return _context.Employees.Include(e => e.Position).ToList();
    }

      public Employee GetEmployeeById(string id){
        return _context.Employee.Where(e => e.PersonReference == id ); 
      }
    
        // id del empleado
      public Dictonary<string, decimal> NetSalary(string id){
        var employee = _context.GetEmployeeById(id);
        return _helper.NetSalary(employee);
      }
}