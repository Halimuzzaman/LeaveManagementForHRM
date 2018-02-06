using System.Data;
using Leave.DataClients;

namespace Leave
{
	namespace Supplements
	{
		static class LeaveTypes
		{
            private static string   connectionString = @"Data Source=192.168.43.147,1234;Initial Catalog=Leave;User ID=group_leave;Password=oop2",
									table = "LeaveTypes";

			public static DataTable GetLeaveTypes(string rowConstraints = "")	{
				using(SqlTableTracker leaveTypesTracker = new SqlTableTracker(connectionString, table))	{
					return leaveTypesTracker.Select(rowConstraints);
				}
			}

            
		}
	}
}
