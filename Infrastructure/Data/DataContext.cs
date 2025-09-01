using System;
using Npgsql;

namespace Infrastructure.Data;

public class DataContext
{
    private const string connectiontostring = "Server=localhost;Database=School_DB;Port=5432;Username=postgres;Password=929307b13;";
    public NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(connectiontostring);
    }
}
