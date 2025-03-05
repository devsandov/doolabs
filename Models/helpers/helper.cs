using System;

namespace Doolabs
{
	public class Helper
	{
	  public Dictionary<string, decimal> NetSalary(Employee employee)
      {
        // el primero para el name y el segundo para el Salary
        var result = new Dictionary<string, decimal>();

        foreach (var empACargo in employee.PersonReference)
        {
            
            decimal salaryNet = empACargo.Salary + empACargo.PositionReference.Bonus;
            result.Add(empACargo.FullName, salaryNet);
        }

        return resultado;
      }
	}
}