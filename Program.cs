using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  public class App(){
	    private readonly EmployeeService _employeeService; 
	    
	    public App(EmployeeService employeeService){
	      _employeeService = employeeService
	    }
	    
	    public Dictonary<string, decimal> NetSalary(){
	      _employeeService.NetSalary();
	    }
	  }
	  
		public static void Main(string[] args)
		{
		  App instance = new App();
			Console.WriteLine(App.NetSalary());
		}
	}
}