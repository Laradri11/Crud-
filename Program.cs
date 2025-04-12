// dotnet add package Microsoft.Data.SqlClient
using Microsoft.Data.SqlClient;

string connectionString = "Server=DESKTOP-GRL6K5D\\SQLEXPRESS;Database=UMG;Integrated Security=True; TrustServerCertificate=True; ";


using (SqlConnection connection = new SqlConnection(connectionString))
{
    try
    {
        connection.Open();
        Console.WriteLine("Conexión exitosa a la base de datos, ya estás listo para la clase del sábado.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
    }
}