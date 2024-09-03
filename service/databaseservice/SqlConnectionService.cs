using System.Data;
using System.Data.SqlClient;

namespace Case409_csv.service.databaseservice
{
    internal class SqlConnectionService
    {
        private readonly String _connectionString;

        public SqlConnectionService(String connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetData(String query)
        {
            using (var connection = new SqlConnection(_connectionString))
            { 
                connection.Open();
            using (var command = new SqlCommand(query, connection))
            {
                using (var adapter = new SqlDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }

            }
            }
        }

    }
}
