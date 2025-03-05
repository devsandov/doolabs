using System;

namespace Doolabs
{
	public class Employee : Person
	{
	  public decimal Salary { get; set }
	  public Date hire_date { get; set }
	  public string PersonId { get; set }
	  public string PositionId { get; set} 
	}
}