using System.Data;
using Dapper;
using GetApi.DataLayer.Interface;
using GetApi.Models.DataModels;
using GetApi;
using Microsoft.VisualBasic;

namespace GetApi.DataLayer.Classes;
public class GetApiData:IGetApiData
{
    private readonly DALBase dALBase;
    public GetApiData()
    {
        dALBase=new DALBase();
    }
    public IEnumerable<Command> GetCommands()
    {                
        var command= dALBase.Conn.Query<Command>(Query.Command.GetCommands);
        return command;
    }
}