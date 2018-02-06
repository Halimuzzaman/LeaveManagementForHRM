using System.Data;
using Leave.DataClients;

namespace Leave
{
	namespace Supplements
	{
		static class Employees
		{
			private static string	server = @".\SQLExpress",
									database = "Leave",
									table = "Employee";
			
			public static DataTable GetEmployeeInfo(string rowConstraints = "")	{
				using(SqlTableTracker employeeTracker = new SqlTableTracker(server, database, table))	{
					return employeeTracker.Select(rowConstraints);
				}
			}

			public static DataTable GetSpecificEmployeeInfo(string columns, string rowConstraints = "")	{
				using(SqlTableTracker employeeTracker = new SqlTableTracker(server, database, table))	{
					return employeeTracker.SelectSpecific(columns, rowConstraints);
				}
			}
		}
	}
}
