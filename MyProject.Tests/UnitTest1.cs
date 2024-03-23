namespace MyProject.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("localhost")]
    [TestCase(@"(local)\SQL2017")]
    public void MicrosoftDataSqlClientTest(string dataSource)
    {
        var connectionString = new Microsoft.Data.SqlClient.SqlConnectionStringBuilder
        {
            DataSource = dataSource,
            UserID = "sa",
            Password = "Password12!",
            TrustServerCertificate = true,
        }.ConnectionString;

        using var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
        connection.Open();
        using var command = new Microsoft.Data.SqlClient.SqlCommand("SELECT 1", connection);
        if (command.ExecuteScalar() is { } result)
        {
            Console.WriteLine($"The result is {result}");
        }
    }

    [TestCase("localhost")]
    [TestCase(@"(local)\SQL2017")]
    public void SystemDataSqlClientTest(string dataSource)
    {
        var connectionString = new System.Data.SqlClient.SqlConnectionStringBuilder
        {
            DataSource = dataSource,
            UserID = "sa",
            Password = "Password12!",
            TrustServerCertificate = true,
        }.ConnectionString;

        using var connection = new System.Data.SqlClient.SqlConnection(connectionString);
        connection.Open();
        using var command = new System.Data.SqlClient.SqlCommand("SELECT 1", connection);
        if (command.ExecuteScalar() is { } result)
        {
            Console.WriteLine($"The result is {result}");
        }
    }
}