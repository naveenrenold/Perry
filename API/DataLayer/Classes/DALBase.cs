namespace GetApi.DataLayer.Classes;
using System.Data;
using System.Data.SqlClient;
using Dapper;

public class DALBase
{
    private readonly string ConnectionString="Server= DESKTOP-3KR5QNH; Database= master; Integrated Security=True";
    public SqlConnection Conn {get;set;}
    
    public DALBase()
    {
        Conn=new SqlConnection(ConnectionString);
    }
    ~DALBase()
    {
        Conn.Dispose();
    }
}