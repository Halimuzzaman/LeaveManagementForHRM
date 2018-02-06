using System.Data;
using Leave.DataClients;

namespace Leave
{
	namespace Supplements
	{
		static class LeavePeriods	{
			private static string	server		= ".\\SQLExpress",
									database	= "Leave",
									table		= "LeavePeriods";

			public static DataTable GetLeavePeriods(string rowConstraints = "")	{
				using(SqlTableTracker leavePeriodsTracker = new SqlTableTracker(server, database, table))	{
					return leavePeriodsTracker.Select(rowConstraints);
				}
			}
			
			public static void Insert(string columns, string rowConstraints = "")	{
				using(SqlTableTracker leavePeriodsTracker = new SqlTableTracker(server, database, table))	{
					leavePeriodsTracker.Insert(columns, rowConstraints);
				}
			}

			public static void Update(string changes, string rowConstraints = "")	{
				using(SqlTableTracker leavePeriodsTracker = new SqlTableTracker(server, database, table))	{
					leavePeriodsTracker.Update(changes, rowConstraints);
				}
			}

			public static void Delete(string rowConstraints = "")	{
				using(SqlTableTracker leavePeriodsTracker = new SqlTableTracker(server, database, table))	{
					leavePeriodsTracker.Delete(rowConstraints);
				}
			}
		}
	}
}
