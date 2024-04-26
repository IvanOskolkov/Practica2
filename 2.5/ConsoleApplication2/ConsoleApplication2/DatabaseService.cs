using Npgsql;

namespace GarageConsoleApp;

public static class DatabaseService
{
    private static NpgsqlConnection? _connection;
    private static string GetConnectionString()
    {
        return @"Host=10.30.0.137;Port=5432;Database=gr622_osiev;Username=gr622_osiev;Password=Algoritmus1";
    }
    public static NpgsqlConnection GetSqlConnection()
    {
        if (_connection is null)
        {
            _connection = new NpgsqlConnection(GetConnectionString());
            _connection.Open();
        }
        
        return _connection;
    }
}