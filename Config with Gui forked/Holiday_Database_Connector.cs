using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Leave.DataClients;

namespace Leave
{
    namespace Modules
    {
        class Holiday_Database_Connector
        {
            private static string server = @"(LocalDB)\v11.0",
                                    database = "Leave",
                                    tableName = "Holidays",
                                    connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Leave1.mdf" + ";Integrated Security=True",
                                   connection_string1 = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Leave;Integrated Security=True",
                                   connection_string2=@"Data Source=192.168.43.147,1234;Initial Catalog=Leave;User ID=group_leave;Password=oop2";

            public static DataView GetTable()
            {


                using (SqlTableTracker Databasetest = new SqlTableTracker(connection_string2, tableName))
                {
                    DataTable table = Databasetest.Select();
                    DataView table_view = table.AsDataView();
                    return table_view;
                }
            }
        }
    }
}
