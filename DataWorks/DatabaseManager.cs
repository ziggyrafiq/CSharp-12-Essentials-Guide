using Microsoft.Data.SqlClient;
using System.Data;

namespace DataWorks;

public class DatabaseManager
{
    private const string ConnectionString = "Data Source=myServerAddress;Initial Catalog=myDatabase;User ID=myUsername;Password=myPassword;";

    public void ConnectToDatabase()
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            Console.WriteLine("Connected to the database.");
        }
    }

    public void ExecuteSqlCommand(string query)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("SQL command executed successfully.");
            }
        }
    }

    public void ReadDataUsingDataReader(string query)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                    }
                }
            }
        }
    }
    public void ReadDataUsingDataSet(string query)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "TableName");
                foreach (DataRow row in dataSet.Tables["TableName"].Rows)
                {
                    Console.WriteLine(row["ColumnName"]);
                }
            }
        }
    }


}
