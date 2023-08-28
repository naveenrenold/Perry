using GetApi.DataLayer.Interface;
using GetApi.Models.DataModels;

namespace GetApi.DataLayer.Classes;
public class GetApiData:IGetApiData
{
    public Command GetCommands()
    {
        var command=new Command();
        return command;
    }
}